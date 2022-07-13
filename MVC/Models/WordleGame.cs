using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class WordleGame
    {

        [DisplayName("Errores Posibles")]
        public int ErroresPosibles { get; set; }

        [DisplayName("Nombre")]
        public string Nombre { get; set; }

        [DisplayName("Dificultad")]
        public int Dificultad { get; set; }

        [DisplayName("Palabra Intentada")]
        public string PalabraIntentada { get; set; }

        public bool Win { get; set; }

        [DisplayName("Errores Cometidos")]
        public int ErroresCometidos { get; set; }

        [DisplayName("Palabra Intentada")]
        public List<string> PalabrasIntentadas { get; set; }

    }
}
