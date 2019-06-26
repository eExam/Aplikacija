using eStud.Model;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for StudentPrikazIspitnihRokova.xaml
    /// </summary>
    public partial class StudentPrikazIspitnihRokova : UserControl
    {
        public DataTable rezultati;
        public StudentPrikazIspitnihRokova()
        {
            InitializeComponent();
            popuniLabele();
        }
        private void popuniLabele()
        {
            rezultati = DBController.PrikaziIspitniRok();
            
            lblIspitniRok.Content = rezultati.Rows[0][0].ToString() + " Ispitni Rok";
            lblPocetak.Content = rezultati.Rows[0][2].ToString();
            lblKrajRoka.Content = rezultati.Rows[0][3].ToString();
            txtCena.Content = rezultati.Rows[0][4].ToString();
            txtMax.Content = rezultati.Rows[0][5].ToString();


        }
    }
}
