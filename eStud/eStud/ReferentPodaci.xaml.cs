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
            popuniTabelu();

        }
         private void popuniTabelu()
          {
                DataTable rezultati = new DBController().PodaciReferent();
                TabelaReferenti.ItemsSource = rezultati.DefaultView;
          }

        private void btnIzbrisi_Click(object sender, RoutedEventArgs e)
        {
            
            DBController.izbrisiRef(txtUsername.Text);
            DataTable rezultati = new DBController().PodaciReferent();
            TabelaReferenti.ItemsSource = rezultati.DefaultView;
        }
       

        

        private void btnPrikazi_Click(object sender, RoutedEventArgs e)
        {
            GlavniPanel.Children.Clear();
            DodajReferenta df = new DodajReferenta();

            GlavniPanel.Children.Add(df);
            
        }
    }
    }
