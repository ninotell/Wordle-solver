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
        public int maxIntentos;
        public bool ganado = false;
        public bool juegoTerminado = false;

        public string[] palabras = new string[] { "arbol" };

        public JuegoWordle(string _nombre, int _maxIntentos)
        {
            nombre = _nombre;
            maxIntentos = _maxIntentos;

            SetPalabra();
        }

        private void SetPalabra()
        {
            Random random = new Random();
            int i = random.Next(0, palabras.Length);
            palabra = palabras[i];
        }

        public bool IntentarPalabra(string _palabra)
        {
            if(intentos < maxIntentos)
            {
                intentos++;
                if (palabra == _palabra)
                {
                    ganado = true;
                    juegoTerminado = true;
                    return true;
                }
                else
                {
                    return false;
                }
            } else
            {
                juegoTerminado = true;
            }

            return false;
            
        }

    }
}
