using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCFSchool.Model
{
    class School
    {
        public int Id { get; set; }
        public  string Name { get; set; }

        public List<Teacher> ListTeacher { get; set; }//school sera en clés secondaire chez Teacher
        public List<Room> ListRoom { get; set; } //school sera en clés secondaire chez Room
    }
}
