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
using System.Windows.Shapes;

namespace eStud
{
    /// <summary>
    /// Interaction logic for ReferentWindow.xaml
    /// </summary>
    public partial class ReferentWindow : Window
    {
        private Referent r;
        DataTable rezultati;
        public ReferentWindow(Korisnik k)
        {
            this.r = new Referent(k);
            InitializeComponent();
            Obavestenje();
            GlavniPanel.Children.Clear();
            PocetnaReferent pr = new PocetnaReferent();
            GlavniPanel.Children.Add(pr);

        }
        private void Obavestenje()
        {
            
            rezultati= DBController.ReferentZahteviPrijava();
            int brojac = rezultati.Rows.Count;
            txtNotification.Text = brojac.ToString();

        }
        private void btnZahteviIspit_Click(object sender, RoutedEventArgs e)
        {
            this.GlavniPanel.Children.Clear();
            ReferentZahteviPrijava rzp = new ReferentZahteviPrijava();
            this.GlavniPanel.Children.Add(rzp);
        }

        private void btnIspitniRokovi_Click(object sender, RoutedEventArgs e)
        {
            this.GlavniPanel.Children.Clear();
            IspitniRokovi ir = new IspitniRokovi();
            this.GlavniPanel.Children.Add(ir);
        }

        private void btnPrijavljeniIspiti_Click(object sender, RoutedEventArgs e)
        {
            this.GlavniPanel.Children.Clear();
            ReferentPrijavljeniIspiti rpi = new ReferentPrijavljeniIspiti();
            this.GlavniPanel.Children.Add(rpi);
        }

        private void btnPrijavnice_Click(object sender, RoutedEventArgs e)
        {
            this.GlavniPanel.Children.Clear();
            PrijavniceZaProfesora pzr = new PrijavniceZaProfesora();
            this.GlavniPanel.Children.Add(pzr);
        }

        private void btnOdjava_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow m = new MainWindow();
            m.ShowDialog();
        }

        private void btnMolbe_Click(object sender, RoutedEventArgs e)
        {
            GlavniPanel.Children.Clear();
            ReferentPotvrdeUverenja r = new ReferentPotvrdeUverenja();
            GlavniPanel.Children.Add(r);
        }

        private void btnPocetna_Click(object sender, RoutedEventArgs e)
        {
            GlavniPanel.Children.Clear();
            PocetnaReferent pr = new PocetnaReferent();
            GlavniPanel.Children.Add(pr);
        }
    }
}
