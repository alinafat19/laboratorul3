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
        public DbSet<laboratorul2.Models.BookCategory> BookCategory { get; set; } = default!;
        public DbSet<laboratorul2.Models.Category> Category { get; set; } = default!;
        public DbSet<laboratorul2.Models.Author> Authors { get; set; } = default!; // modificare
        public IEnumerable<object> Author { get; internal set; } // modificare
        public DbSet<laboratorul2.Models.Member> Member { get; set; } = default!;
        public DbSet<laboratorul2.Models.Borrowing> Borrowing { get; set; } = default!;
    }
}
