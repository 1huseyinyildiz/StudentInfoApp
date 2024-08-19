using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoApp.Core.Models
{
    public class Student
    {
        public string Name { get; private set; }
        public int Number { get; private set; }
        public int Vize { get; private set; }
        public int Final { get; private set; }

        public Student(string name, int number, int vize, int final)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("İsim boş veya null olamaz.", nameof(name));

            if (number <= 0)
                throw new ArgumentOutOfRangeException(nameof(number), "Numara pozitif bir sayı olmalıdır.");

            if (vize < 0 || vize > 100 || final < 0 || final > 100)
                throw new ArgumentOutOfRangeException("Notlar 0 ile 100 arasında olmalıdır.");

            Name = name;
            Number = number;
            Vize = vize;
            Final = final;
        }
    }
}

