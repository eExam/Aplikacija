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
        private static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=eSTUD.accdb; Persist Security Info = False;";
        private static OleDbConnection connect = new OleDbConnection(connectionString);

        //Dodavanje novih korisnika u bazu
        public static void UbaciUBazi(string username, string password, string usertype, string ime, string prezime, string datum_rodjenja, string pol,string grad,string adresa)
        {
            try
            {
                OleDbCommand cmd = connect.CreateCommand();
                cmd.CommandText = "Insert into Users values('" + username + "', '" + CreateMD5(password) + "','" + usertype + "','" + ime + "','" + prezime + "','" + datum_rodjenja + "','" + pol + "','"+grad+"','"+adresa+"')";
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
            try
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
            catch(Exception ex)
            {
                throw ex;            }
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
            try
            {
                string upit = "Insert into Referent Values('" + username + "','" + Departman + "','" + StudijskiProgram + "')";
                IzvrsiUpit(upit);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public static void DodajStud(string username,string departman,string studijski_program,int semestar,string broj_indeksa,string status,string godina_upisa)
        {
            try
            {
                string upit = "Insert into Student Values('" + username + "','" + departman + "','" + studijski_program + "','" + semestar + "','" + broj_indeksa + "','" + status + "','" + godina_upisa + "')";
                IzvrsiUpit(upit);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void IzmeniRef(string username,string ime,string prezime,string datumRodj,string pol,string Departman,string studijskiProgram,string grad,string adresa)
        {
            string upit = "UPDATE [Users] SET [Ime]='" + ime + "',[Prezime]='"+prezime+"',[Datum_rodjenja]='"+datumRodj+"',[pol]='"+pol+"',[grad]='"+grad+"',[adresa]='"+adresa+"' WHERE [username]='" + username + "';";
            IzvrsiUpit(upit);
            string upit2="UPDATE [Referent] SET [Departman]='"+Departman+"',[Studijski_program]='"+studijskiProgram+"' WHERE [username]='"+username+"'";
            IzvrsiUpit(upit2);
        }
        public static void Izmenistud(string username,string ime,string prezime,string datumRodj,string pol,string Departman,string studijskiProgram,string grad,string adresa,int semestar,string brojIndeksa,string godinaUpisa,string status)
        {
            string upit = "UPDATE [Users] SET [Ime]='" + ime + "',[Prezime]='" + prezime + "',[Datum_rodjenja]='" + datumRodj + "',[pol]='" + pol + "',[grad]='" + grad + "',[adresa]='" + adresa + "' WHERE [username]='" + username + "';";
            IzvrsiUpit(upit);
            string upit2 = "UPDATE [Student] SET [departman]='" + Departman + "',[studijski_program]='" + studijskiProgram + "',[semestar]='"+semestar+"',[broj_indeksa]='"+brojIndeksa+"',[status]='"+status+"',[godina_upisa]='"+godinaUpisa+"' WHERE [username]='" + username + "'";
            IzvrsiUpit(upit2);
        }
        public static void IzmeniRok(string nazivRoka,string Redovan,string Pocetak,string Kraj,int max,int cena)
        {
            string upit = "UPDATE [IspitniRokovi] SET [Tip]='" + Redovan + "',[Pocetak_roka]='" + Pocetak + "',[Kraj_roka]='" + Kraj + "',[Max_brPrijava]='" + max + "',[Cena_prijave]='" + cena+ "' WHERE [Naziv_roka]='" + nazivRoka + "';";
            IzvrsiUpit(upit);
        }

        //Omogucavanje logina
        public static Korisnik ImaUBazi(string username, string password)
        {
           
            try
            {
                DataTable dt = new DataTable();
                dt = rezultatiUpita("Select * from users where username='" + username + "' and password='" +CreateMD5(password)+ "'");
                // dt.Rows oznacava broj javljanja osobe u tabeli Korisnici
                // Ovde se takodje vrsi i poredjenje lozinke sa enkriptovanom lozinkom u bazi
                if (dt.Rows.Count == 1)
                    return new Korisnik(dt.Rows[0][0].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString(), dt.Rows[0][6].ToString(),dt.Rows[0][7].ToString(),dt.Rows[0][8].ToString());

                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static void DodajPotvrdeUverenje(string username,string razlog,string obrazlozenje)
        {
            string upit = "insert into PotvrdeUverenja (username_stud,razlog,obrazlozenje) values ('" + username + "','" + razlog + "','" + obrazlozenje + "')";
            IzvrsiUpit(upit);
        }
        public static DataTable PrikaziMolbe()
        {
            DataTable dt = new DataTable();
            string upit = "select PotvrdeUverenja.ID, Users.username,Users.ime,Users.prezime, PotvrdeUverenja.razlog,PotvrdeUverenja.obrazlozenje FROM Users INNER JOIN PotvrdeUverenja ON Users.username=PotvrdeUverenja.username_stud";
            dt=rezultatiUpita(upit);
            return dt;
        }
        public static void OdobriMolbe(string username,string tip)
        {
            string upit = "insert into OdobrenePotvrdeUverenja (username,tip_dokumenta)values('" + username + "','" + tip + "')";
            IzvrsiUpit(upit);
        }
        public static DataTable prikaziOdobreneMolbe()
        {
            DataTable dt = new DataTable();
            dt = rezultatiUpita("Select OdobrenePotvrdeUverenja.ID,Users.username,Users.ime,Users.Prezime,OdobrenePotvrdeUverenja.tip_dokumenta FROM Users INNER JOIN OdobrenePotvrdeUverenja ON Users.username=OdobrenePotvrdeUverenja.username");
            return dt;
        }
        
        public static void izbrisiZahtev(int id)
        {
            string upit = "delete from PotvrdeUverenja where ID="+id+"";
            IzvrsiUpit(upit);
        }
        public static void IzbrisiZahtevZaIspit(int id)
        {
            try
            {
                string upit = "delete from ZahteviZaPrijavu where ZahteviZaPrijavu.ID="+id+"";
                
                IzvrsiUpit(upit);
            }
            catch(Exception ex)
            {
                Console.WriteLine(id);
            }
        }
        public static bool ZauzetoKorisnicko(string username)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = rezultatiUpita("Select * from users where username='" + username + "'");
                // dt.Rows oznacava broj javljanja osobe u tabeli Korisnici
                // Ovde se takodje vrsi i poredjenje lozinke sa enkriptovanom lozinkom u bazi
                if (dt.Rows.Count == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int getBrojPrijave(string nazivPredmeta,string username)
        {
            try
            {
                string sifra = getSifraPredmeta(nazivPredmeta);
                DataTable dt = new DataTable();
                string upit = "Select PrijavljeniIspiti.broj_prijava FROM PrijavljeniIspiti Where sifra_predmeta='" + sifra + "' and username_studenta='" + username + "'";
                dt = rezultatiUpita(upit);
                return int.Parse(dt.Rows[0][0].ToString());
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
        public static void setBrojPrijave(string username, string nazivPredmeta,int brPrijave)
        {
            try { 
            string sifra = getSifraPredmeta(nazivPredmeta);
          
            string upit = "UPDATE [PrijavljeniIspiti] SET [broj_prijava]='" + brPrijave + "' WHERE [sifra_predmeta]='" + sifra + "' and [username_studenta]='" + username + "'";
            IzvrsiUpit(upit);
        }

            catch(Exception ex)
            {
                throw ex;
            }
        }
        //Popunjavanje tabele za predmete koje student slusa
        public static DataTable StudentPredmeti(string username)
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
        public static void StudentDodajIzborniPredmet(string nazivPredmeta,string Departman,string smer,string usernameProf,int semestar,int espb)
        {
            try
            {
                string sifra = getSifraIzbornog(nazivPredmeta);
                string upit = "Insert into Predmeti values('" + sifra + "','" + nazivPredmeta + "','" + Departman + "','" + smer + "','" + usernameProf + "','" + semestar + "','" + espb + "')";
                IzvrsiUpit(upit);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public static void StudentIzabrao(string username,string nazivPredmeta)
        {
            try
            {
                string sifra = getSifraPredmeta(nazivPredmeta);
                string upit = "Insert into SlusaPredmet values('" + username + "','" + sifra + "')";
                IzvrsiUpit(upit);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public static void StudentIzbrisiIzborniPredmet(string nazivPredmeta)
        {
            string sifra = getSifraPredmeta(nazivPredmeta);
            string upit = "delete  from IzborniPredmeti where IzborniPredmeti.sifra_predmeta='" + sifra + "'";
            IzvrsiUpit(upit);
        }
        
        

        public static string getProfesora(string NazivPredmeta)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = rezultatiUpita("Select username_profesora From Predmeti where Naziv_predmeta='" + NazivPredmeta + "'");
                if (dt.Rows.Count == 1)
                {
                    return dt.Rows[0][0].ToString();
                }
                else
                {
                    return null;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
       public static string getSifraPredmeta(string NazivPredmeta)
        {
            try
            {
                DataTable dt = new DataTable();

                dt = rezultatiUpita("Select Sifra_predmeta From Predmeti where Naziv_predmeta='" + NazivPredmeta + "'");
                return dt.Rows[0][0].ToString();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public static string getSifraIzbornog(string NazivPredmeta)

        {
            try
            {
                DataTable dt = new DataTable();

                dt = rezultatiUpita("Select Sifra_predmeta From IzborniPredmeti where Naziv_predmeta='" + NazivPredmeta + "'");
                return dt.Rows[0][0].ToString();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable getStudente()
        {
            DataTable dt = new DataTable();
            string upit = ("Select Users.ime,Users.prezime,Student.broj_indeksa FROM Users INNER JOIN Student ON Users.username=Student.username");
            dt = rezultatiUpita(upit);
            return dt;
        }
        public static DataTable getReferente()
        {
            DataTable dt = new DataTable();
            string upit = ("Select Users.ime,Users.prezime,Referent.Departman From Users INNER JOIN Referent ON Users.username=Referent.username");
            dt = rezultatiUpita(upit);
            return dt;

        }
        //Popunjavanje tabele za biranje izbornih predmeta
        public static DataTable StudentIzborniPredmeti(string username)
        {
            try
            {
                DataTable dt = new DataTable();
                int sem = getSemestar(username);

                dt = rezultatiUpita("Select Users.ime,IzborniPredmeti.Naziv_predmeta, IzborniPredmeti.Departman,IzborniPredmeti.Studijski_program,IzborniPredmeti.Semestar,IzborniPredmeti.ESPB FROM IzborniPredmeti,Users Where IzborniPredmeti.Semestar=" + sem + " and Users.username=IzborniPredmeti.username_profesora");

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        
        public static DataTable StudentNeprijavljeniIspiti(string username)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = rezultatiUpita(" SELECT Predmeti.Naziv_predmeta, Predmeti.Semestar, Predmeti.ESPB,Users.ime, Users.prezime,NeprijavljeniIspiti.broj_prijava FROM Users INNER JOIN((Profesor INNER JOIN Predmeti ON Profesor.username = Predmeti.username_profesora) INNER JOIN NeprijavljeniIspiti ON Predmeti.Sifra_predmeta = NeprijavljeniIspiti.Sifra_predmeta) ON Users.username = Profesor.username WHERE NeprijavljeniIspiti.username_studenta ='" + username + "'");
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int BrojPoslatihZahteva(string username)
        {
            string upit="Select count(username_stud) FROM ZahteviZaPrijavu where username_stud='"+username+"' ";
            DataTable dt = new DataTable();

            dt = rezultatiUpita(upit);
            

            return int.Parse(dt.Rows[0][0].ToString());
        }
        public static int BrojBrijavljenihIspita(string username)
        {
            string upit = "Select count(username_studenta) FROM PrijavljeniIspiti where username_studenta='" + username + "' ";
            DataTable dt = new DataTable();

            dt = rezultatiUpita(upit);


            return int.Parse(dt.Rows[0][0].ToString());
        }

        public static DataTable StudentPrijavljeniIspiti(string username)
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
        public static DataTable ReferentPrijavljeniIspiti()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = rezultatiUpita(" SELECT Users.ime, Users.prezime,Predmeti.Naziv_predmeta, Predmeti.Semestar, Predmeti.ESPB,  PrijavljeniIspiti.broj_prijava,Profesor.imeprof,Profesor.prezimeprof  FROM Users INNER JOIN((Profesor INNER JOIN Predmeti ON Profesor.username = Predmeti.username_profesora) INNER JOIN PrijavljeniIspiti ON Predmeti.Sifra_predmeta = PrijavljeniIspiti.Sifra_predmeta) ON Users.username = PrijavljeniIspiti.username_studenta");
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable PrijavniceZaProfesora(string nazivPredmeta)
        {
            string sifra = getSifraPredmeta(nazivPredmeta);
            DataTable dt = new DataTable();
            dt = rezultatiUpita("SELECT Users.username,Users.ime, Users.prezime,Predmeti.Naziv_predmeta, Predmeti.Semestar, Predmeti.ESPB,  PrijavljeniIspiti.broj_prijava,Profesor.imeprof,Profesor.prezimeprof  FROM Users INNER JOIN((Profesor INNER JOIN Predmeti ON Profesor.username = Predmeti.username_profesora) INNER JOIN PrijavljeniIspiti ON Predmeti.Sifra_predmeta = PrijavljeniIspiti.Sifra_predmeta) ON Users.username = PrijavljeniIspiti.username_studenta  Where PrijavljeniIspiti.sifra_predmeta='"+sifra+"'");
            return dt;
        }

        public static DataTable StudentPolozeniIspiti(string username)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = rezultatiUpita("Select Predmeti.Naziv_predmeta,Predmeti.Semestar,Predmeti.ESPB,Users.ime,Users.prezime,PolozeniIspiti.Ocena FROM Users INNER JOIN ((Profesor INNER JOIN Predmeti ON Profesor.username=Predmeti.Username_profesora) INNER JOIN PolozeniIspiti ON Predmeti.Sifra_predmeta=PolozeniIspiti.Sifra_predmeta) ON Users.username=Profesor.username WHERE PolozeniIspiti.Username_studenta='" + username + "'");
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool DaLiJePolozenIspit(string sifraPredmeta,string username)
        {
            DataTable dt = new DataTable();
           
             dt = rezultatiUpita("Select PolozeniIspiti.Sifra_predmeta,PolozeniIspiti.Username_studenta FROM PolozeniIspiti where Sifra_predmeta='" + sifraPredmeta + "' and Username_studenta='" + username + "'");

            try
            {
                if (dt.Rows.Count==1)

                    return true;

                

               
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public static bool DaLiJePrijavljenIspit(string nazivPredmeta,string username,int brPrijave)
        {
            string sifraPredmeta = getSifraPredmeta(nazivPredmeta);
            DataTable dt = new DataTable();
            string upit = "Select * FROM PrijavljeniIspiti where sifra_predmeta='" + sifraPredmeta + "' and broj_prijava=" + brPrijave + " and username_studenta='" + username + "'";
            dt = rezultatiUpita(upit);
            if (dt.Rows.Count == 1)

                return true;
            else
                return false ;
        }
        public static DataTable PodaciReferent()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = rezultatiUpita("Select Users.username,Users.ime, Users.prezime, Users.datum_rodjenja, Users.pol, Users.Grad,Users.Adresa,Referent.departman, Referent.studijski_program FROM Referent, Users WHERE Users.username=Referent.username");

                return dt;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        
        //Licni podaci o studentu
        public static DataTable PodaciStudent()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = rezultatiUpita("Select Users.username,Users.ime, Users.prezime, Users.datum_rodjenja,Users.pol,Users.Grad,Users.Adresa, Student.departman,Student.studijski_program,Student.semestar,Student.status,Student.broj_indeksa,Student.godina_upisa FROM Student,Users WHERE Users.username=Student.username");
                return dt;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static void izbrisiKorisnika(string username)
        {
            IzbrisiIzBaze("delete from Users where Users.username='" + username + "'");
        }
        //Promena lozinke
        public static void postaviNovuLozinku(string username, string NovaLozinka)
        {
            try
            {
                connect.Open();
                OleDbCommand cmd = new OleDbCommand();

                cmd.Connection = connect;
                string upit = "UPDATE [Users] SET [password]='" + CreateMD5(NovaLozinka) + "' WHERE [username]='" + username + "';";

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
        public static string getGodinaUpisa(string username)
        {
            string upit = "Select godina_upisa FROM Student where username='" + username + "'";
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
        public static string getPassword(string username)
        {
            string upit = "Select password FROM Users where username='" + username + "'";
            DataTable dt = new DataTable();
            dt = rezultatiUpita(upit);
            try
            {

                return (dt.Rows[0][0].ToString());


            }
            catch (Exception ex)
            {
                throw ex;
            }
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
        public static void PosaljiZahtev(string username,string predmet,string ispitnirok,string usernameProf,int brPrijave )
        {
            try
            {
                string upit = "Insert into ZahteviZaPrijavu (username_stud,sifra_predmeta,ispitni_rok,username_prof,brPrijave) values('" + username + "', '" + predmet + "','" + ispitnirok + "','" + usernameProf + "','"+brPrijave+"')";
                IzvrsiUpit(upit);
            }
            catch(Exception ex)
            {

            }
        }
       public static DataTable getPredmeti()
        {
            DataTable dt = new DataTable();
            string upit = ("Select Predmeti.Naziv_predmeta FROM Predmeti");
            dt=rezultatiUpita(upit);
            return dt;
        }
        public static DataTable ReferentZahteviPrijava()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = rezultatiUpita("Select ZahteviZaPrijavu.ID,Users.username,Users.ime,Users.prezime ,Predmeti.Naziv_predmeta,Predmeti.Semestar,Predmeti.ESPB,Profesor.imeprof,Profesor.prezimeprof,ZahteviZaPrijavu.ispitni_rok, ZahteviZaPrijavu.brPrijave FROM Users INNER JOIN ((Profesor INNER JOIN Predmeti ON Profesor.username=Predmeti.Username_profesora) INNER JOIN ZahteviZaPrijavu ON Predmeti.Sifra_predmeta=ZahteviZaPrijavu.sifra_predmeta) ON Users.username=ZahteviZaPrijavu.username_stud");
                return dt;
               
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public static int getBrPrijaveRef(string nazivPredmeta,string username)
        {
            DataTable dt = new DataTable();
            try
            {
              
                string sifra = getSifraPredmeta(nazivPredmeta);
                string upit = "Select ZahteviZaPrijavu.brPrijave FROM ZahteviZaPrijavu where username_stud='" + username + "' and sifra_predmeta='" + sifra + "'";
                dt = rezultatiUpita(upit);
                return int.Parse(dt.Rows[0][0].ToString());
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
        public static void OdobriPrijavuIspita(string username, int brojPrijave,string nazivPredmeta)
        {

            try
            {
                string sifraPredmeta = getSifraPredmeta(nazivPredmeta);
                string upit = "Insert into PrijavljeniIspiti values('" + sifraPredmeta + "', '" + brojPrijave + "','" + username + "')";
                IzvrsiUpit(upit);
            }
            catch(Exception ex)
            {

            }

        }
        public static void OdbijPrijavuIspita(string username,int brojPrijave,string nazivPredmeta)
        {
            try
            {
                string sifra = getSifraPredmeta(nazivPredmeta);
                string upit = "Insert into NeprijavljeniIspiti values('" + sifra + "','" + brojPrijave + "','" + username + "')";
                IzvrsiUpit(upit);
            }
            catch (Exception ex)
            {

            }
        }
        public static void DodajIspitniRok(string nazivRoka,string redovan,string pocetakRoka,string krajRoka,int max_brPrijava,int cenaPrijave)
        {
            try
            {
                string upit = "Insert into IspitniRokovi values ('" + nazivRoka + "','" + redovan + "','" + pocetakRoka + "','" + krajRoka + "','" + max_brPrijava + "','" + cenaPrijave + "')";
                IzvrsiUpit(upit);
            }
            catch(Exception ex)
            {

            }

        }
        public static DataTable PrikaziIspitniRok()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = rezultatiUpita("Select IspitniRokovi.Naziv_roka,IspitniRokovi.Tip,IspitniRokovi.Pocetak_roka,IspitniRokovi.Kraj_roka,IspitniRokovi.Max_brPrijava,IspitniRokovi.Cena_prijave FROM IspitniRokovi");
                

                    return dt;
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public static void IzbrisiIspitniRok(string nazivRoka)
        {
            try
            {
                string upit = "delete from IspitniRokovi where IspitniRokovi.Naziv_roka='" + nazivRoka + "'";
                IzvrsiUpit(upit);
            }
            catch(Exception ex)
            {

            }
        }
        public static DataTable pretragaPredmeta(string value,string username)
        {
            DataTable dt = new DataTable();
            dt = rezultatiUpita("Select Predmeti.Naziv_predmeta,Predmeti.Semestar,Predmeti.ESPB,Users.ime,Users.prezime FROM Users INNER JOIN ((Profesor INNER JOIN Predmeti ON Profesor.username=Predmeti.Username_profesora) INNER JOIN SlusaPredmet ON Predmeti.Sifra_predmeta=SlusaPredmet.sifra_predmeta) ON Users.username=Profesor.username WHERE SlusaPredmet.username_student='" + username + "' and Naziv_predmeta like '%"+value+"%'");

          
           
            return dt;
        }
        public static DataTable pretragaPrezime(string value)
        {
            DataTable dt = new DataTable();
            dt = rezultatiUpita("Select Users.username,Users.ime, Users.prezime, Users.datum_rodjenja, Users.pol, Users.Grad,Users.Adresa,Referent.departman, Referent.studijski_program FROM Referent, Users WHERE Users.username=Referent.username and Users.prezime like '%" + value + "%'");
            return dt;
        
    }
        public static DataTable pretragaReferenta(string value)
        {
            DataTable dt = new DataTable();
            dt = rezultatiUpita("Select Users.username,Users.ime, Users.prezime, Users.datum_rodjenja, Users.pol, Users.Grad,Users.Adresa,Referent.departman, Referent.studijski_program FROM Referent, Users WHERE Users.username=Referent.username and Users.Ime like '%"+value+"%'");
            return dt;
        }
        public static DataTable pretragaStudenata(string value)
        {
            DataTable dt = new DataTable();
            dt = rezultatiUpita("Select Users.username,Users.ime, Users.prezime, Users.datum_rodjenja,Users.pol,Users.Grad,Users.Adresa, Student.departman,Student.studijski_program,Student.semestar,Student.status,Student.broj_indeksa,Student.godina_upisa FROM Student,Users WHERE Users.username=Student.username and Users.Ime like '%"+value+"%'");
            return dt;
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


