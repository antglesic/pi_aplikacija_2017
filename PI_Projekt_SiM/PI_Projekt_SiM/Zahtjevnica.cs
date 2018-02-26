using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Projekt_SiM
{

    public class Zahtjevnica
    {
        public DataSetZahtjevnice.zahtjevnicaDataTable zahtjevnicaDataTable;
        public DataSetZahtjevnicaSirovina.zahtjevnica_sirovinaDataTable zahtjevnica_sirovina;

        public int IdZahtjevnice = 0;
        public int v;

        string NaslovZahtjevnice { get; set; }
        string SvrhaZahtjevnice { get; set; }
        string DatumZahtjevnice { get; set; }
        int IdKorisnika { get; set; }
        int TipZahtjevnice { get; set; }

        public Zahtjevnica()
        {

        }

        public Zahtjevnica(int id, string naslov, string svrha, string datum, int korisnik, int tip)
        {
            this.IdZahtjevnice = id;
            this.NaslovZahtjevnice = naslov;
            this.SvrhaZahtjevnice = svrha;
            this.DatumZahtjevnice = datum;
            this.IdKorisnika = korisnik;
            this.TipZahtjevnice = tip;
        }

        public Zahtjevnica(DataSetZahtjevnice.zahtjevnicaDataTable zahtjevnicaDataTable)
        {
            this.zahtjevnicaDataTable = zahtjevnicaDataTable;
        }

        public Zahtjevnica(DataSetZahtjevnicaSirovina.zahtjevnica_sirovinaDataTable zahtjevnica_sirovinaDataTable, int id1, int id2)
        {
            this.zahtjevnica_sirovina = zahtjevnica_sirovinaDataTable;
            this.IdZahtjevnice = id1;
            this.v = id2;
        }

        public Zahtjevnica(int v)
        {
            this.v = v;
        }
    }
}
