using System;

namespace StudentLibrary
{
    public class Student

    {
        public Student(int id, string givenName, string surName, DateTime startDate, DateTime graduationDate)
        {
            Id = id;
            EndDate = new DateTime(1, 1, 1);
        }
        public int Id { get; }
        public string GivenName { get; set; }
        public string SurName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime GraduationDate { get; set; }
        public Status Status
        {
            get => CalculateStatus(DateTime.Now);
        }

        public Status CalculateStatus(DateTime now)
        {
            if (EndDate.Year != 1)
            {
                return Status.Dropout;
            }
            else if (now.Year == StartDate.Year)
            {
                return Status.New;
            }
            else if (now.CompareTo(StartDate) > 0 && now.CompareTo(GraduationDate) < 0)
            {
                return Status.Active;
            }
            else if (now.CompareTo(GraduationDate) > 0)
            {
                return Status.Graduated;
            }
            else
            {
                return Status.Null;
            }
        }
    }
}

public enum Status
{
    New,
    Active,
    Dropout,
    Graduated,
    Null
}
