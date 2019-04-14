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
    /// Interaction logic for PocetnaReferent.xaml
    /// </summary>
    public partial class PocetnaReferent : UserControl
    {
        public PocetnaReferent()
        {
            InitializeComponent();
            popuniTabelu();
            popuniTabelu1();
        }

       public void popuniTabelu()
        {
            DataTable rezultati = new DataTable();
            rezultati = DBController.ReferentZahteviPrijava();
            rezultati.Columns["ime"].ColumnName = "Ime";
            rezultati.Columns["prezime"].ColumnName = "Prezime";
            rezultati.Columns["Naziv_predmeta"].ColumnName = "Predmet";
            rezultati.Columns["imeprof"].ColumnName = "Ime profesora";
            rezultati.Columns["prezimeprof"].ColumnName = "Prezime profesora";
            rezultati.Columns["ispitni_rok"].ColumnName = "Ispitni rok";
            tabelaPrijaveIspita.ItemsSource = rezultati.DefaultView;
        }
        public void popuniTabelu1()
        {
            DataTable rez = new DataTable();
            rez = DBController.PrikaziMolbe();
            tabelaMolbe.ItemsSource = rez.DefaultView;
        }

        private void btnPrikaziVise_Click(object sender, RoutedEventArgs e)
        {
            GlavniPanel.Children.Clear();
            ReferentZahteviPrijava r = new ReferentZahteviPrijava();
            GlavniPanel.Children.Add(r);
        }

        private void btnPrikaziVise1_Click(object sender, RoutedEventArgs e)
        {
            GlavniPanel.Children.Clear();
            ReferentPotvrdeUverenja r = new ReferentPotvrdeUverenja();
            GlavniPanel.Children.Add(r);
        }
    }
}
