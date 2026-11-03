namespace SmartHealthcare.Domain.Entities;

public class Doctor : Person
{
    public required string Specialization { get; set; }
}