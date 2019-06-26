using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eStud.Model
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
   public class IzborniPredmeti
    {
        string sifra_predmeta;
        string naziv_predmeta;
        string departman;
        string studijski_program;
        string username_profesora;
        int semestar;
        int espb;
        public  IzborniPredmeti(string sifra_predmeta,string naziv_predmeta,string departman,string studijski_program,string username_profesora,int semestar,int espb)
        {
            this.sifra_predmeta = sifra_predmeta;
            this.naziv_predmeta = naziv_predmeta;
            this.departman = departman;
            this.username_profesora = username_profesora;
            this.semestar = semestar;
            this.espb = espb;
               
        }
        public string Sifra_predmeta { get; set; }
        public string Naziv_predmeta { get; set; }
        public string Depertman { get; set; }
        public string Studijski_program { get; set; }
        public string Username_profesora { get; set; }
        public int Semestar { set; get; }
        public int Espb { set; get; }
    }

}
