using System;
using Xunit;
using StudentLibrary;

namespace Tests
{
    public class StudentTests
    {
        [Fact]
        public void Status_is_Active_if_current_day_is_between_StartDate_and_GradutionDate()
        {
            //int id, string givenName, string surName, DateTime startDate, DateTime graduationDate
            Student student = new Student(5678, "Bob", "Alicesen", new DateTime(2020, 8, 1), new DateTime(2024, 6, 30));

            Assert.Equal(Status.Active, student.Status);
        }

        [Fact]
        public void Status_is_New_if_Current_Year_equals_Start_Year()
        {
            Student student = new Student(1234, "Alice", "Bobsen", new DateTime(2021, 8, 1), new DateTime(2024, 6, 30));

            Assert.Equal(Status.New, student.CalculateStatus(new DateTime(2021, 9, 22)));
        }

        [Fact]
        public void Status_is_Dropout_if_EndDate_is_not_default_value()
        {
            Student student = new Student(9101, "Per", "Persen", new DateTime(2021, 8, 1), new DateTime(2024, 6, 30));

            student.EndDate = new DateTime(2021, 9, 1);

            Assert.Equal(Status.Dropout, student.CalculateStatus(new DateTime(2021, 9, 22)));
        }

        [Fact]
        public void Status_is_Graduated_if_Current_date_is_after_Graduation_date_and_EndDate_is_null()
        {
            Student student = new Student(1121, "Lisa", "Karstensen", new DateTime(2018, 8, 1), new DateTime(2021, 6, 30));

            Assert.Equal(Status.Graduated, student.CalculateStatus(new DateTime(2021, 9, 22)));
        }

        [Fact]
        public void Status_is_null_if_current_date_is_before_startDate()
        {
            Student student = new Student(3141, "Sofie", "Karstensen", new DateTime(2022, 8, 1), new DateTime(2025, 6, 30));
            Assert.Equal(Status.Null, student.CalculateStatus(new DateTime(2021, 9, 22)));
        }

        [Fact]
        public void ToString_returns_id_name_and_status()
        {
            Student student = new Student(5161, "Lotte", "Holm", new DateTime(2021, 9, 1), new DateTime(2024, 6, 30));
            string expected = "Id: 5161 - Name: Lotte Holm - Status: New";
            string actual = student.ToString();

            Assert.Equal(expected, actual);
        }
    }
}
