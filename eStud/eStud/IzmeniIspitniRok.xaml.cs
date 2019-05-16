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
    /// Interaction logic for IzmeniIspitniRok.xaml
    /// </summary>
    public partial class IzmeniIspitniRok : UserControl
    {
        DataRowView row;
        DataGrid mojGrid;
        public IzmeniIspitniRok(DataGrid mojGrid,DataRowView row)
        {
            InitializeComponent();
            this.row = row;
            this.mojGrid = mojGrid;
            popuni();
        }
        private void popuni()
        {
            txtIspitniRok.Text = (row["Ispitni rok"].ToString());
            txtTip.Text = row["Tip"].ToString();
            txtPocetak.Text = row["Pocetak roka"].ToString();
            txtKraj.Text = row["Kraj roka"].ToString();
            txtCena.Text = (row["Cena prijave"].ToString());
            txtMax.Text = row["Maksimalno"].ToString();
        }
        private void btnSacuvaj_Click(object sender, RoutedEventArgs e)
        {

            if (PraznaPolja() == true)
            {
                MessageBox.Show("Niste popunili sva polja");
            }
            
            else
            {

                DBController.IzmeniRok(txtIspitniRok.Text, txtTip.Text, txtPocetak.Text, txtKraj.Text, int.Parse(txtMax.Text), int.Parse(txtCena.Text));
                DataTable rezultati = DBController.PrikaziIspitniRok();
                rezultati.Columns["Naziv_roka"].ColumnName = "Ispitni rok";
                //rezultati.Columns["Redovan/Vanredan"].ColumnName = "Tip";
                rezultati.Columns["Pocetak_roka"].ColumnName = "Pocetak roka";
                rezultati.Columns["Kraj_roka"].ColumnName = "Kraj roka";
                rezultati.Columns["Max_brPrijava"].ColumnName = "Maksimalno";
                rezultati.Columns["Cena_prijave"].ColumnName = "Cena prijave";


                mojGrid.ItemsSource = rezultati.DefaultView;
            }
        }

        private void btnOtkazi_Click(object sender, RoutedEventArgs e)
        {
            txtIspitniRok.Text = "";
            txtTip.Text = "";
            txtPocetak.Text = "";
            txtKraj.Text = "";
            txtCena.Text = "";
            txtMax.Text = "";
        }
        private bool PraznaPolja()
        {
            return txtIspitniRok.Text == "" ||
            txtTip.Text == "" ||
            txtPocetak.Text == "" ||
            txtKraj.Text == "" ||
            txtCena.Text == "" ||
            txtMax.Text == "";

        }

        private void txtMax_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            foreach (var ch in e.Text)
            {
                if (!((Char.IsDigit(ch)) )|| ch.Equals('=')) {
                    e.Handled = true;

                    break;
                }
            }
        }

        private void txtCena_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            foreach (var ch in e.Text)
            {
                if (!((Char.IsDigit(ch)) ) || ch.Equals('='))
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
                if (!((Char.IsDigit(ch))) || ch.Equals('=') )
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
                if (!((Char.IsDigit(ch)) ) || ch.Equals('='))
                {
                    e.Handled = true;

                    break;
                }
            }
        }
    }
}
