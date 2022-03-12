#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ContactApplication.Data;
using ContactApplication.Model;
using NToastNotify;

namespace ContactApplication.Pages.Home
{
    public class SignUpModel : PageModel
    {
        private readonly ContactApplication.Data.SampledbContext _context;
        private readonly IToastNotification _toastNotification;

        public SignUpModel(ContactApplication.Data.SampledbContext context, IToastNotification toastNotification)
        {
            _context = context;
            _toastNotification = toastNotification;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public User User { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Users.Add(User);
            await _context.SaveChangesAsync();

            _toastNotification.AddErrorToastMessage("Sign Up is completed.");
            return RedirectToPage("./SignIn");
        }
    }
}
