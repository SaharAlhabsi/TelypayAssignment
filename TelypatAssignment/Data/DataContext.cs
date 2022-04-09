using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelypayAssignment.Models;
namespace TelypayAssignment.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
         {
        }

        public DbSet<Students> Students { get; set; }
        public DbSet<Countries> Countries { get; set; }
        public DbSet<Classes> Classes { get; set; }
        public int ClassID { get; set; }
        public int CourntryID { get; set; }

        
    }
}
