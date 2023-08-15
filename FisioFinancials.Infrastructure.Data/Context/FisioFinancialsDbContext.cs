using FisioFinancials.Domain.Model.Entities;
using System.Data.Entity;

namespace FisioFinancials.Infrastructure.Data.Context;

public class FisioFinancialsDbContext : DbContext
{
     public FisioFinancialsDbContext() : base("Server=(localdb)\\MSSQLLocalDB; Database=FisioFinancialsDB; Trusted_Connection=True") { }

    public virtual DbSet<Received> Receiveds { get; set; }
}
