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
            tabelaZahteva.ItemsSource = rezultati.DefaultView;
        }

        private void btnOdobri_Click(object sender, RoutedEventArgs e)
        {
            tabelaZahteva.CanUserDeleteRows = true;
            DataRowView row = (DataRowView)tabelaZahteva.SelectedItems[0];
            DBController.OdobriPrijavuIspita(row["username_stud"].ToString(), 2, row["sifra_predmeta"].ToString());
            rezultati.Rows.Remove(row.Row);
        }

        private void btnOdbij_Click(object sender, RoutedEventArgs e)
        {
            tabelaZahteva.CanUserDeleteRows = true;
            DataRowView row = (DataRowView)tabelaZahteva.SelectedItems[0];
            DBController.OdbijPrijavuIspita(row["username_stud"].ToString(), 2, row["sifra_predmeta"].ToString());
            rezultati.Rows.Remove(row.Row);
        }

        
    }
}
