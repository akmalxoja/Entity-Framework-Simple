using ConsoleAppEF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEF.DbContexts
{
        public class AppDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server = localhost; Port = 5432; Database = myDataBaseEF; User Id = postgres; Password = root;");
        }

        DbSet<User> Users { get; set; }
    }
       
      
    
}
