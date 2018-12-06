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
      
        private DBController dbc;
        private Korisnik k;
        private Predmeti p;
        
       

        public StudentWindow(Korisnik k)
        {
            this.k = k;
          
            InitializeComponent();
            this.ime.Content = k.getIme() + " " + k.getPrezime();

        }
       
        //Klikom na button Moji predmeti student dobija spisak predmeta
        private void btnMojiPredmeti_Click(object sender, RoutedEventArgs e)
        {
            GlavniPanel.Children.Clear();
            MojiPredmeti mp = new MojiPredmeti(k);
            GlavniPanel.Children.Add(mp);
            

           

        }
        //klikom na button podaci student vidi svoje podatke

        private void btnPodaci_Click(object sender, RoutedEventArgs e)
        {
            GlavniPanel.Children.Clear(); //brisemo ono sto se nalazi u panelu
            LicniPodaci lp = new LicniPodaci(k); 
            GlavniPanel.Children.Add(lp);   //Dodajemo ono sto smo napravili u Licnipodaci.xaml prozoru
        }

        private void btnOdjava_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mw = new MainWindow();
            mw.ShowDialog();
        }
    }
}
