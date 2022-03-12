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
    public class IndexModel : PageModel
    {
        private readonly ContactApplication.Data.SampledbContext _context;

        public IndexModel(ContactApplication.Data.SampledbContext context)
        {
            _context = context;
        }

        public IList<Contact> Contact { get;set; }

        public async Task OnGetAsync()
        {
            Contact = await _context.Contacts.ToListAsync();
        }
    }
}
