using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Practica_3__Desarrollo_web_ASP.NET_Core_.Pages
{
    public class Calculo_de_PrestamoModel : PageModel
    {

        public double Capital { get; set; } = 50000;
        public double NumeroCuotas { get; set; } = 5;

        public double TasaPrestamo { get; set; } = 0.03;


        public void OnGet(double Inicial, double Numero, double Tasa )
        {
            this.Capital = Inicial;
            this.NumeroCuotas = Numero;
            this.TasaPrestamo = Tasa;

        }

        

        

    }
}
