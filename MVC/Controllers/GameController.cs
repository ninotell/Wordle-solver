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
            Juego.IntentarPalabra(model.PalabraIntentada);
            model.PalabrasIntentadas = Juego.palabrasIntentadas;
            model.ResultadosIntentos = Juego.resultadoIntentos;
            foreach (var res in model.ResultadosIntentos)
            {
                System.Diagnostics.Debug.WriteLine(res);

            }
            foreach (var res in model.PalabrasIntentadas)
            {
                System.Diagnostics.Debug.WriteLine(res);

            }

            return Json(model);
        }
    }
}
