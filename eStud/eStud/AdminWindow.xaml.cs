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
       
        public AdminWindow(Model.Korisnik rezultatUpit)
        {
           
            InitializeComponent();
            this.pnlMenu.Visibility = Visibility.Hidden;
        }
        private void btnReferenti_Click(object sender, RoutedEventArgs e)
        {
            GlavniPanel.Children.Clear();
            ReferentPodaci rp = new ReferentPodaci();
            GlavniPanel.Children.Add(rp);
        }

        private void btnStudenti_Click(object sender, RoutedEventArgs e)
        {
            GlavniPanel.Children.Clear();
            StudentPodaci sp = new StudentPodaci();
            GlavniPanel.Children.Add(sp);
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            if(this.pnlMenu.Visibility==Visibility.Hidden)
            {
                this.pnlMenu.Visibility = Visibility.Visible;
            }
            else
            {
                this.pnlMenu.Visibility = Visibility.Hidden;
            }
        }
    }
}
