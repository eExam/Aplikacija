using eStud.Model;
using iText7Wrapper;
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
    /// Interaction logic for ReferentPrijavljeniIspiti.xaml
    /// </summary>
    public partial class ReferentPrijavljeniIspiti : UserControl
    {
        DataTable rezultati;
        public ReferentPrijavljeniIspiti()
        {
            InitializeComponent();
            popuniTabelu();
        }
        private void popuniTabelu()
        {
           
            rezultati=DBController.ReferentPrijavljeniIspiti();
            rezultati.Columns["ime"].ColumnName = "Ime";
            rezultati.Columns["prezime"].ColumnName = "Prezime";
            rezultati.Columns["Naziv_predmeta"].ColumnName = "Predmet";
            rezultati.Columns["imeprof"].ColumnName = "Ime profesora";
            rezultati.Columns["prezimeprof"].ColumnName = "Prezime profesora";
          //  rezultati.Columns["ispitni_rok"].ColumnName = "Ispitni rok";
            rezultati.Columns["broj_prijava"].ColumnName = "Broj prijave";
            tabelaPrijavljeniIspiti.ItemsSource = rezultati.DefaultView;
        }

        private void btnPrijavnica_Click(object sender, RoutedEventArgs e)
        {
            string file = @"test.pdf";
            using (var doc = new PdfWrapper(file))
            {
                doc.DodajNaslov("Prijavnice", 14);

                doc.DodajTabelu(rezultati);
               
                doc.DodajMPiPotpis();
                doc.DodajTabelu(rezultati);
                doc.DodajMPiPotpis();
            }
            PdfWrapper.OtvoriFile(file);

        }

        private void tabelaPrijavljeniIspiti_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tabelaPrijavljeniIspiti.IsReadOnly = true;
        }
    }
}
