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
        public int maxIntentos = 5;
        public bool ganado = false;
        public bool juegoTerminado = false;
        public Dictionary<string, int> puntajes = new Dictionary<string, int>(){};

        public string[] palabras = new string[] { "arbol" };

        public JuegoWordle(string _nombre, int _maxIntentos)
        {
            nombre = _nombre;
            maxIntentos = _maxIntentos;
            if (puntajes.TryGetValue(nombre, out int puntaje))
            {
                
            }
            else
            {
                puntajes.Add(nombre, 0);
            }

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
            intentos++;
            if (intentos < maxIntentos)
            {
                if (palabra == _palabra)
                {
                    ganado = true;
                    puntajes[nombre] += 1;
                    juegoTerminado = true;
                    return true;
                }
                else
                {
                    return false;
                }
            } else if (intentos == maxIntentos)
            {
                juegoTerminado = true;
                puntajes[nombre] -= 1;
            }
            return false;
            
        }

    }
}
