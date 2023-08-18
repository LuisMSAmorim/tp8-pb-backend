using FisioFinancials.Domain.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace FisioFinancials.Infrastructure.Data.Context;

public class FisioFinancialsDbContext : DbContext
{
     public FisioFinancialsDbContext(DbContextOptions<FisioFinancialsDbContext> options) : base(options) { }

    public virtual DbSet<Received> Receiveds { get; set; }
}
