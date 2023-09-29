using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WinFormsDemoLibrary;

namespace MiniProject_RazorPages.Pages
{
    public class PersonEntryModel : PageModel
    {
        [BindProperty]
        public PersonModel Person { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                return RedirectToPage("./Index");
            }
        }
    }
}
