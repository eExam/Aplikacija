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
         
            tabelaZahteva.ItemsSource = rezultati.DefaultView;
        }

        private void btnOdobri_Click(object sender, RoutedEventArgs e)
        {
            tabelaZahteva.CanUserDeleteRows = true;
            DataRowView row = (DataRowView)tabelaZahteva.SelectedItems[0];
            DBController.OdobriPrijavuIspita(row["username"].ToString(), 2, row["Predmet"].ToString());
            rezultati.Rows.Remove(row.Row);
        }

        private void btnOdbij_Click(object sender, RoutedEventArgs e)
        {
            tabelaZahteva.CanUserDeleteRows = true;
            DataRowView row = (DataRowView)tabelaZahteva.SelectedItems[0];
            DBController.OdbijPrijavuIspita(row["username"].ToString(), 2, row["Predmet"].ToString());
            rezultati.Rows.Remove(row.Row);
        }

        
    }
}
