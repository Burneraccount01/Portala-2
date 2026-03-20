using Microsoft.AspNetCore.Mvc.RazorPages;
using PorTala.Data;
using PorTala.Models;

namespace PorTala.Pages
{
    public class LinksModel : PageModel
    {
        private readonly PorTalaContext _context;

        public LinksModel(PorTalaContext context)
        {
            _context = context;
        }

        public List<Link> Links { get; set; }

        public void OnGet()
        {
            Links = _context.Links.ToList();
        }
    }
}