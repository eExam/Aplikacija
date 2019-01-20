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
    /// Interaction logic for StudentPrijaviIspit.xaml
    /// </summary>
    public partial class StudentPrijaviIspit : UserControl
    {
        Student trenutniKorisnik;
        
        public StudentPrijaviIspit(Student s)
        {
            trenutniKorisnik = s;
            InitializeComponent();
            popuniPrijavu();
        }
        public void popuniPrijavu()
        {
          
            this.txtImePrezime.Text = trenutniKorisnik.getIme() +" " + trenutniKorisnik.getPrezime();
            this.txtDepartman.Text = DBController.getDepartman(trenutniKorisnik.getUserName());
            this.txtBrIndeksa.Text = DBController.getBrIndeksa(trenutniKorisnik.getUserName());
            this.txtStudijskiProgram.Text = DBController.getSmer(trenutniKorisnik.getUserName());
           
        }
    }
}
