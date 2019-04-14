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
        bool state = false;
        public StudentPodaci()
        {
            InitializeComponent();
            popuniTabelu();
            pnlDodajStud_Copy.Children.Clear();
            DodajStudenta df = new DodajStudenta(TabelaStudenti);
            pnlDodajStud_Copy.Children.Add(df);
        }
        public void popuniTabelu()
        {
            rezultati = DBController.PodaciStudent();
           
            TabelaStudenti.ItemsSource = rezultati.DefaultView;
        }

        
        private void btnIzbrisi_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TabelaStudenti.CanUserDeleteRows = true;
                DataRowView row = (DataRowView)TabelaStudenti.SelectedItems[0];
                DBController.izbrisiKorisnika(row["username"].ToString());
                rezultati.Rows.Remove(row.Row);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        private void btnIzmeni_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView row = (DataRowView)TabelaStudenti.SelectedItems[0];
                pnlDodajStud.Children.Clear();
                StudentIzmeniPodaci rp = new StudentIzmeniPodaci(row, TabelaStudenti);
                pnlDodajStud.Children.Add(rp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Niste izabrali");
            }
        }

        private void btnIzmeni_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView row = (DataRowView)TabelaStudenti.SelectedItems[0];
                pnlDodajStud.Children.Clear();
                StudentIzmeniPodaci rp = new StudentIzmeniPodaci(row, TabelaStudenti);
                pnlDodajStud.Children.Add(rp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Niste izabrali");
            }
        }
    }
}
