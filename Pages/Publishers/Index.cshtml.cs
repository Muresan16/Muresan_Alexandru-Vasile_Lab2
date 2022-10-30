﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Muresan_Alexandru_Vasile_Lab2.Data;
using Muresan_Alexandru_Vasile_Lab2.Models;

namespace Muresan_Alexandru_Vasile_Lab2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Muresan_Alexandru_Vasile_Lab2.Data.Muresan_Alexandru_Vasile_Lab2Context _context;

        public IndexModel(Muresan_Alexandru_Vasile_Lab2.Data.Muresan_Alexandru_Vasile_Lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            //Book = await _context.Book
           // .Include(b => b.Publisher)
            //.ToListAsync();
        }
    }
}
