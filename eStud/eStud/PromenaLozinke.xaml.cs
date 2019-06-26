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
    /// Interaction logic for PromenaLozinke.xaml
    /// </summary>
    public partial class PromenaLozinke : UserControl
    {
        Korisnik trenutniKorisnik;
        public PromenaLozinke(Korisnik tk)
        {
            trenutniKorisnik = tk;
            InitializeComponent();
        }

        private void btnPromeniLozinku_Click(object sender, RoutedEventArgs e)
        {

            PromeniLozinku();
           
        }
        private void PromeniLozinku()
        {
            Console.WriteLine(DBController.getPassword(trenutniKorisnik.getUserName()));
            Console.WriteLine(trenutniKorisnik.getUserName());
            string staraLozinka = DBController.getPassword(trenutniKorisnik.getUserName());
            string unesena = CreateMD5(txtStaraLozinka.Password.ToString());
            unesena=CreateMD5(txtStaraLozinka.Password.ToString());
           
            try
            {

                if (staraLozinka == unesena)

                /*if ((DBController.getPassword(trenutniKorisnik.getUserName())==true) && (txtNovaLozinka.Text==txtNovaLozinka2.Text))*/
                {

                    if (txtNovaLozinka.Password == txtNovaLozinka2.Password)
                        if (txtNovaLozinka.Password == txtStaraLozinka.Password && txtNovaLozinka2.Password == txtStaraLozinka.Password)

                        {
                            MessageBox.Show("Ne mozete staviti istu lozinku");
                        }
                        else
                        {
                            if (txtNovaLozinka.Password !="" && txtNovaLozinka2.Password !="")
                            {
                                DBController.postaviNovuLozinku(trenutniKorisnik.getUserName(),txtNovaLozinka.Password.ToString());
                                MessageBox.Show("Bravo");
                                ocistiSvaPolja();
                            }
                            else
                            {
                                MessageBox.Show("Popunite polja");
                            }
                            }
                    else
                    {
                        MessageBox.Show("Nove lozinke se ne podudaraju");
                    }

                }

                else
                {
                    MessageBox.Show("Stara lozinka nije tacna");
                }

            }
            catch (Exception ex)
            {

                if (imaPraznihPolja())
                    MessageBox.Show("Niste popunili sva polja");

                /* if (txtNovaLozinka.Text != txtNovaLozinka2.Text)
                     MessageBox.Show("Nove lozinke se ne podudaraju");*/



            }
        }
        
        private void ocistiSvaPolja()
        {
            txtStaraLozinka.Password = "";
            txtNovaLozinka.Password = "";
            txtNovaLozinka2.Password = "";
        }
        private bool imaPraznihPolja()
        {
            return txtStaraLozinka.Password == " "
                 || txtNovaLozinka.Password == " "
                 || txtNovaLozinka2.Password == " ";
             
        }

      

        private void txtNovaLozinka_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }
        private void SAVE_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key==Key.Enter)
            {
                PromeniLozinku();
            }
        }
        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        private void txtStaraLozinka_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            foreach (var ch in e.Text)
            {
                if (!((Char.IsLetter(ch)) )|| ch.Equals('='))
                {
                    e.Handled = true;

                    break;
                }
            }
        }
    }
}
