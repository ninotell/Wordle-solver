using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Ahorcado;

namespace AhorcadoTests
{
    [TestClass]
    public class Sprint2Tests
    {
        [TestMethod]
        public void EstablecerMaxIntentos3()
        {
            JuegoWordle juego = new JuegoWordle("Juan", 3);

            Assert.AreEqual(juego.maxIntentos, 3);
        }

        [TestMethod]
        public void PierdePartidaSiLlegaAMaxIntentos5()
        {
            JuegoWordle juego = new JuegoWordle("Juan", 5);

            juego.IntentarPalabra("gatos");
            juego.IntentarPalabra("monos");
            juego.IntentarPalabra("novia");
            juego.IntentarPalabra("casas");
            juego.IntentarPalabra("autos");

            Assert.AreEqual(juego.ganado, false);
            Assert.AreEqual(juego.juegoTerminado, true);
        }

    }
}
