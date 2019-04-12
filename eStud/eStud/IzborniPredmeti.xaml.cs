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
    /// Interaction logic for IzborniPredmeti.xaml
    /// </summary>
    public partial class IzborniPredmeti : UserControl
    {
        Student trenutniKorisnik;
        public DataTable rezultati;
        public IzborniPredmeti(Student tk)
        {
            trenutniKorisnik = tk;
            InitializeComponent();
            popuniIzbornePredmete();
        }
        public void popuniIzbornePredmete()
        {
           rezultati = DBController.StudentIzborniPredmeti(trenutniKorisnik.getUserName());

            rezultati.Columns["Naziv_predmeta"].ColumnName = "Predmet";
            rezultati.Columns["Studijski_program"].ColumnName = "Studijski program";

            tabelaIzborniPredmeti.ItemsSource = rezultati.DefaultView;
           
            

        }

        private void Izaberi_Click(object sender, RoutedEventArgs e)
        {
           
                string prof = "edin";
            tabelaIzborniPredmeti.CanUserDeleteRows = true;
            DataRowView row = (DataRowView)tabelaIzborniPredmeti.SelectedItems[0];
                DBController.StudentDodajIzborniPredmet(row["Predmet"].ToString(), row["Departman"].ToString(), row["Studijski program"].ToString(), prof, int.Parse(row["Semestar"].ToString()), int.Parse(row["ESPB"].ToString()));
                DBController.StudentIzabrao(trenutniKorisnik.getUserName(), row["Predmet"].ToString());
            DBController.StudentIzbrisiIzborniPredmet(row["Predmet"].ToString());
           rezultati.Rows.Remove(row.Row);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataRowView row = (DataRowView)tabelaIzborniPredmeti.SelectedItems[0];
            DBController.StudentIzabrao(trenutniKorisnik.getUserName(),row["Predmet"].ToString());
        }
    }
}
