﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;
using Library.Klassen;

namespace UnitTestProject
{
    [TestClass]
    public class TestArtikel
    {
        [TestMethod]
        public void TestToon()
        {
            Artikel artikel = new Artikel { Id = "ID01", Naam = "Ik ben Pelgrim", Auteur = "Terry Hayes" };
            string toon = artikel.Toon(4);
            string resultaat = "----ID01: \"Ik ben Pelgrim\", Terry Hayes";
            Assert.AreEqual(resultaat, toon);
        }

        [TestMethod]
        public void TestZoekId()
        {
            Artikel artikel = new Artikel();
            artikel.Id = "ID01";
            Assert.AreEqual(artikel, artikel.Zoek("ID01"));
        }
    }
}
