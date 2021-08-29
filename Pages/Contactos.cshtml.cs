using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Practica_3__Desarrollo_web_ASP.NET_Core_.Pages
{
    public class ContactosModel : PageModel
    {

        public string Telefono { get; set; } = "809-705-0600";

        public string Email { get; set; } = "ronny_ivan@hotmail.com";

        public string WebSite { get; set; }

        public void OnGet(string site)
        {
            this.WebSite = site;
        }
    }
}
