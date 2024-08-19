using StudentInfoApp.Core.Models;
using StudentInfoApp.Core.Services;
using StudentInfoApp.Core.Services.StudentInfoApp.Core.Services;
using StudentInfoApp.Data.Repositories;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "ogrenciler.txt";

        IStudentRepository studentRepository = new StudentRepository(filePath);
        IStudentService studentService = new StudentService();

        var students = studentRepository.GetAllStudents();
        foreach (var student in students)
        {
            studentService.OgrenciYazdir(student);
        }

        Console.ReadKey(); 
    }
}
