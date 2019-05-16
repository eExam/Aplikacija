using eStud.Model;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace eStud
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
      Korisnik trenutniKorisnik;
        public AdminWindow(Korisnik tk)
        {
            trenutniKorisnik = tk;
            InitializeComponent();
            GlavniPanel.Children.Clear();
            PocetnaAdmin p = new PocetnaAdmin();
            GlavniPanel.Children.Add(p);
           
        }
       

       
       

        private void btnStud_Click(object sender, RoutedEventArgs e)
        {
            GlavniPanel.Children.Clear();
            StudentPodaci sp = new StudentPodaci();
            GlavniPanel.Children.Add(sp);
            this.btnStud.Background = Brushes.DimGray;
            this.btnRef.Background = Brushes.Transparent;
        }

        private void btnRef_Click(object sender, RoutedEventArgs e)
        {
            GlavniPanel.Children.Clear();
            ReferentPodaci rp = new ReferentPodaci();
            GlavniPanel.Children.Add(rp);
            
            this.btnRef.Background = Brushes.DimGray;
            this.btnStud.Background = Brushes.Transparent;
        }

        private void btnOdjava_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mw = new MainWindow();
            mw.ShowDialog();
        }
        private void popuniListuStudenata()
        {
            
        }
       

        
        private void btnPocetna_Click(object sender, RoutedEventArgs e)
        {
            GlavniPanel.Children.Clear();
            PocetnaAdmin pa = new PocetnaAdmin();
            GlavniPanel.Children.Add(pa);
        }

        private void btnPromenaLozinke_Click(object sender, RoutedEventArgs e)
        {
            GlavniPanel.Children.Clear();
            PromenaLozinke p = new PromenaLozinke(trenutniKorisnik);
            GlavniPanel.Children.Add(p);
        }
    }
}
