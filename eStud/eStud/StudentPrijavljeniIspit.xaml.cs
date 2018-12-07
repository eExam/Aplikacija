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
    /// Interaction logic for StudentPrijavljeniIspit.xaml
    /// </summary>
    public partial class StudentPrijavljeniIspit : UserControl
    {
        private Korisnik k;
        public StudentPrijavljeniIspit(Korisnik k)
        {
            this.k = k;
            InitializeComponent();
            popuniTabelu();
        }
        private void popuniTabelu()
        {
            DataTable rezultati = new DBController().StudentPrijavljeniIspiti(k.getUserName());
            TabelaPrijavljeniIspiti.ItemsSource = rezultati.DefaultView;
        }
    }
}
