using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroceryApp.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace GroceryApp.Data
{
    public class GroceryAppContext : DbContext
    {

        public GroceryAppContext(DbContextOptions<GroceryAppContext> opt) : base(opt) { }
        public DbSet<Stores> Stores { get; set; }
    }
}
