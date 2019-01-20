using eStud.Model;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for PromenaLozinke.xaml
    /// </summary>
    public partial class PromenaLozinke : UserControl
    {
        Student trenutniKorisnik;
        public PromenaLozinke(Student tk)
        {
            trenutniKorisnik = tk;
            InitializeComponent();
        }

        private void btnPromeniLozinku_Click(object sender, RoutedEventArgs e) 
        {
            try
            {
                Console.WriteLine(trenutniKorisnik.getUserName());
                if (imaPraznihPolja())
                    throw new Exception("Niste popunili sva polja");
                if (txtNovaLozinka.Text != txtNovaLozinka2.Text)
                    throw new Exception("Lozinke se ne poklapaju");
             
                    DBController.postaviNovuLozinku(trenutniKorisnik.getUserName(), txtStaraLozinka.Text, txtNovaLozinka.Text);
                    MessageBox.Show("Uspesno ste promenili lozinku");
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Niste zamenili");
                ocistiSvaPolja();
            }
        }
        private void ocistiSvaPolja()
        {
            txtStaraLozinka.Text = "";
            txtNovaLozinka.Text = " ";
            txtNovaLozinka2.Text = "";
        }
        private bool imaPraznihPolja()
        {
            return txtStaraLozinka.Text == ""
                 || txtNovaLozinka.Text == ""
                 || txtNovaLozinka2.Text == "";
             
        }
    }
}
