using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaSport
{
    internal class sport
    {
        string naziv, igraLiSeLoptom;
        int brojIgraca;

        public void setNaziv(string naziv) 
        {
            this.naziv = naziv;
        }
        public string getNaziv()
        {
            return this.naziv;
        }
        public void setIgraLiSeLoptom(string igraLiSeLoptom)
        {
            this.igraLiSeLoptom = igraLiSeLoptom;
        }
        public string getIgraLiSeLoptom()
        {
            return this.igraLiSeLoptom;
        }
        public void setBrojIgraca(int brojIgraca)
        {
            this.brojIgraca = brojIgraca;
        }
        public int getBrojIgraca()
        {
            return this.brojIgraca;
        }

        public override string ToString()
        {
            string ispis = "Naziv --> " + this.getNaziv() + "\n" + "Igra li se loptom --> " + this.getIgraLiSeLoptom()
            + "\n" + "Broj igraca --> " + this.getBrojIgraca() + "\n";
            return ispis;
        }
        public sport(string naziv, string igraLiSeLoptom, int brojIgraca) {
            this.naziv = naziv; this.igraLiSeLoptom = igraLiSeLoptom; this.brojIgraca = brojIgraca;
        }
    }
}
