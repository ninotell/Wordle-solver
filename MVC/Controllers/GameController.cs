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
            model.PalabrasIntentadas = Juego.palabrasIntentadas;
            model.ResultadosIntentos = Juego.resultadoIntentos;
            //foreach (var item in model.PalabrasIntentadas)
            //{
            //    System.Diagnostics.Debug.WriteLine(item);
            //}
            System.Diagnostics.Debug.WriteLine(model.Win);
            model.PalabraIntentada = "";
            return Json(model);
        }
    }
}
