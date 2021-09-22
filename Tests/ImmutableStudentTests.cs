using System;
using Xunit;
using StudentLibrary;

namespace Tests
{
    public class ImmutableStudentTests
    {
        [Fact]
        public void Two_instances_of_ImmutableStudent_are_equal_if_they_contain_the_same_values()
        {
            ImmutableStudent student1 = new ImmutableStudent { Id = 1234, GivenName = "Søren", SurName = "Sørensen", StartDate = new DateTime(2021, 9, 1), EndDate = new DateTime(2024, 6, 30) };
            ImmutableStudent student2 = new ImmutableStudent { Id = 1234, GivenName = "Søren", SurName = "Sørensen", StartDate = new DateTime(2021, 9, 1), EndDate = new DateTime(2024, 6, 30) };

            Assert.True(student1.Equals(student2));
        }

        [Fact]
        public void Two_instances_of_ImmutableStudent_are_not_equal_if_they_do_not_contain_the_same_values()
        {
            ImmutableStudent student1 = new ImmutableStudent { Id = 5678, GivenName = "Søren", SurName = "Jespersen", StartDate = new DateTime(2021, 9, 1), EndDate = new DateTime(2024, 6, 30) };
            ImmutableStudent student2 = new ImmutableStudent { Id = 5678, GivenName = "Jesper", SurName = "Sørensen", StartDate = new DateTime(2021, 9, 1), EndDate = new DateTime(2024, 6, 30) };

            Assert.False(student1.Equals(student2));
        }

        [Fact]
        public void ToString_returns_the_same_string_for_two_equal_instances_of_ImmutableStudents()
        {
            ImmutableStudent student1 = new ImmutableStudent { Id = 1234, GivenName = "Helle", SurName = "Helle", StartDate = new DateTime(2021, 9, 1), EndDate = new DateTime(2024, 6, 30) };
            ImmutableStudent student2 = new ImmutableStudent { Id = 1234, GivenName = "Helle", SurName = "Helle", StartDate = new DateTime(2021, 9, 1), EndDate = new DateTime(2024, 6, 30) };

            Assert.Equal(student1.ToString(), student2.ToString());
        }
    }
}