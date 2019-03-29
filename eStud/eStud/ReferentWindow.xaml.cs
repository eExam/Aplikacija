﻿using eStud.Model;
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
    /// Interaction logic for ReferentWindow.xaml
    /// </summary>
    public partial class ReferentWindow : Window
    {
        private Referent r;
        public ReferentWindow(Korisnik k)
        {
            this.r = new Referent(k);
            InitializeComponent();
        }

        private void btnZahteviIspit_Click(object sender, RoutedEventArgs e)
        {
            this.GlavniPanel.Children.Clear();
            ReferentZahteviPrijava rzp = new ReferentZahteviPrijava();
            this.GlavniPanel.Children.Add(rzp);
        }
    }
}