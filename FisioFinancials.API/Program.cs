using FisioFinancials.ClassLoader;
using FisioFinancials.Domain.Model.Entities;
using FisioFinancials.Infrastructure.Data.Context;
using FisioFinancials.Infrastructure.IoC;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services
    .AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<FisioFinancialsDbContext>()
    .AddDefaultTokenProviders();

DependencyInjectorHelper.Register(builder.Services);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

using (var serviceScope = app.Services.GetRequiredService<IServiceScopeFactory>().CreateScope())
{
    var context = serviceScope.ServiceProvider.GetService<FisioFinancialsDbContext>();
    ClassLoader.PopulateDatabase(context);
}

app.Run();
