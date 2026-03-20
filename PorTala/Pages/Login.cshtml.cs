using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PorTala.Data;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace PorTala.Pages
{
    public class LoginModel : PageModel
    {
        private readonly PorTalaContext _context;

        public LoginModel(PorTalaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string ErrorMessage { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = _context.Users
                .FirstOrDefault(u => u.Email == Email && u.Password == Password);

            if (user == null)
            {
                ErrorMessage = "Invalid login credentials.";
                return Page();
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Name),
                new Claim(ClaimTypes.Role, user.Role)
            };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

            return RedirectToPage("/Dashboard");
        }
        public IActionResult OnGet()
        {
            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                return RedirectToPage("/Dashboard");
            }

            return Page();
        }
    }
}