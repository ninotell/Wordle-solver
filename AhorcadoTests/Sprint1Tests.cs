using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Wordle;

namespace AhorcadoTests
{
    [TestClass]
    public class Sprint1Tests
    {
        [TestMethod]
        public void GuardarNombreDeJuego()
        {
            JuegoWordle juego = new JuegoWordle("Juan", 3, 1);

            Assert.AreEqual(juego.nombre, "Juan");
        }

        //[TestMethod]
        //public void IniciaPartidaConPalabraDe5Letras()
        //{
        //    JuegoWordle juego = new JuegoWordle("Juan", 3);

        //    Assert.IsNotNull(juego.palabra);
        //    Assert.AreEqual(juego.palabra.Length, 5);
        //}

        [TestMethod]
        public void ValidarIntentoPalabraCorrecta()
        {
            JuegoWordle juego = new JuegoWordle("Juan", 3, 1);
            juego.palabra = "perro";

            Assert.AreEqual(juego.IntentarPalabra("perro"), true);
        }

        [TestMethod]
        public void ValidarIntentoPalabraErronea()
        {
            JuegoWordle juego = new JuegoWordle("Juan", 3, 1);
            juego.palabra = "perro";

            Assert.AreEqual(juego.IntentarPalabra("gatos"), false);
        }

        [TestMethod]
        public void CantidadDeIntentosIncorrectosTres()
        {
            JuegoWordle juego = new JuegoWordle("Juan", 3, 1);

            juego.palabra = "perro";

            juego.IntentarPalabra("gatos");
            juego.IntentarPalabra("monos");
            juego.IntentarPalabra("novia");

            Assert.AreEqual(juego.intentos, 3);
        }

        [TestMethod]
        public void ValidarPartidaGanada()
        {
            JuegoWordle juego = new JuegoWordle("Juan", 3, 1);
            juego.palabra = "perro";

            juego.IntentarPalabra("gatos");
            juego.IntentarPalabra("gatos");
            juego.IntentarPalabra("perro");

            Assert.AreEqual(juego.partidaGanada, true);
        }

        [TestMethod]
        public void ValidarPartidaPerdidaPorMaxIntentos3()
        {
            JuegoWordle juego = new JuegoWordle("Juan", 3, 1);
            juego.palabra = "perro";

            juego.IntentarPalabra("gatos");
            juego.IntentarPalabra("monos");
            juego.IntentarPalabra("novia");

            Assert.AreEqual(juego.partidaGanada, false);
            Assert.AreEqual(juego.intentos, 3);
        }
    }
}