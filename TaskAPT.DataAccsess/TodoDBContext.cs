using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taskAPI.Models;

namespace TaskAPT.DataAccsess
{
    public class TodoDBContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var connectionString = 
            optionsBuilder.UseSqlServer(connectionString);
        }

    }

}
