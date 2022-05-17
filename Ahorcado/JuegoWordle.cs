using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    public class JuegoWordle
    {
        public string nombre;
        public string palabra;
        public int intentos = 0;
        public bool ganado = false;

        public string[] palabras = new string[] { "arbol", "casas", "perro" };

        public JuegoWordle(string _nombre)
        {
            nombre = _nombre;

            SetPalabra();
        }

        private void SetPalabra()
        {
            Random random = new Random();
            int i = random.Next(0, 2);
            palabra = palabras[i];
        }

        public bool IntentarPalabra(string _palabra)
        {
            if(intentos < 3)
            {
                intentos++;
                if (palabra == _palabra)
                {
                    ganado = true;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
            
        }

    }
}
