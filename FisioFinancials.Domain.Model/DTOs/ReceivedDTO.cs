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

    public void Deconstruct(out string PatientName, out Decimal Value, out string City, out string Local, out DateTime Date)
    {
        PatientName = this.PatientName;
        Value = this.Value;
        City = this.City;
        Local = this.Local;
        Date = this.Date;
    }
}
