using EFCFSchool.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCFSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            MyContext context = new MyContext();

            var fosse = new Teacher();
            fosse.Fisrtname = " etoo";
            fosse.Lastname = "fils";
            fosse.SchoolId = 1;
            
          
           // context.Teachers.Add(fosse);
          //  context.SaveChanges();


            var modif = context.Teachers.FirstOrDefault(f => f.Id == 3);
            modif.Lastname = "Wangueu";
            context.Teachers.Update(modif);

            context.SaveChanges();
        }
    }
}
