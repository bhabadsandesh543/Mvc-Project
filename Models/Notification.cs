namespace mvc_project.Models;

public class Notification
{
    public int Id{get; set;}
    public int UserId{get; set;}
    public required string Message{get; set;}
    public bool IsRead{get; set;}
}