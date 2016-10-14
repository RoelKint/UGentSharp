using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Klassen
{
    public class TijdSchrift : Verdeling
    {
        // unieke identificatie
        public string Id { get; set; }

        public DateTime Datum { get; set; }

        public string Uitgeverij { get; set; }

        public string Naam { get; set; }
        // ouder waartoe het item (bv. artikel, afdeling, ...) behoort of null
        public IBibItem Ouder { get; set; }
        // item toevoegen aan dit item 
        public void VoegToe(IBibItem bibItem)
        {

        }
        // item verwijderen uit dit item 
        public void Verwijder(IBibItem bibItem)
        {

        }
        // een item zoeken op basis van id
        public IBibItem Zoek(string id)
        {
            return null;
        }
        // een item zoeken op basis van een trefwoord
        public ISet<IBibItem> ZoekTrefwoord(string trefwoord)
        {
            return null;

        }
        // dit item verplaatsen naar een ander item
        public void VerplaatsNaar(IBibItem bibItem)
        {

        }
        // item weergeven als string met een aantal karakters als indentatie
        public string Toon(int insprong)
        {
            return "";
        }
    }
}
