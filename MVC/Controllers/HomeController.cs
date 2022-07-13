using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public static Wordle.JuegoWordle Juego { get; set; }

        public ActionResult Index()
        {
            WordleGame gameModel = new WordleGame
            {
                Palabra = "arbol"
            };
            return View(gameModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Game(WordleGame gameModel)
        {
            Juego = new Wordle.JuegoWordle(gameModel.Nombre, gameModel.ErroresPosibles, gameModel.Dificultad);

            gameModel.ErroresPosibles = Juego.maxIntentos;
            gameModel.Nombre = Juego.nombre;
            gameModel.Dificultad = Juego.dificultad;

            return View(gameModel);
        }

        [HttpPost]
        public JsonResult TryWord(WordleGame model)
        {
            Juego.IntentarPalabra(model.PalabraIntentada);
            model.Win = Juego.partidaGanada;
            model.ErroresCometidos = Juego.intentos;
            model.PalabrasIntentadas = Juego.palabrasIntentadas;

            return Json(model);
        }

    }
}
