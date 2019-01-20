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
    /// Interaction logic for StatusObavestenje.xaml
    /// </summary>
    public partial class StatusObavestenje : Window
    {
        Student trenutniKorisnik;
        public StatusObavestenje(Student tk)
        {
            trenutniKorisnik = tk;
            InitializeComponent();
            StatusStudenta();
        }
        public void StatusStudenta()
        {
            string status = DBController.getStatus(trenutniKorisnik.getUserName());
            if (status == "BUDZET")
            {
                lblStatus.Content = "VAS STATUS JE " + " " + status;
                this.lblStatus.Foreground = System.Windows.Media.Brushes.Green;
            }
            else
            {
                lblStatus.Content = "VAS STATUS JE " + " " + status;
                this.lblStatus.Foreground = Brushes.Red;
            }
        }
    }
}