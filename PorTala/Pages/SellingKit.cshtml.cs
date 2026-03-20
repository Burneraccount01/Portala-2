using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PorTala.Pages
{
    public class SellingKitModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string Type { get; set; }

        public void OnGet()
        {

        }
    }
}