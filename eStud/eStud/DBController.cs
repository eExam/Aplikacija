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
            connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=eSTUD.accdb; Persist Security Info = False;";
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
        public Korisnik ImaUBazi(string username, string password)
        {
            try
            {

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connect;
                string query;
                query = "Select * from users where username='" + username + "' and password='" + password + "'";
                cmd.CommandText = query;
                // dt ce da cuva rezultate upita

                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);



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
            Predmeti p = new Predmeti();
            try
            {
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = connect;
                string query;
                query = "Select Predmeti.Naziv_predmeta,Predmeti.Semestar,Predmeti.ESPB,Users.ime,Users.prezime FROM Users INNER JOIN ((Profesor INNER JOIN Predmeti ON Profesor.username=Predmeti.Username_profesora) INNER JOIN SlusaPredmet ON Predmeti.Sifra_predmeta=SlusaPredmet.sifra_predmeta) ON Users.username=Profesor.username WHERE SlusaPredmet.username_student='" + username + "'";
                
                cmd.CommandText = query;

                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                
                
                   
                    return dt;

                
              
            }
            catch (Exception ex)
            {
                throw ex;
            }

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


