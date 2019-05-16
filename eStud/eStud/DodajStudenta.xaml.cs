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
    /// Interaction logic for DodajStudenta.xaml
    /// </summary>
    public partial class DodajStudenta : UserControl
    {
        DataGrid mojGrid;
        public DodajStudenta(DataGrid tabelaStudenti)
        {
            InitializeComponent();
            mojGrid = tabelaStudenti;
        }

        private void txtSacuvaj_Click(object sender, RoutedEventArgs e)
        {
            SacuvajPodatke();
            DataTable rezultati = DBController.PodaciStudent();
            rezultati.Columns["studijski_program"].ColumnName = "Studijski program";
            rezultati.Columns["departman"].ColumnName = "Departman";
            rezultati.Columns["pol"].ColumnName = "Pol";
            rezultati.Columns["prezime"].ColumnName = "Prezime";
            rezultati.Columns["ime"].ColumnName = "Ime";
            rezultati.Columns["username"].ColumnName = "Username";
            rezultati.Columns["datum_rodjenja"].ColumnName = "Datum rodjenja";
           // rezultati.Columns["broj_indeksa"].ColumnName = "Broj indeksa";
           

            mojGrid.ItemsSource = rezultati.DefaultView;
        }
        private void SacuvajPodatke()
        {
            try
            {
                /*if (ImaPraznoPolje())
                  throw new Exception("Popunite sva polja!");
                if (DBController.ImaUBazi(txtUsername.Text, txtPassword.Text) != null)
                    throw new Exception("Korisnicko ime je zauzeto");*/

                if (!ImaPraznoPolje())
                {
                    if (DBController.ZauzetoKorisnicko(txtUsername.Text) == true)
                    {
                        MessageBox.Show("Korisnicko ime je zauzeto");
                    }
                    else
                    {
                        DBController.UbaciUBazi(this.txtUsername.Text, this.txtPassword.Text, this.txtUsertype.Text, this.txtIme.Text, this.txtPrezime.Text, this.txtDatumRodj.Text, this.txtPol.Text, this.txtGrad.Text, this.txtAdresa.Text);
                        DBController.DodajStud(this.txtUsername.Text, txtDepartman.Text, txtStudijskiProgram.Text, int.Parse(txtSemestar.Text), txtBrojIndeksa.Text, txtStatus.Text, txtGodinaUpisa.Text);
                        MessageBox.Show("Uspesno ste dodali Korisnika");
                    }
                }
                else
                {
                    MessageBox.Show("Niste popunili sva polja");
                }

            }
            catch (Exception ex)
            {
                if (DBController.ZauzetoKorisnicko(txtUsername.Text) == true)
                    MessageBox.Show("Korisnicko ime je zauzeto");
                if (ImaPraznoPolje())
                    MessageBox.Show("Niste popunilil sva polja");

            }
        }
            private bool ImaPraznoPolje()
            {
                return txtUsername.Text == ""
                    || txtPassword.Text == ""
                    || txtUsertype.Text == ""
                    || txtIme.Text == ""
                    || txtPrezime.Text == ""
                    || txtDatumRodj.Text == ""
                    || txtPol.Text == ""
                    || txtDepartman.Text == ""
                    || txtStudijskiProgram.Text == "";
            }
        private void TextHandler(object sender, TextCompositionEventArgs e)
        {
            foreach (var ch in e.Text)
            {
                if (!((Char.IsLetter(ch)) )|| ch.Equals('='))
                {
                    e.Handled = true;

                    break;
                }
            }
        }
    }
    }

