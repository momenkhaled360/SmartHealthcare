using SmartHealthcare.Domain.Entities;

public class Appointment : BaseEntity
{
    public int PatientId { get; set; }
    public required Patient Patient { get; set; }

    public int DoctorId { get; set; }
    public required Doctor Doctor { get; set; }

    public int ClinicId { get; set; }
    public required Clinic Clinic { get; set; }
    

    public DateTime AppointmentDate { get; set; }

    public required string Status { get; set; }
}