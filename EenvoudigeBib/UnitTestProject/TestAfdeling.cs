using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;
using Library.Klassen;

namespace UnitTestProject
{
    [TestClass]
    public class TestAfdeling
    {
        [TestMethod]
        public void TestToon()
        {
            Afdeling afdeling = new Afdeling { Id = "WET", Naam = "Wetenschappen" };
            // tijdschrift
            TijdSchrift tijdschrift = new TijdSchrift { Id = "ID01", Naam = "Scientific American", Datum = new DateTime(2014, 8, 1), Uitgeverij = "Scientific American" };
            Artikel artikel = new Artikel { Id = "ID02", Naam = "Planets we could call home", Auteur = "Dimitar Sasselov" };
            tijdschrift.VoegToe(artikel);
            artikel = new Artikel { Id = "ID03", Naam = "Robot Pills", Auteur = "Paolo Dario" };
            tijdschrift.VoegToe(artikel);
            afdeling.VoegToe(tijdschrift);
            // boek
            Boek boek = new Boek { Id = "ID04", Naam = "Ik ben Pelgrim", Auteur = "Terry Hayes", Uitgeverij = "Bruna", Jaartal = 2014 };
            afdeling.VoegToe(boek);
            // boek
            boek = new Boek { Id = "ID05", Naam = "Kou uit het oosten", Auteur = "Ken Follett", Uitgeverij = "Van Holkema", Jaartal = 2014 };
            afdeling.VoegToe(boek);
            // boek
            boek = new Boek { Id = "ID06", Naam = "De monogrammoorden", Auteur = "Ken Follett", Uitgeverij = "Van Holkema", Jaartal = 2014 };
            afdeling.VoegToe(boek);
            // boek
            boek = new Boek { Id = "ID07", Naam = "Kou uit het oosten", Auteur = "Ken Follett", Uitgeverij = "Van Holkema", Jaartal = 2014 };
            afdeling.VoegToe(boek);
            // afdeling
            Afdeling afdeling2 = new Afdeling { Id = "GESCH", Naam = "Geschiedenis" };
            // boek
            boek = new Boek { Id = "ID08", Naam = "Ik ben Pelgrim", Auteur = "Terry Hayes", Uitgeverij = "Bruna", Jaartal = 2014 };
            afdeling2.VoegToe(boek);
            // boek
            boek = new Boek { Id = "ID09", Naam = "Kou uit het oosten", Auteur = "Ken Follett", Uitgeverij = "Van Holkema", Jaartal = 2014 };
            afdeling2.VoegToe(boek);
            // boek
            boek = new Boek { Id = "ID10", Naam = "De monogrammoorden", Auteur = "Ken Follett", Uitgeverij = "Van Holkema", Jaartal = 2014 };
            afdeling2.VoegToe(boek);
            // boek
            boek = new Boek { Id = "ID11", Naam = "Kou uit het oosten", Auteur = "Ken Follett", Uitgeverij = "Van Holkema", Jaartal = 2014 };
            afdeling2.VoegToe(boek);
            afdeling.VoegToe(afdeling2);
            string toon = afdeling.Toon(0);
            string resultaat = "Wetenschappen: \n"
                + "--Geschiedenis: \n"
                + "----ID10: \"De monogrammoorden\", Ken Follett, Van Holkema, 2014 \n"
                + "----ID09: \"Kou uit het oosten\", Ken Follett, Van Holkema, 2014 \n"
                + "----ID11: \"Kou uit het oosten\", Ken Follett, Van Holkema, 2014 \n"
                + "----ID08: \"Ik ben Pelgrim\", Terry Hayes, Bruna, 2014 \n \n"
                + "--ID06: \"De monogrammoorden\", Ken Follett, Van Holkema, 2014 \n"
                + "--ID05: \"Kou uit het oosten\", Ken Follett, Van Holkema, 2014 \n"
                + "--ID07: \"Kou uit het oosten\", Ken Follett, Van Holkema, 2014 \n"
                + "--ID04: \"Ik ben Pelgrim\", Terry Hayes, Bruna, 2014 \n"
                + "--ID01: \"Scientific American\", 1/08/2014 0:00:00, Scientific American: \n"
                + "----ID02: \"Planets we could call home\", Dimitar Sasselov \n"
                + "----ID03: \"Robot Pills\", Paolo Dario \n \n";
            Assert.AreEqual(resultaat.Length, toon.Length);
            Assert.AreEqual(resultaat, toon);
        }
    }
}
