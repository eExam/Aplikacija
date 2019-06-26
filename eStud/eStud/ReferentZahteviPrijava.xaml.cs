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
    /// Interaction logic for ReferentZahteviPrijava.xaml
    /// </summary>
    public partial class ReferentZahteviPrijava : UserControl
    {
        public DataTable rezultati;
        public ReferentZahteviPrijava()
        {
            InitializeComponent();
            popuniTabelu();
        }
        public void popuniTabelu()
        {
            rezultati = DBController.ReferentZahteviPrijava();
            rezultati.Columns["ime"].ColumnName = "Ime";
            rezultati.Columns["prezime"].ColumnName = "Prezime";
            rezultati.Columns["Naziv_predmeta"].ColumnName = "Predmet";
            rezultati.Columns["imeprof"].ColumnName = "Ime profesora";
            rezultati.Columns["prezimeprof"].ColumnName = "Prezime profesora";
            rezultati.Columns["ispitni_rok"].ColumnName = "Ispitni rok";
            rezultati.Columns["brPrijave"].ColumnName = "Broj prijave";
            
            rezultati.Columns["username"].ColumnName = "Korisničko ime";
            tabelaZahteva.ItemsSource = rezultati.DefaultView;
        }

        private void btnOdobri_Click(object sender, RoutedEventArgs e)
        {
            tabelaZahteva.CanUserDeleteRows = true;
            DataRowView row = (DataRowView)tabelaZahteva.SelectedItems[0];
            int prijava = int.Parse(row["Broj prijave"].ToString());
           // MessageBox.Show(prijava.ToString());
          
            bool prijavljeni = DBController.DaLiJePrijavljenIspit(row["Predmet"].ToString(), row["Korisničko ime"].ToString(), prijava);
            if (prijavljeni==true)
            {
                MessageBox.Show("Vec ste odobrili zahtev");
            }
            else if(prijavljeni !=true)
            {


                //    MessageBox.Show(row["Broj prijave"].ToString());
                 DBController.OdobriPrijavuIspita(row["Korisničko ime"].ToString(), int.Parse(row["Broj prijave"].ToString()), row["Predmet"].ToString());
                MessageBox.Show("Zahtev je odobren");
            }
        }

        private void btnOdbij_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tabelaZahteva.CanUserDeleteRows = true;
                DataRowView row = (DataRowView)tabelaZahteva.SelectedItems[0];
                //    DBController.getBrojPrijave(row["Predmet"].ToString(), row["Korisničko ime"].ToString());
                DBController.OdbijPrijavuIspita(row["Korisničko ime"].ToString(), int.Parse(row["Broj prijave"].ToString()), row["Predmet"].ToString());
                MessageBox.Show("Zahtev je odbijen");
                DBController.IzbrisiZahtevZaIspit(int.Parse(row["ID"].ToString()));
                row.Row.Delete();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Niste odbili");
            }

        }

        private void tabelaZahteva_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tabelaZahteva.IsReadOnly = true;
        }
    }
}
