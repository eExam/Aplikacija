using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eStud.Model
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public class Korisnik 
    {
        private string username;
        private string usertype;
        private string ime;
        private string prezime;
        private string datumRodjenja;
        private string pol;
        public Korisnik(string username,string usertype,string ime,string prezime,string datumRodjenja,string pol)
        {
            this.username = username;
            this.usertype = usertype;
            this.ime = ime;
            this.prezime = prezime;
            this.datumRodjenja = datumRodjenja;
            this.pol = pol;


        }
        public void setUserType(String usertype)
        {
            this.usertype = usertype;
          
        }
        public void setUserName(String username)
        {
            this.username = username;
            
        }
        public void setIme(String ime)
        {
            this.ime = ime;
           
        }
        public void setPrezime(String prezime)
        {
            this.prezime = prezime;
        
        }
        public void setDatumRodjenja(String datumRodjenja)
        {
            this.datumRodjenja = datumRodjenja;
     
        }
        public void setPol(String pol)
        {
            this.pol = pol;
            
        }
        public String getUserType()
        {
            return usertype;
        }
        public String getUserName()
        {
            return username;
        }
        public String getIme()
        {
            return ime;
        }
        public String getPrezime()
        {
            return prezime;
        }
        public String getDatumRodjenja()
        {
            return datumRodjenja;
        }
        public String getPol()
        {
            return pol;
        }



    }
}
