using StudentInfoApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentInfoApp.Core.Services
{
    namespace StudentInfoApp.Core.Services
    {
        public class StudentService : IStudentService
        {
            public double NotHesapla(Student student)
            {
                return student.Vize * 0.4 + student.Final * 0.6;
            }

            public void OgrenciYazdir(Student student)
            {
                Console.WriteLine($"Ogrenci bilgileri:{student.Name} adinda {student.Number} numarasinda not ortalamasi da {NotHesapla(student)} dir");
            }
        }
    }


}
