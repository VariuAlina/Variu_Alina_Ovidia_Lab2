using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Variu_Alina_Ovidia_Lab2.Models;

namespace Variu_Alina_Ovidia_Lab2.Data
{
    public class Variu_Alina_Ovidia_Lab2Context : DbContext
    {
        public Variu_Alina_Ovidia_Lab2Context (DbContextOptions<Variu_Alina_Ovidia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Variu_Alina_Ovidia_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Variu_Alina_Ovidia_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Variu_Alina_Ovidia_Lab2.Models.Author>? Author { get; set; }
    }
}
