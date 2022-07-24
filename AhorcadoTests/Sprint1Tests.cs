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
            JuegoWordle juego = new JuegoWordle("JUAN", 3, 1);

            Assert.AreEqual(juego.nombre, "JUAN");
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
            JuegoWordle juego = new JuegoWordle("JUAN", 3, 1);
            juego.palabra = "AUTO";

            Assert.AreEqual(juego.IntentarPalabra("AUTO"), true);
        }

        [TestMethod]
        public void ValidarIntentoPalabraErronea()
        {
            JuegoWordle juego = new JuegoWordle("JUAN", 3, 1);
            juego.palabra = "PERRO";

            Assert.AreEqual(juego.IntentarPalabra("GATOS"), false);
        }

        [TestMethod]
        public void CantidadDeIntentosIncorrectosTres()
        {
            JuegoWordle juego = new JuegoWordle("JUAN", 3, 1);

            juego.palabra = "PERRO";

            juego.IntentarPalabra("GATOS");
            juego.IntentarPalabra("MONOS");
            juego.IntentarPalabra("NOVIA");

            Assert.AreEqual(juego.intentos, 3);
        }

        [TestMethod]
        public void ValidarPartidaGanada()
        {
            JuegoWordle juego = new JuegoWordle("JUAN", 3, 1);
            juego.palabra = "PERRO";

            juego.IntentarPalabra("GATOS");
            juego.IntentarPalabra("GATOS");
            juego.IntentarPalabra("PERRO");

            Assert.AreEqual(juego.partidaGanada, true);
        }

        [TestMethod]
        public void ValidarPartidaPerdidaPorMaxIntentos3()
        {
            JuegoWordle juego = new JuegoWordle("JUAN", 3, 1);
            juego.palabra = "PERRO";

            juego.IntentarPalabra("GATOS");
            juego.IntentarPalabra("MONOS");
            juego.IntentarPalabra("NOVIA");

            Assert.AreEqual(juego.partidaGanada, false);
            Assert.AreEqual(juego.intentos, 3);
        }
    }
}