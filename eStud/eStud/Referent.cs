using eStud.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eStud
{
    public class Referent : Korisnik
    {
        private string departman;
        private string studijski_program;
        
       

        public Referent(string username, string usertype, string ime, string prezime, string datumRodjenja,string grad,string adresa, string pol,string departman, string studijski_program) : base(username, usertype, ime, prezime, datumRodjenja, pol,grad,adresa)
        {
            this.departman = departman;
            this.studijski_program = studijski_program;
        }
        public Referent(Korisnik k):base(k.getUserName(),k.getUserType(),k.getIme(),k.getPrezime(),k.getDatumRodjenja(),k.getPol(),k.getGrad(),k.getAdresa())
        {

        }
        public string getDepartman()
        {
            return departman;

        }
        public string getStudijskiProgram()
        {
            return studijski_program;
        }
    }
}
