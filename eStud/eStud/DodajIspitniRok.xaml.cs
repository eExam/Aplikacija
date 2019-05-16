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
    /// Interaction logic for DodajIspitniRok.xaml
    /// </summary>
    public partial class DodajIspitniRok : UserControl
    {
        DataGrid mojGrid;
        public DodajIspitniRok(DataGrid mojGrid)
        {
            InitializeComponent();
            this.mojGrid = mojGrid;
        }
        private void popuniTabelu()
        {
            DataTable rezultati = DBController.PrikaziIspitniRok();
           rezultati.Columns["Naziv_roka"].ColumnName = "Ispitni rok";
            // rezultati.Columns["Redovan/Vanredan"].ColumnName = "Tip";
            rezultati.Columns["Pocetak_roka"].ColumnName = "Pocetak roka";
            rezultati.Columns["Kraj_roka"].ColumnName = "Kraj roka";
            rezultati.Columns["Max_brPrijava"].ColumnName = "Maksimalno";
            rezultati.Columns["Cena_prijave"].ColumnName = "Cena prijave";

            mojGrid.ItemsSource = rezultati.DefaultView;
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
            catch (Exception ex)
            {
                MessageBox.Show("Probajte ponovo");
            }
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OcistiPolja();
        }

        private void txtMax_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            foreach (var ch in e.Text)
            {
                if (!((Char.IsDigit(ch))&& ch.Equals('=')))
                {
                    e.Handled = true;

                    break;
                }
            }
        }

        private void txtCena_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            foreach (var ch in e.Text)
            {
                if (!((Char.IsDigit(ch)) && ch.Equals('=')))
                {
                    e.Handled = true;

                    break;
                }
            }
        }

        private void txtIspitniRok_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            foreach (var ch in e.Text)
            {
                if (!((Char.IsLetter(ch)) && ch.Equals('=')))
                {
                    e.Handled = true;

                    break;
                }
            }
        }

        private void txtPocetak_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            foreach (var ch in e.Text)
            {
                if (!((Char.IsDigit(ch)) && ch.Equals('=')))
                {
                    e.Handled = true;

                    break;
                }
            }
        }

        private void txtKraj_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            foreach (var ch in e.Text)
            {
                if (!((Char.IsDigit(ch)) && ch.Equals('=')))
                {
                    e.Handled = true;

                    break;
                }
            }
        }
    }
}
