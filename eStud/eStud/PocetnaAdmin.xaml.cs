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
    /// Interaction logic for PocetnaAdmin.xaml
    /// </summary>
    public partial class PocetnaAdmin : UserControl
    {
        //Student student;
        public PocetnaAdmin()
        {
            InitializeComponent();
            popuniListu();
        }
        private void popuniListu()
        {
            DataTable dt = new DataTable();
            dt = DBController.getStudente();
            int brojac = dt.Rows.Count;
          
            List<Studenti> items = new List<Studenti>();
            for (int i = 0; i < brojac; i++)
            {
                
                items.Add(new Studenti() { Ime = dt.Rows[i][0].ToString(), Prezime =dt.Rows[i][1].ToString(),BrojIndeksa=dt.Rows[i][2].ToString() });
                listaStudenata.ItemsSource = items;

            }
            List<Referenti> itemi = new List<Referenti>();
            DataTable dt1 = new DataTable();
            dt1 = DBController.getReferente();

            int brojac1 = dt1.Rows.Count;

            for (int i = 0; i < brojac1; i++)
            {

                itemi.Add(new Referenti() { Ime1 = dt1.Rows[i][0].ToString(), Prezime1 = dt1.Rows[i][1].ToString(), Departman = dt1.Rows[i][2].ToString() });
                listaReferenta.ItemsSource = itemi;

            }

        }
        public class Studenti
        {
            public string Ime { get; set; }

            public string Prezime { get; set; }
            public string BrojIndeksa { get; set; }

            
        }
        public class Referenti
        {
            public string Ime1 { get; set; }
            public string Prezime1 { get; set; }
            public string Departman { get; set; }
        }

        private void btnPrikaziReferente_Click(object sender, RoutedEventArgs e)
        {
            GlavniPanel.Children.Clear();
            ReferentPodaci rp = new ReferentPodaci();
            GlavniPanel.Children.Add(rp);
        }

        private void btnPrikaziStudente_Click(object sender, RoutedEventArgs e)
        {
            GlavniPanel.Children.Clear();
            StudentPodaci rp = new StudentPodaci();
            GlavniPanel.Children.Add(rp);
        }
    }
}
