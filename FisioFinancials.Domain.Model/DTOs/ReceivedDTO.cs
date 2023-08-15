using System.ComponentModel.DataAnnotations;

namespace FisioFinancials.Domain.Model.DTOs;

public sealed class ReceivedDTO
{
    [Required]
    public string PatientName { get; private set; }
    [Required]
    public Decimal Value { get; private set; }
    [Required]
    public string City { get; private set; }
    [Required]
    public string Local { get; private set; }
    [Required]
    public DateTime Date { get; private set; }
}
