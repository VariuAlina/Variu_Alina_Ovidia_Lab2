﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Variu_Alina_Ovidia_Lab2.Data;
using Variu_Alina_Ovidia_Lab2.Models;

namespace Variu_Alina_Ovidia_Lab2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Variu_Alina_Ovidia_Lab2.Data.Variu_Alina_Ovidia_Lab2Context _context;

        public IndexModel(Variu_Alina_Ovidia_Lab2.Data.Variu_Alina_Ovidia_Lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;
        public IList<Book> Book { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book
                    .Include(b => b.Publisher)
                    .Include(b => b.Author)
                    .ToListAsync();
            }
        }
    }
}