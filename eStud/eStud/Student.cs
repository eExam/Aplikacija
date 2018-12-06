
namespace eStud.Model
{
    using System.ComponentModel;
    public class Student : Korisnik
    {
        private string departman;
        private string studijski_program;
        private int semestar;
        private string broj_indeksa;

        public Student(string username, string usertype, string ime, string prezime, string datumRodjenja, string pol,string departman, string studijski_program,int semestar, string broj_indeksa) : base(username, usertype, ime, prezime, datumRodjenja, pol)
        {

            this.departman = departman;
            this.studijski_program = studijski_program;
            this.broj_indeksa = broj_indeksa;
            this.semestar = semestar;
        }

        
        public string getDepartman()
        {
            return departman;

        }
        public string getStudijskiProgram()
        {
            return studijski_program;
        }
        public string getBrojIndeksa()
        {
            return broj_indeksa;
        }
        public int getSemestar()
        {
            return semestar;
        }
        public void setDepartman(string departman)
        {
            this.departman = departman;
          
        }
        public void setStudijskiProgram(string studijski_program)
        {
            this.studijski_program = studijski_program;
        }
        public void setBrojIndeksa(string broj_indeksa)
        {
            this.broj_indeksa = broj_indeksa;
        }
        public void setSemestar(int semestar)
        {
            this.semestar = semestar;
        }
    }
}
