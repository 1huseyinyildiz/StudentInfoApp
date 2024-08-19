using StudentInfoApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoApp.Data.Repositories
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents();
    }

}
