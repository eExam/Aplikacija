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
    /// Interaction logic for ReferentPotvrdeUverenja.xaml
    /// </summary>
    public partial class ReferentPotvrdeUverenja : UserControl
    {
        DataTable rezultati;
        DataTable rezultati1;
        
        public ReferentPotvrdeUverenja()
        {
            InitializeComponent();
            popuniTabelu();
            popuniTabelu2();
        }
        private void popuniTabelu ()
            {
            rezultati = DBController.PrikaziMolbe();
            tabelaMolbe.ItemsSource = rezultati.DefaultView;
            }

        private void btnOdobri_Click(object sender, RoutedEventArgs e)
        {
            DBController.OdobriMolbe(rezultati.Rows[0][0].ToString(), rezultati.Rows[0][3].ToString());
            MessageBox.Show("Zahtev je odobren");
        }
        private void popuniTabelu2()
        {
            rezultati1 = DBController.prikaziOdobreneMolbe();
            tabelaOdobrene.ItemsSource = rezultati1.DefaultView;
        }

        private void btnStampaj_Click(object sender, RoutedEventArgs e)
        {
            //rezultati=DBController.PrikaziMolbe();
            string file = @"test.pdf"; // nalazi se u bin\Debug
            DataRowView row = izabrani();
            using (var doc = new PdfWrapper(file))
            {
               
                doc.DodajNaslov("Ovo je naslov", 14);
                doc.DodajParagraf("ovo je uvod");
                
                doc.DodajNaslov("Potvrda o studiranju"+row["Ime"].ToString()+" "+row["prezime"].ToString()+"broj indeksa"+Tabela(row));
               
                doc.DodajParagraf($"Potvrda koja se izdaje služi za i u druge svrhe se ne može upotrebljavati.");
                doc.DodajParagraf("Dodatak");
                doc.DodajMPiPotpis();
            }

            PdfWrapper.OtvoriFile(file);
        }
        private DataRowView izabrani()
        {
            DataRowView row = (DataRowView)tabelaOdobrene.SelectedItems[0];
            return row;
        }
        private string Tabela(DataRowView row)
        {
           
            string brojIndeksa=DBController.getBrIndeksa(row["username"].ToString());

            return brojIndeksa;
        }
    }
}
