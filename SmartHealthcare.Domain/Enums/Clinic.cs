namespace SmartHealthcare.Domain.Entities;

public class Clinic : BaseEntity
{
    public required string Name { get; set; }

    public required string Address { get; set; }
}