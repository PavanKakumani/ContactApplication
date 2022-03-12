#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContactApplication.Data;
using ContactApplication.Model;

namespace ContactApplication.Pages.Contacts
{
    public class DetailsModel : PageModel
    {
        private readonly ContactApplication.Data.SampledbContext _context;

        public DetailsModel(ContactApplication.Data.SampledbContext context)
        {
            _context = context;
        }

        public Contact Contact { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        { 
            Contact = await _context.Contacts.FirstOrDefaultAsync(m => m.Id == id);

            if (Contact == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
