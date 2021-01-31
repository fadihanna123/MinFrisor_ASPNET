using Microsoft.EntityFrameworkCore;
using Projekt.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Data
{
    public class HairdresserContext : DbContext
    {

        public HairdresserContext(DbContextOptions<HairdresserContext> options) : base(options)
        {

        }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Bookingssystem> Bookingssystem { get; set; }
    }

}