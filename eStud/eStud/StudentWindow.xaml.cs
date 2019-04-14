using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
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
using System.Windows.Shapes;
using eStud.Model;

namespace eStud
{
    /// <summary>
    /// Interaction logic for StudentWindow.xaml
    /// </summary>
    public partial class StudentWindow : Window
    {

       
        private Student student;

        public DataTable rezultati;
        DataTable polozeniIspiti;


        public StudentWindow(Korisnik k)
        {
            this.student = new Student(k);
            InitializeComponent();
            
            this.ime.Content =this.student.getIme()+ " " + this.student.getPrezime();
            GlavniPanel.Children.Clear();
            StudentPocetnaStrana sp = new StudentPocetnaStrana(student);
            GlavniPanel.Children.Add(sp);
        }

       



        //Klikom na button Moji predmeti student dobija spisak predmeta
        
        private void btnPredmeti_Click(object sender, RoutedEventArgs e)
        {
            GlavniPanel.Children.Clear();
            MojiPredmeti mp = new MojiPredmeti(this.student);

            GlavniPanel.Children.Add(mp);
            

        }
       

        private void btnPodaci_Click(object sender, RoutedEventArgs e)
        {
            GlavniPanel.Children.Clear(); //brisemo ono sto se nalazi u panelu
            LicniPodaci lp = new LicniPodaci(student); 
            GlavniPanel.Children.Add(lp);   //Dodajemo ono sto smo napravili u Licnipodaci.xaml prozoru
            
        }
        private void btnPrijavljeniIspiti_Click(object sender, RoutedEventArgs e)
        {
            GlavniPanel.Children.Clear();
            StudentPrijavljeniIspit spi = new StudentPrijavljeniIspit(student);
            GlavniPanel.Children.Add(spi);
          
        }
        private void btnOdjava_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mw = new MainWindow();
            mw.ShowDialog();
        }

        private void btnIzborniPredmeti_Click(object sender, RoutedEventArgs e)
        {
            GlavniPanel.Children.Clear();
            IzborniPredmeti ip = new IzborniPredmeti(student);
            GlavniPanel.Children.Add(ip);
        }
        private void btnPromenaLozinke_Click(object sender, RoutedEventArgs e)
        {
            GlavniPanel.Children.Clear();
            PromenaLozinke pl = new PromenaLozinke(student);
            GlavniPanel.Children.Add(pl);
        }
        private void btnPrijaviIspit_Click(object sender, RoutedEventArgs e)
        {
            GlavniPanel.Children.Clear();
            StudentPrijaviIspit spi = new StudentPrijaviIspit(student);
            GlavniPanel.Children.Add(spi);

        }
        private void btnPolozeniIspiti_Click(object sender, RoutedEventArgs e)
        {
            GlavniPanel.Children.Clear();
            PolozeniIspiti pi = new PolozeniIspiti(student);
            GlavniPanel.Children.Add(pi);
        }
        private void btnStatus_Click(object sender, RoutedEventArgs e)
        {
            StatusObavestenje so = new StatusObavestenje(student);
            so.ShowDialog();
        }

        private void btnIspitniRokovi_Click(object sender, RoutedEventArgs e)
        {
            GlavniPanel.Children.Clear();
            StudentPrikazIspitnihRokova spir = new StudentPrikazIspitnihRokova();
            GlavniPanel.Children.Add(spir);
        }

        private void btnPocetna_Click(object sender, RoutedEventArgs e)
        {
            GlavniPanel.Children.Clear();
            StudentPocetnaStrana sp = new StudentPocetnaStrana(student);
            GlavniPanel.Children.Add(sp);
        }

        private void btnESPB_Checked(object sender, RoutedEventArgs e)
        {
            int ESPB=0;
            
            polozeniIspiti = DBController.StudentPolozeniIspiti(student.getUserName());
            int brojac = polozeniIspiti.Rows.Count;
            for (int i = 0; i < brojac; i++)
            {
                ESPB+=int.Parse(polozeniIspiti.Rows[i][2].ToString());

            }
            MessageBox.Show("Ukupan broj ESPB bodova =" + ESPB);
        }

        private void btnPodaci_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btnPotvrdeUverenja_Checked(object sender, RoutedEventArgs e)
        {
            this.GlavniPanel.Children.Clear();
            StudentPotvrdeUverenja s = new StudentPotvrdeUverenja(student);
            this.GlavniPanel.Children.Add(s);
        }
    }
}
