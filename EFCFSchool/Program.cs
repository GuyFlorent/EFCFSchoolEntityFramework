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

            var fosse = new School();
            fosse.Name = " doranco";
            
          
            context.Schools.Add(fosse);
            context.SaveChanges();
        }
    }
}
