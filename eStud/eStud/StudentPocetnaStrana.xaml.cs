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
            popuniPredmete();
        }
        private void popuniIspitniRokovi()
        {
            rezultati = DBController.PrikaziIspitniRok();
            lblIspitniRok.Content = rezultati.Rows[0][0].ToString() + " Ispitni Rok";
            lblPocetak.Content = rezultati.Rows[0][2].ToString();
            lblKraj.Content = rezultati.Rows[0][3].ToString();
        }
        private void popuniPredmete()
        {
            rezultati = DBController.StudentPredmeti(trenutniKorisnik.getUserName());
            tabelaPredmeti.ItemsSource = rezultati.DefaultView;
        }
    }
}
