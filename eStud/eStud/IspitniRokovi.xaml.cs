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
            this.pnlDodaj.Children.Clear();
            DodajIspitniRok dt = new DodajIspitniRok(tabelaIspitniRokovi);
            this.pnlDodaj.Children.Add(dt);

        }
        private void popuniTabelu()
        {
            rezultati=DBController.PrikaziIspitniRok();
            rezultati.Columns["Naziv_roka"].ColumnName = "Ispitni rok";
           // rezultati.Columns["Redovan/Vanredan"].ColumnName = "Tip";
            rezultati.Columns["Pocetak_roka"].ColumnName = "Pocetak roka";
            rezultati.Columns["Kraj_roka"].ColumnName = "Kraj roka";
            rezultati.Columns["Max_brPrijava"].ColumnName = "Maksimalno";
            rezultati.Columns["Cena_prijave"].ColumnName = "Cena prijave";

            tabelaIspitniRokovi.ItemsSource = rezultati.DefaultView;

        }

        

        private void btnIzbrisi_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tabelaIspitniRokovi.CanUserDeleteRows = true;
                DataRowView row = (DataRowView)tabelaIspitniRokovi.SelectedItems[0];
                DBController.IzbrisiIspitniRok(row["Ispitni rok"].ToString());
                rezultati.Rows.Remove(row.Row);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Niste izabrali");
            }
        }

        private void btnIzmeni_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView row = (DataRowView)tabelaIspitniRokovi.SelectedItems[0];
                this.pnlIzmeniRok.Children.Clear();
                IzmeniIspitniRok ir = new IzmeniIspitniRok(tabelaIspitniRokovi, row);
                pnlIzmeniRok.Children.Add(ir);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Niste izabrali");
            }
        }
       

        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            
            this.pnlDodaj.Children.Clear();
            DodajIspitniRok dt = new DodajIspitniRok(tabelaIspitniRokovi);
            this.pnlDodaj.Children.Add(dt);
        }

        private void tabelaIspitniRokovi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tabelaIspitniRokovi.IsReadOnly = true;
        }

    }
}
