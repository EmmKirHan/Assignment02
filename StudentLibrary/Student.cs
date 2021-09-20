using System;

namespace StudentLibrary
{
    public class Student

    {
        public Student(int id, string givenName, string surName, DateTime startDate, DateTime graduationDate)
        {
            Id = id;
            EndDate = new DateTime(1000, 1, 1);
        }
        public int Id { get; }
        public string GivenName { get; set; }
        public string SurName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime GraduationDate { get; set; }
        public Status Status
        {
            get
            {
                return Status;
            }
            private set { Status = value; }
        }

        private void UpdateStatus()
        {
            if (EndDate.Year != 1000)
            {
                Status = Status.Dropout;
            }
            else if (DateTime.Now.Year == StartDate.Year)
            {
                Status = Status.New;
            }
            else if (DateTime.Now > StartDate && DateTime.Now < GraduationDate)
            {
                Status = Status.Active;
            }
            else if (DateTime.Now > GraduationDate)
            {
                Status = Status.Graduated;
            }
        }
    }
}

public enum Status
{
    New,
    Active,
    Dropout,
    Graduated
}
