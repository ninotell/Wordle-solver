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

        //[HttpPost]
        //public JsonResult InsertWordToGuess(WordleGame model)
        //{
        //    Juego = new JuegoWordle(model.Palabra, model.ErroresPosibles, model.Dificultad);
        //    model.ChancesLeft = Juego.ChancesRestantes;
        //    return Json(model);
        //}

        [HttpPost]
        public JsonResult TryLetter(WordleGame model)
        {
            model.Win = Juego.IntentarPalabra(model.PalabraIntentada);
            //model.Win = Juego.ValidarPalabra();
            //model.ChancesLeft = Juego.ChancesRestantes;
            //model.WrongLetters = string.Empty;
            //foreach (var wLetter in Juego.LetrasErradas)
            //{
            //    model.WrongLetters += wLetter + ",";
            //}
            //model.GuessingWord = string.Empty;
            //foreach (var rLetter in Juego.PalabraIngresada)
            //{
            //    model.GuessingWord += rLetter + " ";
            //}
            //model.LetterTyped = string.Empty;
            return Json(model);
        }

    }
}
