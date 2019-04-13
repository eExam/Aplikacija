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
    /// Interaction logic for ReferentIzmeniPodatke.xaml
    /// </summary>
    public partial class ReferentIzmeniPodatke : UserControl
    {
        DataRowView row;
        DataGrid mojGrid;
        public ReferentIzmeniPodatke(DataRowView row,DataGrid mojGrid)
        {
            InitializeComponent();
            this.row = row;
            this.mojGrid = mojGrid;
            popuniText();
        }
        private void popuniText()
        {
            DataRowView row = (DataRowView)mojGrid.SelectedItems[0];

            txtIme.Text = (row["Ime"].ToString());
           txtDepartman.Text = (row["Departman"].ToString());
            txtDatumRodj.Text = row["Datum rodjenja"].ToString();
            txtPrezime.Text = row["Prezime"].ToString();
            txtPol.Text = (row["Pol"].ToString());
            txtStudijskiProgram.Text = row["Studijski program"].ToString();
            txtUsername.Text = row["Username"].ToString();
            txtGrad.Text = row["Grad"].ToString();
            txtAdresa.Text = row["Adresa"].ToString();
        }
        

        private void btnSacuvaj_Click(object sender, RoutedEventArgs e)
        {


            DBController.IzmeniRef(txtUsername.Text, txtIme.Text, txtPrezime.Text, txtDatumRodj.Text, txtPol.Text, txtDepartman.Text, txtStudijskiProgram.Text,txtGrad.Text,txtAdresa.Text);
          
           
            DataTable rezultati = DBController.PodaciReferent();
            rezultati.Columns["studijski_program"].ColumnName = "Studijski program";
            rezultati.Columns["departman"].ColumnName = "Departman";
            rezultati.Columns["pol"].ColumnName = "Pol";
            rezultati.Columns["prezime"].ColumnName = "Prezime";
            rezultati.Columns["ime"].ColumnName = "Ime";
            rezultati.Columns["username"].ColumnName = "Username";
            rezultati.Columns["datum_rodjenja"].ColumnName = "Datum rodjenja";

            mojGrid.ItemsSource = rezultati.DefaultView;
        }
    }
}
