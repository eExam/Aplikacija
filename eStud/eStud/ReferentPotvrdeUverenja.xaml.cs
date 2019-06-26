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
            rezultati.Columns["username"].ColumnName ="Korisničko ime";
           rezultati.Columns["razlog"].ColumnName ="Tip dokumenta";
            rezultati.Columns["obrazlozenje"].ColumnName ="Obrazloženje";
            rezultati.Columns["ime"].ColumnName = "Ime";
            tabelaMolbe.ItemsSource = rezultati.DefaultView;
            }

        private void btnOdobri_Click(object sender, RoutedEventArgs e)
        {
            tabelaMolbe.CanUserDeleteRows = true;

           
                DataRowView row1 = (DataRowView)tabelaMolbe.SelectedItems[0];
                DBController.OdobriMolbe(row1["Korisničko ime"].ToString(), row1["Tip dokumenta"].ToString());
                MessageBox.Show("Zahtev je odobren");
                popuniTabelu2();
            
            
            row1.Row.Delete();
            DBController.izbrisiZahtev(int.Parse(row1["ID"].ToString()));
        }
        private void popuniTabelu2()
        {
            rezultati1 = DBController.prikaziOdobreneMolbe();
            rezultati1.Columns["username"].ColumnName = "Korisničko ime";
            rezultati1.Columns["tip_dokumenta"].ColumnName = "Tip dokumenta";
            rezultati1.Columns["ime"].ColumnName = "Ime";
            tabelaOdobrene.ItemsSource = rezultati1.DefaultView;
        }

        private void btnStampaj_Click(object sender, RoutedEventArgs e)
        {
            rezultati=DBController.PrikaziMolbe();
           // string file = @"test.pdf"; // nalazi se u bin\Debug
            DataRowView row = izabrani();
            //  string tip;
            
                if (row["Tip dokumenta"].ToString() == "Potvrda o studiranju")
                {
                    stampajPotvrduStudiranje(row);
                }
                else
                {
                    StampajPolozeneIspite(row);
                }
            }
           
        private void stampajPotvrduStudiranje(DataRowView row)
        {
            string file = @"test.pdf"; // nalazi se u bin\Debug
            //DataRowView row = izabrani();
            //  string tip;
           
            using (var doc = new PdfWrapper(file))
            {

                doc.DodajNaslov("Drzavni univerzitet u Novom Pazaru", 14);
                //doc.DodajParagraf("ovo je uvod");
                doc.DodajParagraf("Student " + row["Ime"].ToString() + " " + row["prezime"].ToString() + ", broj indeksa " + Tabela(row) + ", podneo je zahtev, na osnovu clana 171. Zakona o opstem upravnom postupku izdaje se");


                doc.DodajNaslov(row["Tip dokumenta"].ToString());

                doc.DodajParagraf("Student " + row["Ime"].ToString() + " " + row["Prezime"].ToString() + " ,upisan je kao redovni student na Drzavni univerzitet u Novom Pazaru, departman za " + getDepartman(row));
                doc.DodajParagraf("Potvrda koja se izdaje sluzi za korisnicko uputstvo i u druge svrhe se ne moze upotrebljavati");
                doc.DodajMPiPotpis();
            }

            PdfWrapper.OtvoriFile(file);
        }
        private void StampajPolozeneIspite(DataRowView row)
        {
            string file = @"test.pdf"; // nalazi se u bin\Debug
                                       //DataRowView row = izabrani();
                                       //  string tip;
            DataTable polozeni = new DataTable();

            polozeni = DBController.StudentPolozeniIspiti(Username(row));
            using (var doc = new PdfWrapper(file))
            {

                doc.DodajNaslov("Drzavni univerzitet u Novom Pazaru", 14);
                //doc.DodajParagraf("ovo je uvod");
                doc.DodajParagraf("Student " + row["Ime"].ToString() + " " + row["prezime"].ToString() + ", broj indeksa " + Tabela(row) + ", podneo je zahtev, na osnovu clana 171. Zakona o opstem upravnom postupku izdaje se");


                doc.DodajNaslov(row["Tip_dokumenta"].ToString());
              
                doc.DodajParagraf("Student " + row["Ime"].ToString() + " " + row["Prezime"].ToString() + " ,upisan je kao redovni student na Drzavni univerzitet u Novom Pazaru, departman za " + getDepartman(row)+"polozio je sledece ispite");
                doc.DodajParagraf("Potvrda koja se izdaje sluzi za korisnicko uputstvo i u druge svrhe se ne moze upotrebljavati");
                doc.DodajTabelu(polozeni);
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
           
            string brojIndeksa=DBController.getBrIndeksa(row["Korisničko ime"].ToString());

            return brojIndeksa;
        }
        private string getDepartman(DataRowView row)
        {
            string departman = DBController.getDepartman(row["Korisničko ime"].ToString());
            return departman;
        }
        private string Username(DataRowView row)
        {
            string username = row["Korisničko ime"].ToString();
            return username;
        }

        private void tabelaMolbe_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tabelaMolbe.IsReadOnly = true;
        }

        private void tabelaOdobrene_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tabelaOdobrene.IsReadOnly = true;
        }
    }
}
