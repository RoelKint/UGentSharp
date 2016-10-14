using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;
using Library.Klassen;

namespace UnitTestProject
{
    [TestClass]
    public class TestTijdschrift
    {
        [TestMethod]
        public void TestToon()
        {
            TijdSchrift tijdschrift = new TijdSchrift { Id = "ID01", Naam = "Scientific American", Datum = new DateTime(2014, 8, 1), Uitgeverij = "Scientific American" };
            Artikel artikel = new Artikel { Id = "ID02", Naam = "Planets we could call home", Auteur = "Dimitar Sasselov" };
            tijdschrift.VoegToe(artikel);
            artikel = new Artikel { Id = "ID03", Naam = "Robot Pills", Auteur = "Paolo Dario" };
            tijdschrift.VoegToe(artikel);
            string toon = tijdschrift.Toon(0);
            string resultaat = "ID01: \"Scientific American\", 1/08/2014 0:00:00, Scientific American: \n"
                + "--ID02: \"Planets we could call home\", Dimitar Sasselov \n"
                + "--ID03: \"Robot Pills\", Paolo Dario \n";
            Assert.AreEqual(resultaat, toon);
        }
    }
}
