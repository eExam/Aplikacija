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
    /// Interaction logic for StudentPrijavljeniIspit.xaml
    /// </summary>
    public partial class StudentPrijavljeniIspit : UserControl
    {
        private Korisnik k;
        public StudentPrijavljeniIspit(Korisnik k)
        {
            this.k = k;
            InitializeComponent();
            popuniTabelu();
            popuniTabeluNeprijavljeni();
        }
        private void popuniTabelu()
        {
            DataTable rezultati =DBController.StudentPrijavljeniIspiti(k.getUserName());
            rezultati.Columns["Naziv_predmeta"].ColumnName = "Predmet";
            rezultati.Columns["ime"].ColumnName = "Ime";
            rezultati.Columns["prezime"].ColumnName = "Prezime";
            rezultati.Columns["broj_prijava"].ColumnName = "Broj Prijave";
            DataGridTextColumn dt = new DataGridTextColumn();
           
            
    

            TabelaPrijavljeniIspiti.ItemsSource = rezultati.DefaultView;
        }
        private void popuniTabeluNeprijavljeni()
        {
            DataTable rezultati = DBController.StudentNeprijavljeniIspiti(k.getUserName());
            rezultati.Columns["Naziv_predmeta"].ColumnName = "Predmet";
            rezultati.Columns["ime"].ColumnName = "Ime";
            rezultati.Columns["prezime"].ColumnName = "Prezime";
            rezultati.Columns["broj_prijava"].ColumnName = "Broj Prijave";
            tabelaNeprijavljeniIspiti.ItemsSource = rezultati.DefaultView;
        }

        private void TabelaPrijavljeniIspiti_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TabelaPrijavljeniIspiti.IsReadOnly = true;
        }

        private void tabelaNeprijavljeniIspiti_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tabelaNeprijavljeniIspiti.IsReadOnly = true;
        }
    }
}
