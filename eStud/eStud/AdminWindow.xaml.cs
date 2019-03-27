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

        private void btn_MouseEnter(object sender, MouseEventArgs e)
        {
            
           // HoverButtonEnter((Button)sender);
               
        }

        private void btn_MouseLeave(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
           

          HoverButtonLeave(b);
            
        }
        public void HoverButtonEnter(Button b)
        {
            
            b.Background = Brushes.DimGray;
        }
        public void HoverButtonLeave(Button b)
        {
            b.Background = Brushes.Transparent;
        }

       
    }
}
