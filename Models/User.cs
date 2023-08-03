namespace mvc_project.Models;
    public class User
    {
        public int Id{get; set;}
        public required string Username{get; set;}
        public required string Password{get; set;}
        public Userrole Role{get; set;}

    }
    public enum Userrole
    {
        AsylumSeeker,
        Interviewer
    }