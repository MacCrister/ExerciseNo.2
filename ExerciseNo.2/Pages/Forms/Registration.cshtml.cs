using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExerciseNo._2.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExerciseNo._2.Pages.Forms
{
    public class RegistrationModel : PageModel
    {
        [BindProperty]
        public PersonModel Person { get; set; }
        public void OnGet()
        {
        }

        public ActionResult OnPost()
        {
            if (!ModelState.IsValid) {
                return Page();
            }
            return Redirect("/Index");
        }
    }
}
