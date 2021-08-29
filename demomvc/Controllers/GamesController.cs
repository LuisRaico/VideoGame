using Microsoft.AspNetCore.Mvc;
using demomvc.Models;

namespace demomvc.Controllers
{
    public class GamesController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
               
      [HttpPost]

         public IActionResult Calcular(Games objGame)
        {
            double descuento,totaldescuento;
            double Total;

            descuento=objGame.Descuento/100;


            totaldescuento=objGame.Precio*descuento;
            Total=objGame.Precio-totaldescuento;
        
         
             

               ViewData["Message"] = "El total es de:"+Total;

            
            return View("Index");
        }


                   

    }
}