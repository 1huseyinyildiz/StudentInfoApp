using System;
using System.IO;
using Xunit;
using StudentInfoApp.Core.Models;
using StudentInfoApp.Core.Services;
using StudentInfoApp.Data.Repositories;
using System.Collections.Generic;
using StudentInfoApp.Core.Services.StudentInfoApp.Core.Services;

public class StudentServiceTests
{
    [Fact]
    public void PrintStudentInfo_ValidStudent_PrintsCorrectInfo()
    {
        var fileContent = "Ahmet 245 60 80\nMehmet 256 90 95\nHalit 556 87 76";
        var filePath = "test_students.txt";

        File.WriteAllText(filePath, fileContent);
        IStudentRepository studentRepository = new StudentRepository(filePath);
        IStudentService studentService = new StudentService();

        var students = studentRepository.GetAllStudents();

        using (var sw = new StringWriter())
        {
            Console.SetOut(sw);

            foreach (var student in students)
            {
                studentService.OgrenciYazdir(student);
            }

            var result = sw.ToString().Trim();

            var expectedOutput = "Student info: Ahmet with ID 245 has an average grade of 72" + Environment.NewLine +
                                 "Student info: Mehmet with ID 256 has an average grade of 93" + Environment.NewLine +
                                 "Student info: Halit with ID 556 has an average grade of 80.4";

            Assert.Equal(expectedOutput, result);
        }

        File.Delete(filePath);
    }
}
