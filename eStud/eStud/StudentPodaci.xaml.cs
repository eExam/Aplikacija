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
    /// Interaction logic for StudentPodaci.xaml
    /// </summary>
    public partial class StudentPodaci : UserControl
    {
        public DataTable rezultati;
        public StudentPodaci()
        {
            InitializeComponent();
            popuniTabelu();
        }
        public void popuniTabelu()
        {
            rezultati = new DBController().PodaciStudent();
            TabelaStudenti.ItemsSource = rezultati.DefaultView;
        }

        private void btnDodajStud_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnIzbrisi_Click(object sender, RoutedEventArgs e)
        {
            TabelaStudenti.CanUserDeleteRows = true;
            DataRowView row = (DataRowView)TabelaStudenti.SelectedItems[0];
            DBController.izbrisiKorisnika(row["username"].ToString());
            rezultati.Rows.Remove(row.Row);
        }
        private void btnIzmeni_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
