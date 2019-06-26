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
    /// Interaction logic for PrijavniceZaProfesora.xaml
    /// </summary>
    public partial class PrijavniceZaProfesora : UserControl
    {
        DataTable rezultati;
        DataTable rez;
        
        public PrijavniceZaProfesora()
        {
            InitializeComponent();
            popuniPredmete();
        }
        private void popuniPredmete()
        {
            rez = DBController.getPredmeti();
            string[] predmet;

            int broj = rez.Rows.Count;

            predmet = new string[broj];
            for (int i = 0; i < broj; i++)
            {
                predmet[i] = rez.Rows[i][0].ToString();
                txtPredmeti.Items.Add(predmet[i]);

            }
        }
        private DataTable napraviTabelu()
        {
            // pred=DBController.getPredmeti();
            // pred.getNazivPredmeta();
            //MessageBox.Show(pred.getNazivPredmeta());
            
            rezultati = DBController.PrijavniceZaProfesora(txtPredmeti.Text);
            int brojac = rezultati.Rows.Count;
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Studijski program");
            dt.Columns.Add("Ime");
            dt.Columns.Add("Prezime");
            dt.Columns.Add("Broj indeksa");
            dt.Columns.Add("Ocena");
            for(int i=0;i<brojac;i++)
            {
                DataRow _ravi = dt.NewRow();
                _ravi["Studijski program"] = DBController.getSmer(rezultati.Rows[0][0].ToString());
                _ravi["Ime"] = rezultati.Rows[i][1];
                _ravi["Prezime"] = rezultati.Rows[i][2];
                _ravi["Broj indeksa"] = DBController.getBrIndeksa(rezultati.Rows[i][0].ToString());
                dt.Rows.Add(_ravi);
            }
            return dt;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataTable tabela = napraviTabelu();


            string file = @"test.pdf";
            using (var doc = new PdfWrapper(file))
            {
                doc.DodajNaslov("Lista prijavljenih studenata", 14);
                doc.DodajParagraf("Za polaganje ispita iz Predmeta " + txtPredmeti.Text + " prijavili su se sledeci studenti");

                doc.DodajTabelu(tabela);

                doc.DodajMPiPotpis();

            }
            PdfWrapper.OtvoriFile(file);


        }
    }
}

