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
    /// Interaction logic for StudentPocetnaStrana.xaml
    /// </summary>
    public partial class StudentPocetnaStrana : UserControl
    {
        private Student trenutniKorisnik;

        public DataTable rezultati;
        public StudentPocetnaStrana(Student k)
        {
            this.trenutniKorisnik = k;
            InitializeComponent();
            popuniIspitniRokovi();
            popuniListuPolozenih();
            popuniListuPrijavljenih();
            DataTable ispitniRok = new DataTable();
            ispitniRok = DBController.PrikaziIspitniRok();
            if (ispitniRok.Rows.Count == 0)
            {
                this.btnIspitniRok.IsEnabled = false;
            }
            else
            {
                this.btnIspitniRok.IsEnabled = true;
            }

            // popuniPredmete();
        }
        private void popuniIspitniRokovi()
        {
            try
            {
                rezultati = DBController.PrikaziIspitniRok();
                if (rezultati.Rows.Count == 1)
                {
                    // txtIspitniRok.Content = rezultati.Rows[0][0].ToString();
                    txtPocetak.Content = rezultati.Rows[0][2].ToString();
                    txtKraj.Content = rezultati.Rows[0][3].ToString();
                }
               // txtCena.Content = rezultati.Rows[0][5].ToString();
               // txtMaks.Content = rezultati.Rows[0][4].ToString();
              //  tbIspitniRok.Text = (rezultati.Rows[0][0].ToString() + " rok pocinje " + rezultati.Rows[2][0].ToString() + " i zavrsava " + rezultati.Rows[3][0].ToString());
                /*  lblIspitniRok.Content = rezultati.Rows[0][0].ToString() + " Ispitni Rok";
                  lblPocetak.Content = rezultati.Rows[0][2].ToString();
                  lblKraj.Content = rezultati.Rows[0][3].ToString();*/
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Bla");
            }
        }
        private void popuniPredmete()
        {
            rezultati = DBController.StudentPredmeti(trenutniKorisnik.getUserName());
            //tabelaPredmeti.ItemsSource = rezultati.DefaultView;
        }
        
        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void popuniListuPrijavljenih()
        {
            DataTable dt = new DataTable();
            dt = DBController.StudentPrijavljeniIspiti(trenutniKorisnik.getUserName());
            int brojac = dt.Rows.Count;
          
            List<Predmeti> items = new List<Predmeti>();
            for (int i = 0; i < brojac; i++)
            {

                items.Add(new Predmeti() { Predmet = dt.Rows[i][0].ToString(), Semestar = dt.Rows[i][1].ToString() });
                listaPredmeta.ItemsSource = items;

            }
           
           

        }
        private void popuniListuPolozenih()
        {
            DataTable dt1 = new DataTable();
            dt1 = DBController.StudentPolozeniIspiti(trenutniKorisnik.getUserName());
            int brojac1 = dt1.Rows.Count;
            List<Ispiti> itemi = new List<Ispiti>();
            for (int i = 0; i < brojac1; i++)
            {
                itemi.Add(new Ispiti() { Predmet = dt1.Rows[i][0].ToString(), Ocena = dt1.Rows[i][5].ToString(), ESPB = dt1.Rows[i][2].ToString() });
                listaPolozenihIspita.ItemsSource = itemi;
            }
        }
        public class Predmeti
        {
            public string Predmet { get; set; }

            public string Semestar { get; set; }
           


        }
        public class Ispiti
        {
            public string Predmet { get; set; }

            public string Ocena { get; set; }
            public string ESPB { get; set; }
        }

        private void btnIspitniRok_Click(object sender, RoutedEventArgs e)
        {
           
            GlavniPanel.Children.Clear();
            StudentPrikazIspitnihRokova p = new StudentPrikazIspitnihRokova();
            GlavniPanel.Children.Add(p);
        }

        private void btnPrikaziPrijavljene_Click(object sender, RoutedEventArgs e)
        {
            GlavniPanel.Children.Clear();
            StudentPrijavljeniIspit p = new StudentPrijavljeniIspit(trenutniKorisnik);
            GlavniPanel.Children.Add(p);
        }

        private void btnPrikaziPolozene_Click(object sender, RoutedEventArgs e)
        {
            GlavniPanel.Children.Clear();
            PolozeniIspiti p = new PolozeniIspiti(trenutniKorisnik);
            GlavniPanel.Children.Add(p);
        }
    }
}
