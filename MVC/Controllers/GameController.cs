using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wordle;

namespace MVC.Controllers
{
    public class GameController : HomeController
    {
        public ActionResult Game()
        {
            return View(new WordleGame());
        }

        [HttpPost]
        public JsonResult IntentarPalabra(WordleGame model, string palabra)
        {
            model.PalabraIntentada = palabra;
            System.Diagnostics.Debug.WriteLine("Palabra: " + model.PalabraIntentada);
            model.Win = Juego.IntentarPalabra(model.PalabraIntentada);
            // model.PalabrasIntentadas = Juego.palabrasIntentadas;
            model.ResultadosIntentos = Juego.resultadoIntentos;
            model.ErroresCometidos = Juego.intentos;
            model.PalabrasIntentadas = Juego.palabrasIntentadas;
            model.Win = Juego.partidaGanada;
            model.PalabraIntentada = string.Empty;
            return Json(model);
        }
    }
}
