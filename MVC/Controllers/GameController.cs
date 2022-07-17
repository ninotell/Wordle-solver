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
        public JsonResult IntentarPalabra(WordleGame model)
        {
            //System.Diagnostics.Debug.WriteLine(model.PalabraIntentada);
            model.Win = Juego.IntentarPalabra(model.PalabraIntentada);
            // model.PalabrasIntentadas = Juego.palabrasIntentadas;
            model.ResultadosIntentos = Juego.resultadoIntentos;
            model.ErroresCometidos = Juego.intentos;
            model.PalabrasIntentadas += Juego.palabrasIntentadas.Last() + ",";
            model.PalabraIntentada = string.Empty;
            return Json(model);
        }
    }
}
