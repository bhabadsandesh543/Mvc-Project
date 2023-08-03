namespace mvc_project.Models;

public class Appointment
{
    public int Id{get; set;}
    public DateTime DateTime{get; set;}
    public AppointmentStatus Status{get; set;}
    public int AsylumSeekerId{get; set;}
    public int InterviewerId{get; set;}

}
public enum AppointmentStatus
{
    Peding,
    Approved,
    Reject
}