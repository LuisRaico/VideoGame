using Microsoft.AspNetCore.Mvc;
using demomvc.Models;
using demomvc.Data;
using System.Linq;

namespace demomvc.Controllers
{
    public class GamesController:Controller
    {     
        private readonly ApplicationDbGame _context;
         public GamesController(ApplicationDbGame context)
        {
            _context = context;
        }





        public IActionResult Index()
        {
            return View(_context.DataGames.ToList());
        }

          public IActionResult Create()
        {

            return View();
        }






      [HttpPost]

         
         public IActionResult Create(Games objGame)
        {         
            double descuento,totaldescuento;
            double Total;

            descuento=objGame.Descuento/100;


            totaldescuento=objGame.Precio*descuento;
            Total=objGame.Precio-totaldescuento;
        
         
             

            
                
            _context.Add(objGame);
            _context.SaveChanges();


            ViewData["Message"] = "El TOTAL ES :"+Total;
            return View();
        }
         public IActionResult Editar(int id)
        {
            Games objGames = _context.DataGames.Find(id);
            if(objGames == null){
                return NotFound();
            }
            return View(objGames);
        }

        [HttpPost]
        public IActionResult Editar(int id,[Bind("Id,Name,Categoria,Precio,Descuento")] Games objGames)
        {
             _context.Update(objGames);
             _context.SaveChanges();
              ViewData["Message"] = "La lista de juegos ya esta actualizado";
             return View(objGames);
        }

                   

    }
}