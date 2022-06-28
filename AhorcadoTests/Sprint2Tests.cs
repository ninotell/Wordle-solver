using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Wordle;

namespace AhorcadoTests
{
    [TestClass]
    public class Sprint2Tests
    {
        [TestMethod]
        public void EstablecerMaxIntentos()
        {
            JuegoWordle juego = new JuegoWordle("Juan", 3, 1);

            Assert.AreEqual(juego.maxIntentos, 3);
        }

        [TestMethod]
        public void ValidarPartidaPerdidaPoMaxIntentosIngresados()
        {
            JuegoWordle juego = new JuegoWordle("Juan", 5, 1);

            juego.palabra = "perro";

            juego.IntentarPalabra("gatos");
            juego.IntentarPalabra("monos");
            juego.IntentarPalabra("novia");
            juego.IntentarPalabra("casas");
            juego.IntentarPalabra("autos");

            Assert.AreEqual(juego.partidaGanada, false);
            //Assert.AreEqual(juego.juegoTerminado, true);
            //Assert.AreEqual(juego.intentos, 5);
        }

        [TestMethod]
        public void GuardaUsuarioNuevo()
        {
            JuegoWordle juego = new JuegoWordle("Juan", 5, 1);

            Assert.AreEqual(juego.puntajes["Juan"], 0);
        }

    }
}
