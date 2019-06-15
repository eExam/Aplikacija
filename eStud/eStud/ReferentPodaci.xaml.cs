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
using eStud.Model;
using System.Data.OleDb;


namespace eStud
{
    /// <summary>
    /// Interaction logic for ReferentPodaci.xaml
    /// </summary>
    public partial class ReferentPodaci : UserControl
    {
        public DataTable rezultati;
        
        //private DBController db=new DBController();
        public ReferentPodaci()
        {
            InitializeComponent();
            PopuniTabelu();
            pnlRight_Copy.Children.Clear();
            DodajReferenta df = new DodajReferenta(TabelaReferenti);
            pnlRight_Copy.Children.Add(df);


        }
       
        private void PopuniTabelu()
        {
            rezultati = DBController.PodaciReferent();
            rezultati.Columns["studijski_program"].ColumnName = "Studijski program";
            rezultati.Columns["departman"].ColumnName = "Departman";
            rezultati.Columns["pol"].ColumnName = "Pol";
            rezultati.Columns["prezime"].ColumnName = "Prezime";
            rezultati.Columns["ime"].ColumnName = "Ime";
            rezultati.Columns["username"].ColumnName = "Korisničko ime";
            rezultati.Columns["datum_rodjenja"].ColumnName = "Datum rođenja";
            TabelaReferenti.ItemsSource = rezultati.DefaultView;
        
            
            
        }
        

        private void btnIzbrisi_Click(object sender, RoutedEventArgs e)
        {


            try
            {
                MessageBoxResult result = MessageBox.Show("Da li ste sigurni", "Confirmation", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    //TabelaReferenti.SelectedItem;
                    TabelaReferenti.CanUserDeleteRows = true;
                    
                    DataRowView row = (DataRowView)TabelaReferenti.SelectedItems[0];
                    DBController.izbrisiKorisnika(row["Korisničko ime"].ToString());
                    rezultati.Rows.Remove(row.Row);
                    //  MessageBox.Show(TabelaReferenti.SelectedItem.ToString());
                    //PopuniTabelu();
                }
            }
            catch (Exception ex)
            {
               
            }
        }
       

        

        private void btnIzmeni_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView row = (DataRowView)TabelaReferenti.SelectedItems[0];
                pnlRight.Children.Clear();
                ReferentIzmeniPodatke rp = new ReferentIzmeniPodatke(row, TabelaReferenti);
                pnlRight.Children.Add(rp);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Niste izabrali");
            }
        }

      
       

        private void TabelaReferenti_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TabelaReferenti.IsReadOnly = true;
        }

        private void btnPromena_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView row = (DataRowView)TabelaReferenti.SelectedItems[0];
                pnlRight.Children.Clear();
                ReferentIzmeniPodatke rp = new ReferentIzmeniPodatke(row, TabelaReferenti);
                pnlRight.Children.Add(rp);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        private void searchData(string valueToFind)
        {
            DataTable dt = DBController.pretragaReferenta(valueToFind);
            dt.Columns["studijski_program"].ColumnName = "Studijski program";
            dt.Columns["departman"].ColumnName = "Departman";
            dt.Columns["pol"].ColumnName = "Pol";
            dt.Columns["prezime"].ColumnName = "Prezime";
            dt.Columns["ime"].ColumnName = "Ime";
            dt.Columns["username"].ColumnName = "Korisničko ime";
            dt.Columns["datum_rodjenja"].ColumnName = "Datum rođenja";
           // TabelaReferenti.ItemsSource = rezultati.DefaultView;
            TabelaReferenti.ItemsSource = dt.DefaultView;
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
