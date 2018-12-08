using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace eStud.Model
{

    class DBController
    {
        OleDbConnection connect = new OleDbConnection();
        public DBController()
        {
            connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\Melida\source\repos\eSTUD\eStud\eSTUD.accdb; Persist Security Info = False;";
            connect.Open();

        }
       

        public void IzvrsiUpit(string upit)
        {
            try
            {
                connect.Open();
                new OleDbCommand(upit, connect).ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connect.Close();
            }
        }
       
        public DataTable rezultatiUpita(string upit)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = connect;
            string query = upit;
            cmd.CommandText = query;
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
      
        public void IzbrisiIzBaze(string upit)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connect;
                IzvrsiUpit(upit);
            }
            catch(Exception ex)
            {
                
            }
        }
        
        
        public Korisnik ImaUBazi(string username, string password)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = rezultatiUpita("Select * from users where username='" + username + "' and password='" + password + "'");
                // dt.Rows oznacava broj javljanja osobe u tabeli Korisnici
                // Ovde se takodje vrsi i poredjenje lozinke sa enkriptovanom lozinkom u bazi
                if (dt.Rows.Count == 1)
                    return new Korisnik(dt.Rows[0][0].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString(), dt.Rows[0][6].ToString());

                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public DataTable StudentPredmeti(string username)
        { 
            try
            {
                DataTable dt = new DataTable();
                dt = rezultatiUpita("Select Predmeti.Naziv_predmeta,Predmeti.Semestar,Predmeti.ESPB,Users.ime,Users.prezime FROM Users INNER JOIN ((Profesor INNER JOIN Predmeti ON Profesor.username=Predmeti.Username_profesora) INNER JOIN SlusaPredmet ON Predmeti.Sifra_predmeta=SlusaPredmet.sifra_predmeta) ON Users.username=Profesor.username WHERE SlusaPredmet.username_student='" + username + "'");
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public DataTable StudentPrijavljeniIspiti(string username)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = rezultatiUpita(" SELECT Predmeti.Naziv_predmeta, Predmeti.Semestar, Predmeti.ESPB,Users.ime, Users.prezime, PrijavljeniIspiti.broj_prijava FROM Users INNER JOIN((Profesor INNER JOIN Predmeti ON Profesor.username = Predmeti.username_profesora) INNER JOIN PrijavljeniIspiti ON Predmeti.Sifra_predmeta = PrijavljeniIspiti.Sifra_predmeta) ON Users.username = Profesor.username WHERE PrijavljeniIspiti.username_studenta ='" + username + "'");
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable PodaciReferent()
        { 
            DataTable dt = new DataTable();
            dt = rezultatiUpita("Select Users.ime, Users.prezime, Users.datum_rodjenja, Users.pol, Referent.departman, Referent.studijski_program FROM Referent, Users WHERE Users.username=Referent.username");
          
            return dt;
        }
       public DataTable PodaciStudent()
        {
            DataTable dt = new DataTable();
            dt = rezultatiUpita("Select Users.ime, Users.prezime, Users.datum_rodjenja,Users.pol,Student.departman,Student.studijski_program FROM Student,Users WHERE Users.username=Student.username");
            return dt;

        }
        public void izbrisiRef(string username)
        {                
            IzbrisiIzBaze("delete from Users where Users.username='" + username + "'");
        }
       
        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

    }
}


