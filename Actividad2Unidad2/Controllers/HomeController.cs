using Microsoft.AspNetCore.Mvc;
using Actividad2Unidad2.Models;

namespace Actividad2Unidad2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(ConvertidorViewModels con, string moneda)
        {
            if (moneda == "Peso")
            {
                con.Resultado = con.Dinero * 18;
            }
            else if(moneda == "Dolar")
            {
                con.Resultado += con.Dinero / 18;
            }
            return View(con);
        }
    }
}
