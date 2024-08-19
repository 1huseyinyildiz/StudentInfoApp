using System;
using System.IO;
using Xunit;
using StudentInfoApp.Core.Models;
using StudentInfoApp.Data.Repositories;
using System.Collections.Generic;

namespace StudentInfoApp.Tests
{
    public class StudentRepositoryTests
    {
        [Fact]
        public void GetAllStudents_ValidFile_ReturnsCorrectStudents()
        {
            
            var fileContent = "Ahmet 245 60 80\nMehmet 256 90 95\nHalit 556 87 76";
            var filePath = "test_students.txt";
            File.WriteAllText(filePath, fileContent);

            IStudentRepository studentRepository = new StudentRepository(filePath);

            var students = studentRepository.GetAllStudents();

            Assert.Collection(students,
                student => Assert.Equal("Ahmet", student.Name),
                student => Assert.Equal("Mehmet", student.Name),
                student => Assert.Equal("Halit", student.Name)
            );

            File.Delete(filePath);
        }
    }
}
