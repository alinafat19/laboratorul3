using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using laboratorul2.Models;

namespace laboratorul2.Data
{
    public class laboratorul2Context : DbContext
    {
        public laboratorul2Context (DbContextOptions<laboratorul2Context> options)
            : base(options)
        {
        }

        public DbSet<laboratorul2.Models.Book> Book { get; set; } = default!;
        public DbSet<laboratorul2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
