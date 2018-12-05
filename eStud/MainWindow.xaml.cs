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
        Model.DBController dbc = new Model.DBController();
        Model.Korisnik kor;

        public MainWindow()
        {
            InitializeComponent();
        }

        public Korisnik Korisnik { get => Korisnik; set => Korisnik = value; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Korisnik rezultatUpita = dbc.ImaUBazi(txtUser.Text,txtPass.Text);
            
             
            if (rezultatUpita.getUserType() == "student")

            {
                try
                {
                    this.Hide();
                    StudentWindow sf = new StudentWindow(rezultatUpita);
                    sf.ShowDialog();
                }
                catch (Exception es) { MessageBox.Show(es.Message); }
            }

        }

        private Student korisnik(string v1, object v2, object v3, object v4)
        {
            throw new NotImplementedException();
        }
    }
}
