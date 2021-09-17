using System;

namespace StudentLibrary
{
    public class Student

    {
        public Student(int id, string givenName, string surName, DateTime startDate, DateTime endDate, DateTime graduationDate)
        {
            Id = id;
            if (DateTime.Now > startDate && DateTime.Now < endDate)
            {
                Status = Status.Active;
            }
            else if ()
        }
        public int Id { get; }
        public string GivenName { get; set; }
        public string SurName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime GraduationDate { get; set; }
        public Status Status { get; }

    }
}

public enum Status
{
    New,
    Active,
    Dropout,
    Graduated
}
