using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eStud
{
    using eStud.Model;
    using System.ComponentModel;
    public class Predmeti
    {
        private string Sifra_predmeta;
        private string Naziv_predmeta;
        private string Departman;
        private string Studijski_program;
        private string Username_profesora;
        private int Semestar;
        private int ESPB;

        public Predmeti(string sifra_predmeta, string naziv_predmeta, string departman, string studijski_program, string username_profesora, int semestar, int eSPB)
        {
            Sifra_predmeta = sifra_predmeta;
            Naziv_predmeta = naziv_predmeta;
            Departman = departman;
            Studijski_program = studijski_program;
            Username_profesora = username_profesora;
            Semestar = semestar;
            ESPB = eSPB;
        }

        public Predmeti()
        {
        }

        //set i get metode
        public void setSifraPRedmeta(string Sifra_predmeta)
        {
            this.Sifra_predmeta = Sifra_predmeta;

        }
        public void setNazivPredmeta(string Naziv_predmeta)
        {
            this.Naziv_predmeta = Naziv_predmeta;

        }
        public void setDepartman(string Departman)
        {
            this.Departman = Departman;
        }
        public void setStudijskiProgram(string Studijski_program)
        {
            this.Studijski_program = Studijski_program;
        }
        public void setUsernameProfesora(string Username_profesora)
        {
            this.Username_profesora = Username_profesora;
        }
        public void setSemestar(int semestar)
        {
            this.Semestar = semestar;
        }
        public void setEspb(int ESPB)
        {
            this.ESPB = ESPB;
        }
        public string getSifraPredmeta()
        {
            return this.Sifra_predmeta;
        }
        public string getNazivPredmeta()
        {
            return Naziv_predmeta;
        }
        public string getDepartman()
        {
            return Departman;
        }
        public string getStudijskiProgram()
        {
            return Studijski_program;
        }
        public int getSemestar()
        {
            return Semestar;
        }
        public int getEspb()
        {
            return ESPB;
        }
        
    }
}
