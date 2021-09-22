using System;

namespace StudentLibrary
{
    public record ImmutableStudent
    {
        public int Id { get; init; }
        public string GivenName { get; init; }
        public string SurName { get; init; }
        public DateTime StartDate { get; init; }
        public DateTime EndDate { get; init; }
        public DateTime GraduationDate { get; init; }
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

        public override string ToString()
        {
            return "Id: " + Id + " - Name: " + GivenName + " " + SurName + " - Status: " + Status;
        }
    }
}