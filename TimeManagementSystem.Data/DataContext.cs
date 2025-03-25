using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeManaementSystem.Core.Entities;

namespace TimeManagementSystem.Data
{
    public class DataContext:DbContext
    {
        public DbSet<User>Users { get; set; }
        public DbSet<WorkHours> WorkHours { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=my_db");
        }
    }
}
