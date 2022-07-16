using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wordle;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
       

        public static Wordle.JuegoWordle Juego { get; set; }

        // GET: Wordle
        public ActionResult Index()
        {
            return View(new WordleGame());
        }

        //[HttpPost]
        //public ActionResult Game(WordleGame gameModel)
        //{
        //    Juego = new Wordle.JuegoWordle(gameModel.Nombre, gameModel.ErroresPosibles, gameModel.Dificultad);

        //    return View(gameModel);
        //}

        [HttpPost]
        public ActionResult Game(string nombre , int errors, int difficulty)
        {
            JuegoWordle juegowordle = new JuegoWordle(nombre,errors,difficulty);

            WordleGame juego = new WordleGame();
            juego.Nombre = juegowordle.nombre ;
            juego.ErroresPosibles = juegowordle.maxIntentos;
            juego.Dificultad = juegowordle.dificultad;
            juego.Palabra = juegowordle.palabra;
            return this.View(juego);
        }

        [Route("Game")]
        public ActionResult Game(WordleGame gameModel)
        {
            //gameModel.Dificultad = 2;
            //gameModel.ErroresPosibles = 5;
            return this.View(gameModel);
        }
        
    }
}
