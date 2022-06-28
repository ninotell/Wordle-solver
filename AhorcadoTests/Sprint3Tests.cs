using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Wordle;

namespace AhorcadoTests
{
    [TestClass]
    public class Sprint3Tests
    {
        [TestMethod]
        public void EstablecerDificultad()
        {
            JuegoWordle juego = new JuegoWordle("Juan", 3, 1);

            Assert.AreEqual(juego.dificultad, 1);
        }

        [TestMethod]
        public void GenerarVoucherCorrectamente()
        {
            JuegoWordle juego = new JuegoWordle("Juan", 5, 1);

            juego.palabra = "perro";

            juego.IntentarPalabra("perro");

            Assert.AreEqual(juego.partidaGanada, true);
            Assert.IsTrue(juego.voucher > 0);
        }
        /*
        [TestMethod]
        public void ContarTiempoCorrectamente()
        {
            JuegoWordle juego = new JuegoWordle("Juan", 5,1);

            juego.palabra = "perro";

            juego.IntentarPalabra("gatos");
            juego.IntentarPalabra("monos");
            juego.IntentarPalabra("novia");
            juego.IntentarPalabra("casas");
            juego.IntentarPalabra("perro");
            Assert.AreEqual(juego.elapsedTime, "0");

            Assert.IsNotNull(juego.elapsedTime);
        }
        */

        [TestMethod]
        public void ValidarPuntajePartidaGanada()
        {
            JuegoWordle juego = new JuegoWordle("Juan", 5, 1);

            juego.palabra = "perro";

            juego.IntentarPalabra("perro");
            juego.puntajes.TryGetValue("Juan", out int puntaje);
            Assert.AreEqual(puntaje, 1);
        }

        [TestMethod]
        public void ValidarLongitudDePalabraFacilLong4()
        {
            JuegoWordle juego = new JuegoWordle("Juan", 5, 1);

            Assert.AreEqual(juego.palabra.Length, 4);
        }

        [TestMethod]
        public void ValidarLongitudDePalabraMediaLong6()
        {
            JuegoWordle juego = new JuegoWordle("Juan", 5, 2);

            Assert.AreEqual(juego.palabra.Length, 6);
        }

        [TestMethod]
        public void ValidarLongitudDePalabraDificilLong8()
        {
            JuegoWordle juego = new JuegoWordle("Juan", 5, 3);

            Assert.AreEqual(juego.palabra.Length, 8);
        }

    }
}