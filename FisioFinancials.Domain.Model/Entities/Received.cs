using System.ComponentModel.DataAnnotations;
using FisioFinancials.Domain.Model.Entities.Common;

namespace FisioFinancials.Domain.Model.Entities;

public sealed class Received : BaseEntity
{
    [Required]
    public string PatientName { get; set; }
    [Required]
    public decimal Value { get; set; }
    [Required]
    public string City { get; set; }
    [Required]
    public string Local { get; set; }
    [Required]
    public DateTime Date { get; set; }

    public Received(string patientName, decimal value, string city, string local, DateTime date)
    {
        PatientName = patientName;
        Value = value;
        City = city;
        Local = local;
        Date = date;
    }

    public Received()
    {
    }
}
