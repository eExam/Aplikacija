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
                /*if (ImaPraznoPolje())
                    throw new Exception("Popunite sva polja!");*/
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
            catch(Exception ex)
            {
                if((txtPass.Password.ToString() == "") || (txtUser.Text==""))
                {
                    MessageBox.Show("Niste popunili polja");
                }
               if(DBController.ImaUBazi(txtUser.Text,txtPass.Password.ToString())==null)
                {
                    MessageBox.Show("Pogresili ste lozinku/korisnicko ime .Pokusajte ponovo");
                    txtPass.Password = "";
                }
                
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
    }
    }

