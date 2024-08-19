using System.Collections.Generic;
using System.IO;
using StudentInfoApp.Core.Models;

namespace StudentInfoApp.Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly string _filePath;

        public StudentRepository(string filePath)
        {
            _filePath = filePath;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            var students = new List<Student>();

            try
            {
                foreach (var line in File.ReadLines(_filePath))
                {
                    var data = line.Split(' ');
                    if (data.Length == 4 &&
                        int.TryParse(data[1], out int number) &&
                        int.TryParse(data[2], out int vize) &&
                        int.TryParse(data[3], out int final))
                    {
                        students.Add(new Student(data[0], number, vize, final));
                    }
                    else
                    {
                        Console.WriteLine("Dosyada geçersiz veri formatı bulundu.");
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Hata: {_filePath} dosyası bulunamadı.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Öğrenci verilerini okurken bir hata oluştu: {ex.Message}");
            }

            return students;
        }

    }
}
