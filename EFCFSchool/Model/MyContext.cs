using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCFSchool.Model
{
    class MyContext : DbContext
    {
        // je declare dans le context les table avec le DS
        public DbSet<School> Schools { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }

        //surcharger automatiquemen avec  alt + entrée et choisir onCongi...
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //connection
            optionsBuilder.UseSqlServer("Server=localhost\\sqlexpress01;Initial Catalog=school;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
