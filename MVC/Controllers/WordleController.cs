using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class WordleController : Controller
    {

        public static Wordle.JuegoWordle Juego { get; set; }

        // GET: Wordle
        public ActionResult Index()
        {
            return View(new WordleGame());
        }

        [HttpPost]
        public JsonResult InsertDificulty(WordleGame model)
        {
            Juego = new Wordle.JuegoWordle(model.Nombre,model.ErroresPosibles ,model.Dificultad);

            model.ErroresPosibles = Juego.maxIntentos;
            model.Nombre = Juego.nombre;
            model.Dificultad = Juego.dificultad;
            return Json(model);
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

        // GET: WordleController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WordleController/Create
        public ActionResult Create()
        {
            return View();
        }

        //// POST: WordleController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create()
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: WordleController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WordleController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: WordleController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WordleController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
