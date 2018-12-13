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
using eStud.Model;
using System.Data.OleDb;

namespace eStud
{
    /// <summary>
    /// Interaction logic for ReferentPodaci.xaml
    /// </summary>
    public partial class ReferentPodaci : UserControl
    {
       
        //private DBController db=new DBController();
        public ReferentPodaci()
        {
            InitializeComponent();
            PopuniTabelu();
            
            
        }
       
        private void PopuniTabelu()
        {
            DataTable rezultati = DBController.PodaciReferent();
            rezultati.Columns["studijski_program"].ColumnName = "Studijski program";
            rezultati.Columns["departman"].ColumnName = "Departman";
            rezultati.Columns["pol"].ColumnName = "POl";
            rezultati.Columns["prezime"].ColumnName = "Prezime";
            rezultati.Columns["ime"].ColumnName = "Ime";
            rezultati.Columns["username"].ColumnName = "Username";
            rezultati.Columns["datum_rodjenja"].ColumnName = "Datum rodjenja";
            TabelaReferenti.ItemsSource = rezultati.DefaultView;
           
           
            
            
        }

        private void btnIzbrisi_Click(object sender, RoutedEventArgs e)
        {
            
            DBController.izbrisiRef(txtUsername.Text);
            DataTable rezultati = DBController.PodaciReferent();
            
        }

        private void btnDodajRef_Click(object sender, RoutedEventArgs e)
        {
            pnlRight.Children.Clear();
            DodajReferenta df = new DodajReferenta();
            pnlRight.Children.Add(df);
        }
    }
 }
