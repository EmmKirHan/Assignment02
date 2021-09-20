using System;
using Xunit;
using StudentLibrary;

namespace Tests
{
    public class StudentTests
    {
        // [Fact]
        // public void Status_is_read_only()
        // {

        // }

        [Fact]
        public void Status_is_Active_if_current_day_is_between_StartDate_and_GradutionDate()
        {
            //int id, string givenName, string surName, DateTime startDate, DateTime graduationDate
            Student student = new Student(1234, "Bob", "Alicesen", new DateTime(2020, 8, 1), new DateTime(2024, 6, 30));

            Assert.Equal(Status.Active, student.Status);
        }

        [Fact]
        public void Status_is_New_if_Current_Year_equals_Start_Year()
        {
            Student student = new Student(1234, "Alice", "Bobsen", new DateTime(2021, 8, 1), new DateTime(2024, 6, 30));

            Assert.Equal(Status.New, student.Status);
        }

        [Fact]
        public void Status_is_Dropout_if_EndDate_is_before_GraduationDate()
        {
            Student student = new Student(1234, "Per", "Persen", new DateTime(2021, 8, 1), new DateTime(2024, 6, 30));

            student.EndDate = new DateTime(2021, 9, 1);

            Assert.Equal(Status.Dropout, student.Status);
        }

        [Fact]
        public void Status_is_Graduated_if_Current_date_is_after_Graduation_date_and_EndDate_is_null()
        {
            Student student = new Student(1234, "Lisa", "Karstensen", new DateTime(2018, 8, 1), new DateTime(2021, 6, 30));

            Assert.Equal(Status.Graduated, student.Status);
        }

        // [Fact]
        // public void Status_is_null_if_current_date_is_before_startDate()
        // {
        //     Student student = new Student(1234, "Sofie", "Karstensen", new DateTime(2022, 8, 1), new DateTime(2025, 6, 30));
        //     //Assert.(student.Status);
        // }

        [Fact]
        public void ToString_returns_something_nice()
        {

        }
    }
}
