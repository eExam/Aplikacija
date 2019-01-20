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
        //Konekcija sa bazom
        private static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\Melida\Documents\GitHub\Aplikacija\eStud\eStud\eSTUD.accdb; Persist Security Info = False;";
        private static OleDbConnection connect = new OleDbConnection(connectionString);

        //Dodavanje novih korisnika u bazu
        public static void UbaciUBazi(string username, string password, string usertype, string ime, string prezime, string datum_rodjenja, string pol)
        {
            try
            {
                OleDbCommand cmd = connect.CreateCommand();
                cmd.CommandText = "Insert into Users values('" + username + "', '" + password + "','" + usertype + "','" + ime + "','" + prezime + "','" + datum_rodjenja + "','" + pol + "')";
                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        
        //Izvrsavanje upita
        public static void IzvrsiUpit(string upit)
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
        //Uzimanje rezultata upita
        public static DataTable rezultatiUpita(string upit)
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

        public static void IzbrisiIzBaze(string upit)
        {
            try
            {

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connect;
                IzvrsiUpit(upit);
            }
            catch (Exception ex)
            {

            }
        }
        //Dodavanje referenta
        public static void DodajRef(string username, string Departman, string StudijskiProgram)
        {
            string upit = "Insert into Referent Values('" + username + "','" + Departman + "','" + StudijskiProgram + "')";
            IzvrsiUpit(upit);
        }

        //Omogucavanje logina
        public static Korisnik ImaUBazi(string username, string password)
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
        //Popunjavanje tabele za predmete koje student slusa
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
        //Popunjavanje tabele za biranje izbornih predmeta
        public static DataTable StudentIzborniPredmeti(string username)
        {
            try
            {
                DataTable dt = new DataTable();
                int sem = getSemestar(username);
                
                dt = rezultatiUpita("Select IzborniPredmeti.Naziv_predmeta, IzborniPredmeti.Departman,IzborniPredmeti.Studijski_program,IzborniPredmeti.Semestar,IzborniPredmeti.ESPB FROM IzborniPredmeti Where IzborniPredmeti.Semestar=" + sem+"");
                
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
        public static DataTable StudentPolozeniIspiti(string username)
        {
            try
            {
                DataTable dt = new DataTable();
                 dt = rezultatiUpita("Select Predmeti.Naziv_predmeta,Predmeti.Semestar,Predmeti.ESPB,Users.ime,Users.prezime,PolozeniIspiti.Ocena FROM Users INNER JOIN ((Profesor INNER JOIN Predmeti ON Profesor.username=Predmeti.Username_profesora) INNER JOIN PolozeniIspiti ON Predmeti.Sifra_predmeta=PolozeniIspiti.Sifra_predmeta) ON Users.username=Profesor.username WHERE PolozeniIspiti.Username_studenta='" + username + "'");
                return dt;

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable PodaciReferent()
        {
            DataTable dt = new DataTable();
            dt = rezultatiUpita("Select Users.username,Users.ime, Users.prezime, Users.datum_rodjenja, Users.pol, Referent.departman, Referent.studijski_program FROM Referent, Users WHERE Users.username=Referent.username");

            return dt;
        }
        //Licni podaci o studentu
        public DataTable PodaciStudent()
        {
            DataTable dt = new DataTable();
            dt = rezultatiUpita("Select Users.username,Users.ime, Users.prezime, Users.datum_rodjenja,Users.pol,Student.departman,Student.studijski_program FROM Student,Users WHERE Users.username=Student.username");
            return dt;

        }

        public static void izbrisiKorisnika(string username)
        {
            IzbrisiIzBaze("delete from Users where Users.username='" + username + "'");
        }
        //Promena lozinke
        public static void postaviNovuLozinku(string username, string staraLozinka, string NovaLozinka)
        {
            try
            {
                connect.Open();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = connect;
                string upit = "UPDATE [Users] SET [password]='" + NovaLozinka + "' WHERE [username]='" + username + "';";

                cmd.CommandText = upit;


                cmd.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("NECE TI" + ex);
            }
            finally
            {
                connect.Close();
            }

        }
        //Uzimanje podatka o trenutnom semestru u kojem je student
        public static int getSemestar(string username)
        {
            string upit = "Select semestar FROM Student where username='" + username + "'";
            DataTable dt = new DataTable();
            dt = rezultatiUpita(upit);

            try
            {

                return int.Parse(dt.Rows[0][0].ToString());
            }
            catch (Exception)
            {

            }
            return 0;


        }
        //Na kojem je departmanu student
        public static string getDepartman(string username)
        {
            string upit = "Select departman FROM Student where username='" + username + "'";
            DataTable dt = new DataTable();
            dt = rezultatiUpita(upit);

            try
            {

                return (dt.Rows[0][0].ToString());
            }
            catch (Exception)
            {

            }
            return null;
        }
        //Na kojem je smeru student
        public static string getSmer(string username)
        {
            string upit = "Select studijski_program FROM Student where username='" + username + "'";
            DataTable dt = new DataTable();
            dt = rezultatiUpita(upit);

            try
            {

                return (dt.Rows[0][0].ToString());
            }
            catch (Exception)
            {

            }
            return null;
        }
        //Broj indeksa studenta
        public static string getBrIndeksa(string username)
        {
            string upit = "Select broj_indeksa FROM Student where username='" + username + "'";
            DataTable dt = new DataTable();
            dt = rezultatiUpita(upit);

            try
            {

                return (dt.Rows[0][0].ToString());
            }
            catch (Exception)
            {

            }
            return null;
        }
        public static string getStatus(string username)
        {

            string upit = "Select status FROM Student where username='" + username + "'";
            DataTable dt = new DataTable();
            dt = rezultatiUpita(upit);

            try
            {

                return (dt.Rows[0][0].ToString());
            }
            catch (Exception)
            {

            }
            return null;

        }
        
        
        //Hashiranje lozinke
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


