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
            JuegoWordle juego = new JuegoWordle("JUAN", 3, 1);

            Assert.AreEqual(juego.maxIntentos, 3);
        }

        [TestMethod]
        public void ValidarPartidaPerdidaPoMaxIntentosIngresados()
        {
            JuegoWordle juego = new JuegoWordle("JUAN", 5, 1);

            juego.palabra = "PERRO";

            juego.IntentarPalabra("GATOS");
            juego.IntentarPalabra("MONOS");
            juego.IntentarPalabra("NOVIA");
            juego.IntentarPalabra("CASAS");
            juego.IntentarPalabra("AUTOS");

            Assert.AreEqual(juego.partidaGanada, false);
            //Assert.AreEqual(juego.juegoTerminado, true);
            //Assert.AreEqual(juego.intentos, 5);
        }

        [TestMethod]
        public void GuardaUsuarioNuevo()
        {
            JuegoWordle juego = new JuegoWordle("JUAN", 5, 1);

            Assert.AreEqual(juego.puntajes["JUAN"], 0);
        }

    }
}
