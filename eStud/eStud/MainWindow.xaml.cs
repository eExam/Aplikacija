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
            Korisnik rezultatUpita = DBController.ImaUBazi(txtUser.Text,txtPass.Text);
            
             
            if (rezultatUpita.getUserType() == "student")
            {
                try
                {
                    this.Hide();
                    StudentWindow sw = new StudentWindow(new Student(rezultatUpita));
                    sw.ShowDialog();
                }
                catch (Exception es) { MessageBox.Show(es.Message); }
            }
            else if(rezultatUpita.getUserType()=="admin")
            {
                try
                {
                    this.Hide();
                    AdminWindow aw = new AdminWindow(rezultatUpita);
                    aw.ShowDialog();
                }
                catch (Exception es) { MessageBox.Show(es.Message); }
            }
            else if(rezultatUpita.getUserType()=="referent")
            {
                try
                {
                    this.Hide();
                    ReferentWindow rw = new ReferentWindow(new Referent(rezultatUpita));
                    rw.ShowDialog();
                }
                catch(Exception es)
                {
                    MessageBox.Show(es.Message);
                }
            }


        }

    }
}
