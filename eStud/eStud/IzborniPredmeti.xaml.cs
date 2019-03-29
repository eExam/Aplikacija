﻿using eStud.Model;
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
    /// Interaction logic for IzborniPredmeti.xaml
    /// </summary>
    public partial class IzborniPredmeti : UserControl
    {
        Student trenutniKorisnik;
        public IzborniPredmeti(Student tk)
        {
            trenutniKorisnik = tk;
            InitializeComponent();
            popuniIzbornePredmete();
        }
        public void popuniIzbornePredmete()
        {
            DataTable rezultati = DBController.StudentIzborniPredmeti(trenutniKorisnik.getUserName());

            rezultati.Columns["Naziv_predmeta"].ColumnName = "Predmet";
            rezultati.Columns["Studijski_program"].ColumnName = "Studijski program";

            tabelaIzborniPredmeti.ItemsSource = rezultati.DefaultView;
            

        }
    }
}