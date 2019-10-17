using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCFSchool.Model
{
    class Teacher
    {
        public int Id { get; set; }
        public string Fisrtname { get; set; }
        public string Lastname { get; set; }

        public School school { get; set; }// clé etrangere
        public int SchoolId { get; set; }// clé etrangere

        public List<Student> ListStudent { get; set; } // Teacher sera en clés secondaire chez Student
    }
}
