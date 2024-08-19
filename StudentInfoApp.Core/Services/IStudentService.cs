using StudentInfoApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoApp.Core.Services
{
    public interface IStudentService
    {
        double NotHesapla(Student student);
        void OgrenciYazdir(Student student);
    }
}
