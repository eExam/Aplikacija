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
    /// Interaction logic for MojiPredmeti.xaml
    /// </summary>
    public partial class MojiPredmeti : UserControl
    {
        private Student trenutniKor;
        public MojiPredmeti(Korisnik k)
        {
            this.trenutniKor = new Student(k);
            InitializeComponent();
            popuniTabelu();
        }
        private void popuniTabelu()
        {
            DataTable rezultati =  DBController.StudentPredmeti(trenutniKor.getUserName());
            rezultati.Columns["Naziv_predmeta"].ColumnName = "Predmet";
            TabelaPredmeti.ItemsSource = rezultati.DefaultView;
        }

        private void TabelaPredmeti_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TabelaPredmeti.IsReadOnly = true;
        }
    }
}
