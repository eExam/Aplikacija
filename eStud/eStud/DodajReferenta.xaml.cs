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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace eStud
{
    /// <summary>
    /// Interaction logic for DodajReferenta.xaml
    /// </summary>
    public partial class DodajReferenta : UserControl
    {
        public DodajReferenta()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SacuvajPodatke();
        }
        private void SacuvajPodatke()
        {
            try
            {
                DBController.UbaciUBazi(this.txtUsername.Text, this.txtPassword.Text, this.txtUsertype.Text, this.txtIme.Text, this.txtPrezime.Text, this.txtDatumRodj.Text, this.txtPol.Text);
                DBController.DodajRef(this.txtUsername.Text, this.txtDepartman.Text, this.txtStudijskiProgram.Text);
                MessageBox.Show("Bravo");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Greska");
            }
        }
            
    }
}
