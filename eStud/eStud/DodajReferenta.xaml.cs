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
                if (ImaPraznoPolje())
                  throw new Exception("Popunite sva polja!");
                if (DBController.ImaUBazi(txtUsername.Text, txtPassword.Text) != null)
                    throw new Exception("Korisnicko ime je zauzeto");

                DBController.UbaciUBazi(this.txtUsername.Text, this.txtPassword.Text, this.txtUsertype.Text, this.txtIme.Text, this.txtPrezime.Text, this.txtDatumRodj.Text, this.txtPol.Text);
                    DBController.DodajRef(this.txtUsername.Text, this.txtDepartman.Text, this.txtStudijskiProgram.Text);
                    MessageBox.Show("Uspesno ste dodali Korisnika");

               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Niste popunili sva polja");
            }


        }
        private bool ImaPraznoPolje()
        {
            return txtUsername.Text == ""
                || txtPassword.Text == ""
                || txtUsertype.Text == ""
                || txtIme.Text == ""
                || txtPrezime.Text == ""
                || txtDatumRodj.Text == ""
                || txtPol.Text == ""
                || txtDepartman.Text == ""
                || txtStudijskiProgram.Text == "";
        }
    }
}
            
    

