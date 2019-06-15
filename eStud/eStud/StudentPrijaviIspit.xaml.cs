using eStud.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace eStud
{
    /// <summary>
    /// Interaction logic for StudentPrijaviIspit.xaml
    /// </summary>
    public partial class StudentPrijaviIspit : UserControl
    {
        Student trenutniKorisnik;
        public DataTable rezultati;
        public DataTable ispitniRok=DBController.PrikaziIspitniRok();
        public int BrPrijava;
        public int BrZahteva;
        public StudentPrijaviIspit(Student s)
        {
            trenutniKorisnik = s;
            InitializeComponent();
            popuniPrijavu();
            popuniPredmete();
            if (ispitniRok.Rows.Count == 0)
            {
                this.btnPrijavi.IsEnabled = false;
            }
            else
            {
                this.btnPrijavi.IsEnabled = true;
            }
           
            
        }
        public void popuniPrijavu()
        {
          
            this.txtImePrezime.Text = trenutniKorisnik.getIme() +" " + trenutniKorisnik.getPrezime();
            this.txtDepartman.Text = DBController.getDepartman(trenutniKorisnik.getUserName());
            this.txtBrIndeksa.Text = DBController.getBrIndeksa(trenutniKorisnik.getUserName());
            this.txtStudijskiProgram.Text = DBController.getSmer(trenutniKorisnik.getUserName());
           
        }
        public void popuniPredmete()
        {
            DataTable rezultati = DBController.StudentPredmeti(trenutniKorisnik.getUserName());
            string[] predmet;
          
            int broj = rezultati.Rows.Count;
           
            predmet = new string[broj];
            for (int i = 0; i < broj; i++)
            {
                predmet[i] = rezultati.Rows[i][0].ToString();
                ComboPredmeti.Items.Add(predmet[i]);

            }
            
           string selected = ComboPredmeti.Text;
            
            string prof = DBController.getProfesora(selected);
            if(prof!=null)
            {
                ComboProf1.Items.Add(prof);
            }
            

        }






        private void btnPrijavi_Click(object sender, RoutedEventArgs e)
        {
            
            string sifra = DBController.getSifraPredmeta(ComboPredmeti.Text);
            string ispitnirok;
            int brPrijave;
            try
            {
                 brPrijave = DBController.getBrojPrijave(ComboPredmeti.Text, trenutniKorisnik.getUserName());
            }
            catch(Exception ex)
            {
                brPrijave = 1;
            }
            rezultati = DBController.PrikaziIspitniRok();
            ispitnirok = rezultati.Rows[0][0].ToString();
            int mozePrijava = int.Parse(rezultati.Rows[0][4].ToString());
            DataTable polozeni = new DataTable();
            int prijava;
            try
            {
                prijava = DBController.getBrPrijaveRef(ComboPredmeti.Text, trenutniKorisnik.getUserName());
            }
            catch (Exception ex)
            {
                prijava = 0;
            }
            BrZahteva = DBController.BrojPoslatihZahteva(trenutniKorisnik.getUserName());
            BrPrijava = DBController.BrojBrijavljenihIspita(trenutniKorisnik.getUserName());

          

            if(BrZahteva >= int.Parse(rezultati.Rows[0][4].ToString()))
                {

                MessageBox.Show("Moguce je prijaviti samo " + mozePrijava + " ispita");

            }
            else
            {
                if (DBController.DaLiJePolozenIspit(sifra, trenutniKorisnik.getUserName()) == true)
                {
                    MessageBox.Show("Ispit je polozen");
                }
                else
                {
                    if (int.Parse(txtBrPrijave.Text) != brPrijave)
                    {
                        MessageBox.Show("Broj prijave nije tacan" + brPrijave);
                    }
                    else
                    {
                       
                        
                            if (prijava == brPrijave)

                            {
                                MessageBox.Show("Zahtev je vec poslat");
                            }
                            else
                            {
                                DBController.PosaljiZahtev(trenutniKorisnik.getUserName(), sifra, ispitnirok, ComboProf1.Text, brPrijave);

                                DBController.setBrojPrijave(trenutniKorisnik.getUserName(), ComboPredmeti.Text, brPrijave);
                                MessageBox.Show("Uspesno ste poslali zahtev");

                            }
                        }

                    
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string selected = ComboPredmeti.Text;
            ComboProf1.Items.Add(DBController.getProfesora(selected));
        }

       

        private void ComboProf1_DropDownOpened(object sender, EventArgs e)
        {
            string selected = ComboPredmeti.Text;
            string prof = DBController.getProfesora(selected);
            if (prof != null)
            {
                ComboProf1.Items.Add(prof);
            }
          //  else
           // ComboProf1.Items.Remove(prof);
        }

        private void txtBrPrijave_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
           
                foreach (var ch in e.Text)
                {
                    if (!((Char.IsDigit(ch))) || ch.Equals('='))
                    {
                        e.Handled = true;

                        break;
                    }
                
            }
        }
    }
}
