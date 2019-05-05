using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name=Web")
        {

        }
        public DbSet<GopY> GopYs { get; set; }
        public DbSet<Tour> Tours { get; set; }
    }
}