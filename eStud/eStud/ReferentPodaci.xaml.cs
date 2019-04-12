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
using eStud.Model;
using System.Data.OleDb;


namespace eStud
{
    /// <summary>
    /// Interaction logic for ReferentPodaci.xaml
    /// </summary>
    public partial class ReferentPodaci : UserControl
    {
        public DataTable rezultati;
        bool state = false;
        //private DBController db=new DBController();
        public ReferentPodaci()
        {
            InitializeComponent();
            PopuniTabelu();
            
            
            
        }
       
        private void PopuniTabelu()
        {
            rezultati = DBController.PodaciReferent();
            rezultati.Columns["studijski_program"].ColumnName = "Studijski program";
            rezultati.Columns["departman"].ColumnName = "Departman";
            rezultati.Columns["pol"].ColumnName = "Pol";
            rezultati.Columns["prezime"].ColumnName = "Prezime";
            rezultati.Columns["ime"].ColumnName = "Ime";
            rezultati.Columns["username"].ColumnName = "Username";
            rezultati.Columns["datum_rodjenja"].ColumnName = "Datum rodjenja";
            TabelaReferenti.ItemsSource = rezultati.DefaultView;
        
            
            
        }
        

        private void btnIzbrisi_Click(object sender, RoutedEventArgs e)
        {


            try
            {
                MessageBoxResult result = MessageBox.Show("Da li ste sigurni", "Confirmation", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    //TabelaReferenti.SelectedItem;
                    TabelaReferenti.CanUserDeleteRows = true;
                    
                    DataRowView row = (DataRowView)TabelaReferenti.SelectedItems[0];
                    DBController.izbrisiKorisnika(row["username"].ToString());
                    rezultati.Rows.Remove(row.Row);
                    //  MessageBox.Show(TabelaReferenti.SelectedItem.ToString());
                    //PopuniTabelu();
                }
            }
            catch (Exception ex)
            {
               
            }
        }
       

        private void btnDodajRef_Click(object sender, RoutedEventArgs e)
        {
           // state = 0;
            if (state==true)
            {
                pnlRight.Children.Clear();
               
                state = false;               
            }
            
            else
            {
                pnlRight.Children.Clear();
                DodajReferenta df = new DodajReferenta(TabelaReferenti);
                pnlRight.Children.Add(df);
                state = true;
            }
        }

        private void btnIzmeni_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView row = (DataRowView)TabelaReferenti.SelectedItems[0];

                txtIme.Text = (row["Ime"].ToString());
                txtDepartman.Text = (row["Departman"].ToString());
                txtDatumRodj.Text = row["Datum rodjenja"].ToString();
                txtPrezime.Text = row["Prezime"].ToString();
                txtPol.Text = (row["Pol"].ToString());
                txtStudijskiProgram.Text = row["Studijski program"].ToString();
                txtUsername.Text = row["Username"].ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Niste izabrali");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DBController.IzmeniRef(txtUsername.Text, txtIme.Text, txtPrezime.Text, txtDatumRodj.Text, txtPol.Text,txtDepartman.Text,txtStudijskiProgram.Text);
            PopuniTabelu();
        }

        private void TabelaReferenti_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TabelaReferenti.IsReadOnly = true;
        }
    }
 }
