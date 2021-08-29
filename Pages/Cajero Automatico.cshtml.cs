using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Practica_3__Desarrollo_web_ASP.NET_Core_.Pages
{
    public class Cajero_AutomaticoModel : PageModel
    {
        public int CantidadRetirar { get; set; } = 0;
        
        //public int d1000 { get; set; } 

        //public int d500 { get; set; } 

        //public int d100 { get; set; }



        public void OnGet(int Retiro)
        {
            this.CantidadRetirar = Retiro;
           

        }
    }
}
