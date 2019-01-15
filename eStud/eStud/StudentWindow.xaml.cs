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
       

        
        public StudentWindow(Korisnik k)
        {
            this.student = new Student(k);
            InitializeComponent();
            
            this.ime.Content =this.student.getIme()+ " " + this.student.getPrezime();

            
           
        }

       



        //Klikom na button Moji predmeti student dobija spisak predmeta
        
        private void btnPredmeti_Click(object sender, RoutedEventArgs e)
        {
            GlavniPanel.Children.Clear();
            MojiPredmeti mp = new MojiPredmeti(this.student);

            GlavniPanel.Children.Add(mp);
            

        }
        //Klikom na button menu prikazuje se opadajuci meni
      
        //klikom na button podaci student vidi svoje podatke


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
            IzborniPredmeti ip = new IzborniPredmeti();
            GlavniPanel.Children.Add(ip);
        }
        private void btnPromenaLozinke_Click(object sender, RoutedEventArgs e)
        {
            GlavniPanel.Children.Clear();
            PromenaLozinke pl = new PromenaLozinke();
            GlavniPanel.Children.Add(pl);
        }
    }
}
