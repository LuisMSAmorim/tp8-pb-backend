using System.ComponentModel.DataAnnotations;

namespace FisioFinancials.Domain.Model.Entities.Common;

public abstract class BaseEntity
{
    [Key]
    public int Id { get; }
}
