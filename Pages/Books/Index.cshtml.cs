﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using laboratorul2.Data;
using laboratorul2.Models;

namespace laboratorul2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly laboratorul2.Data.laboratorul2Context _context;

        public IndexModel(laboratorul2.Data.laboratorul2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book.Include(b => b.Publisher).ToListAsync();
        }
    }
}
