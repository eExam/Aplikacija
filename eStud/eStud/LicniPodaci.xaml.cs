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
    /// Interaction logic for LicniPodaci.xaml
    /// </summary>
    public partial class LicniPodaci : UserControl
    {
       private Korisnik k;
        public LicniPodaci(Korisnik k)
        {
            this.k = k;
            InitializeComponent();
            popuniLabele();
            
        }
        private void popuniLabele()
        {
            lblUsername.Content = k.getUserName();
            lblIme.Content = k.getIme();
            lblPrezime.Content = k.getPrezime();
            lblDatumRodjenja.Content = k.getDatumRodjenja();
            lblPol.Content = k.getPol();

        }
    }
}
