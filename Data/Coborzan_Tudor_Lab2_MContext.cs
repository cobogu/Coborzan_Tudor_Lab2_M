using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Coborzan_Tudor_Lab2_M.Models;

namespace Coborzan_Tudor_Lab2_M.Data
{
    public class Coborzan_Tudor_Lab2_MContext : DbContext
    {
        public Coborzan_Tudor_Lab2_MContext (DbContextOptions<Coborzan_Tudor_Lab2_MContext> options)
            : base(options)
        {
        }

        public DbSet<Coborzan_Tudor_Lab2_M.Models.Book> Book { get; set; } = default!;
        public DbSet<Coborzan_Tudor_Lab2_M.Models.Customer> Customer { get; set; } = default!;

        public DbSet<Coborzan_Tudor_Lab2_M.Models.Genre> Genre { get; set; } = default!;
        public DbSet<Coborzan_Tudor_Lab2_M.Models.Authors> Authors { get; set; } = default!;
    

}
}
