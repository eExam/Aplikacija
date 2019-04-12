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
        public int BrPrijava;
        public int BrZahteva;
        public StudentPrijaviIspit(Student s)
        {
            trenutniKorisnik = s;
            InitializeComponent();
            popuniPrijavu();
            popuniPredmete();
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
            rezultati = DBController.PrikaziIspitniRok();
            ispitnirok = rezultati.Rows[0][0].ToString();
            int mozePrijava = int.Parse(rezultati.Rows[0][4].ToString());
            DataTable polozeni = new DataTable();
            
            
            BrZahteva = DBController.BrojPoslatihZahteva(trenutniKorisnik.getUserName());
            BrPrijava = DBController.BrojBrijavljenihIspita(trenutniKorisnik.getUserName());

            if (BrPrijava == mozePrijava)
            {
                MessageBox.Show("Prijavljeno je maks");
                
            }

            else if(BrZahteva >= int.Parse(rezultati.Rows[0][4].ToString()))
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
                    if (DBController.DaLiJePrijavljenIspit(sifra, trenutniKorisnik.getUserName()))

                    {
                        MessageBox.Show("Ispit je prijavljen");
                    }
                    else
                    {
                        


                        DBController.PosaljiZahtev(trenutniKorisnik.getUserName(), sifra, ispitnirok, ComboProf1.Text);
                        MessageBox.Show("Zahtev je poslat" + BrPrijava);
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
        }
    }
}
