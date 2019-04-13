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
        private Student k;
        public LicniPodaci(Korisnik k)
        {
            this.k = new Student(k);
            InitializeComponent();
            
            popuniLabele();
        
        }
        private void popuniLabele()
        {
            Username.Content = k.getUserName();
            Ime.Content = k.getIme();
            Prezime.Content = k.getPrezime();
            DatumRodjenja.Content = k.getDatumRodjenja();
            Pol.Content = k.getPol();
            Depatman.Content = DBController.getDepartman(k.getUserName());
            Smer.Content = DBController.getSmer(k.getUserName());
            Semestar.Content = DBController.getSemestar(k.getUserName());
            Indeks.Content = DBController.getBrIndeksa(k.getUserName());
            Grad.Content = k.getGrad();
            Adresa.Content = k.getAdresa();
            GodinaUpisa.Content = DBController.getGodinaUpisa(k.getUserName());

        }
    }
}
