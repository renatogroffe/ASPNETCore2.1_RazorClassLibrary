using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibAmbiente.Sistema.Pages
{
    public class Index : PageModel
    {
        public void OnGet()
        {
            TempData["MachineName"] = Environment.MachineName;
            TempData["Sistema"] = Environment.OSVersion.VersionString;
        }
    }
}