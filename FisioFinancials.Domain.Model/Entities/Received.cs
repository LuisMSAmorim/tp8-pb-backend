using System.ComponentModel.DataAnnotations;

namespace FisioFinancials.Domain.Model.Entities;

public sealed class Received 
{
    [Key]
    public int ReceivedId { get; set; }
    [Required]
    public string PatientName { get; set; }
    [Required]
    public int Value { get; set; }
    [Required]
    public string City { get; set; }
    [Required]
    public string Local { get; set; }
    [Required]
    public DateTime Date { get; set; }
    public User User { get; set; }

    public Received(string patientName, int value, string city, string local, DateTime date)
    {
        PatientName = patientName;
        Value = value;
        City = city;
        Local = local;
        Date = date;
    }
}
