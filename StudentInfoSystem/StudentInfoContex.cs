using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace StudentInfoSystem
{
    internal class StudentInfoContex : DbContext
    {
        
        public DbSet<Student> Students { get; set; }
      
        public StudentInfoContex() : base(Properties.Settings.Default.DbConnect)
        {

        }
    }
}
