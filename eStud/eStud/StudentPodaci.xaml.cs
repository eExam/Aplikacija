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
            rezultati.Columns["studijski_program"].ColumnName = "Studijski program";
            rezultati.Columns["departman"].ColumnName = "Departman";
            rezultati.Columns["pol"].ColumnName = "Pol";
            rezultati.Columns["prezime"].ColumnName = "Prezime";
            rezultati.Columns["ime"].ColumnName = "Ime";
            rezultati.Columns["username"].ColumnName = "Korisničko ime";
            rezultati.Columns["datum_rodjenja"].ColumnName = "Datum rođenja";
            rezultati.Columns["status"].ColumnName = "Status ";
            rezultati.Columns["godina_upisa"].ColumnName = "Godina upisa";

            TabelaStudenti.ItemsSource = rezultati.DefaultView;
        }

        
        private void btnIzbrisi_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TabelaStudenti.CanUserDeleteRows = true;
                DataRowView row = (DataRowView)TabelaStudenti.SelectedItems[0];
                DBController.izbrisiKorisnika(row["Korisničko ime"].ToString());
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

        private void TabelaStudenti_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TabelaStudenti.IsReadOnly = true;
        }

        private void searchData(string valueToFind)
        {
            DataTable dt = DBController.pretragaStudenata(valueToFind);
            dt.Columns["studijski_program"].ColumnName = "Studijski program";
            dt.Columns["departman"].ColumnName = "Departman";
            dt.Columns["pol"].ColumnName = "Pol";
            dt.Columns["prezime"].ColumnName = "Prezime";
            dt.Columns["ime"].ColumnName = "Ime";
            dt.Columns["username"].ColumnName = "Korisničko ime";
            dt.Columns["datum_rodjenja"].ColumnName = "Datum rođenja";
            dt.Columns["status"].ColumnName = "Status ";
            dt.Columns["godina_upisa"].ColumnName = "Godina upisa";
            TabelaStudenti.ItemsSource = dt.DefaultView;
        }
        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            searchData(txtSearch.Text);
        }

        private void txtSearch_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            foreach (var ch in e.Text)
            {
                if (!((Char.IsLetter(ch))) || ch.Equals('='))
                {
                    e.Handled = true;

                    break;
                }
            }
        }
    }
}
