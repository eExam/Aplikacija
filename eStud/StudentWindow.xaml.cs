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

        public StudentWindow(Korisnik k)
        {
            this.k = k;
            InitializeComponent();
            
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            popuniLabele();

        }
        private void popuniLabele()
        {
            this.username.Content = k.getUserName();
            this.ime.Content = k.getIme();
            this.prezime.Content = k.getPrezime();
            this.pol.Content = k.getPol();
            this.datum_rodjenja.Content = k.getDatumRodjenja();

        }
    }
}
