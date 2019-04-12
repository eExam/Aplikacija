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
    /// Interaction logic for IspitniRokovi.xaml
    /// </summary>
    public partial class IspitniRokovi : UserControl
    {
        public DataTable rezultati;

        public IspitniRokovi()
        {
            InitializeComponent();

            popuniTabelu();
            
        }
        private void popuniTabelu()
        {
            rezultati=DBController.PrikaziIspitniRok();
            tabelaIspitniRokovi.ItemsSource = rezultati.DefaultView;

        }

        private void btnSacuvaj_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                DBController.DodajIspitniRok(txtIspitniRok.Text, txtTip.Text, txtPocetak.Text, txtKraj.Text, int.Parse(txtMax.Text), int.Parse(txtCena.Text));
                MessageBox.Show("Dodali ste ispitni rok");
                popuniTabelu();
                OcistiPolja();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Probajte ponovo");
            }

           

        }

        private void btnIzbrisi_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tabelaIspitniRokovi.CanUserDeleteRows = true;
                DataRowView row = (DataRowView)tabelaIspitniRokovi.SelectedItems[0];
                DBController.IzbrisiIspitniRok(row["Naziv_roka"].ToString());
                rezultati.Rows.Remove(row.Row);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Niste izabrali");
            }
        }

        private void btnIzmeni_Click(object sender, RoutedEventArgs e)
        {
            DataRowView row = (DataRowView)tabelaIspitniRokovi.SelectedItems[0];
           
            txtIspitniRok.Text=(row["Naziv_roka"].ToString());
            txtTip.Text = row["Tip"].ToString();
            txtPocetak.Text = row["Pocetak_roka"].ToString();
            txtKraj.Text = row["Kraj_roka"].ToString();
            txtCena.Text =(row["Cena_prijave"].ToString());
            txtMax.Text = row["Max_brPrijava"].ToString();
          

        }
        private void OcistiPolja()
        {
            txtIspitniRok.Text = "";
            txtTip.Text = "";
            txtPocetak.Text = "";
            txtKraj.Text = "";
            txtMax.Text = "";
            txtCena.Text = "";
        }
    }
}
