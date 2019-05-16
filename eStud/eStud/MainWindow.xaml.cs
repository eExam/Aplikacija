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
using System.Data;
using eStud.Model;

namespace eStud
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnLogin(object sender, RoutedEventArgs e)
        {
            LoginHandler();


        }
        private void LoginHandler()
        {
            Korisnik rezultatUpita = DBController.ImaUBazi(txtUser.Text, txtPass.Password.ToString());
           
            
           
            
            try {
                if ((txtPass.Password.ToString() == "") || (txtUser.Text == ""))
                {
                    MessageBox.Show("Niste popunili polja");
                }
                else
                {
                    if (DBController.ImaUBazi(txtUser.Text,txtPass.Password.ToString() )== null)
                    {
                        lblGreska.Content = "Pogrešno korisničko ime/lozinka";
                        txtPass.Password = "";
                    }
                   // lblGreska.Content = "";
                    if (rezultatUpita.getUserType() == "student")
                    {

                        this.Hide();
                        StudentWindow sw = new StudentWindow(new Student(rezultatUpita));
                        sw.ShowDialog();
                    }

                    else if (rezultatUpita.getUserType() == "admin")
                    {

                        this.Hide();
                        AdminWindow aw = new AdminWindow(rezultatUpita);
                        aw.ShowDialog();

                    }
                    else if (rezultatUpita.getUserType() == "referent")
                    {

                        this.Hide();
                        ReferentWindow rw = new ReferentWindow(new Referent(rezultatUpita));
                        rw.ShowDialog();

                    }
                }
            }
            catch(Exception ex)
            {
                //throw ex;
               /*if(DBController.ImaUBazi(txtUser.Text,txtPass.Password.ToString())==null)
                {
                    MessageBox.Show("Pogresili ste lozinku/korisnicko ime .Pokusajte ponovo");
                    txtPass.Password = "";
                }*/
                
            }

        }
        private bool ImaPraznoPolje()
        {
            return txtUser.Text == ""
                || txtPass.Password == "";
                
        }

        private void txtPass_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void txtPass_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                LoginHandler();
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

        private void txtUser_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            
                foreach (var ch in e.Text)
                {
                    if (!((Char.IsLetter(ch))) || ch.Equals('='))
                    {
                        e.Handled = true;

                        break;
                    }
                }
            
        }

        private void txtPass_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            foreach (var ch in e.Text)
            {
                if (!((Char.IsLetter(ch))) || ch.Equals('='))
                {
                    e.Handled = true;

                    break;
                }
            }
        }
    }
    }

