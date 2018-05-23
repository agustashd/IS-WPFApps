using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfDataGridFrontEnd
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        CollectionViewSource tblpersonasViewSource;
        //http://groups.yahoo.com/group/IFTS18-PA


        public Window3()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            personasDataSet personasDataSet = ((personasDataSet)(this.FindResource("personasDataSet")));
            // Load data into the table tblpersonas. You can modify this code as needed.
            personasDataSetTableAdapters.tblpersonasTableAdapter personasDataSettblpersonasTableAdapter = 
                new personasDataSetTableAdapters.tblpersonasTableAdapter();
            personasDataSettblpersonasTableAdapter.Fill(personasDataSet.tblpersonas);
            
            tblpersonasViewSource = ((CollectionViewSource)
                (this.FindResource("tblpersonasViewSource")));
            //tblpersonasViewSource.View.MoveCurrentToFirst();
            
            Button_Click(buttonFirst, new RoutedEventArgs());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tblpersonasViewSource = ((CollectionViewSource)(this.FindResource("tblpersonasViewSource")));
            if (sender == buttonFirst)
            {
                tblpersonasViewSource.View.MoveCurrentToFirst();
            }
            else if (sender==buttonPrevious)
            {
                tblpersonasViewSource.View.MoveCurrentToPrevious();
            }
            else if (sender == buttonNext)
            {
                tblpersonasViewSource.View.MoveCurrentToNext();
            }
            else if (sender == buttonLast)
            {
                tblpersonasViewSource.View.MoveCurrentToLast();
            }
            else if (sender == buttonRefresh)
            {
                personasDataSet personasDataSet = ((personasDataSet)(this.FindResource("personasDataSet")));
                CollectionViewSource.GetDefaultView(personasDataSet).Refresh();
            }
            TextboxCurrent.Text = tblpersonasViewSource.View.CurrentPosition.ToString();
        }

        private void TextboxCurrent_KeyDown(object sender, KeyEventArgs e)
        {
            
            tblpersonasViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("tblpersonasViewSource")));
            if (e.Key != Key.Enter)
            {
                return;
            }
            int l = 0;
            if (int.TryParse(TextboxCurrent.Text, out l))
            {
                tblpersonasViewSource.View.MoveCurrentToPosition(l);
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            personasDataSet personasDataSet = ((personasDataSet)
                (this.FindResource("personasDataSet")));

            personasDataSetTableAdapters.tblpersonasTableAdapter 
                personasDataSettblpersonasTableAdapter = 
                new personasDataSetTableAdapters.tblpersonasTableAdapter();
            
            //personasDataSettblpersonasTableAdapter.Insert("Pepe", 
            //    "Luis", new DateTime(2000, 12, 2), "333333");
            personasDataSettblpersonasTableAdapter.Insert(apellidoTextBox.Text,
                nombreTextBox.Text, fechaNacimientoDatePicker.DisplayDate, 
                documentoTextBox.Text);
            // personasDataSettblpersonasTableAdapter.Update(personasDataSet);
            //personasDataSettblpersonasTableAdapter.Update();
            personasDataSet.AcceptChanges();
            personasDataSettblpersonasTableAdapter.Fill(personasDataSet.tblpersonas);
            //WpfDataGridFrontEnd.personasDataSet personasDataSet = ((WpfDataGridFrontEnd.personasDataSet)(this.FindResource("personasDataSet")));
            // CollectionViewSource.GetDefaultView(personasDataSet).Refresh();
            tblpersonasViewSource.View.MoveCurrentToLast();

            ;

        }
        private void Button_Close(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //fechaNacimientoDatePicker.SelectedDate = (DateTime?)DateTime.Now();
        }

        private void Button_Table(object sender, RoutedEventArgs e)
        {
            Window ventana = new MainWindow();
            ventana.Show();
        }
    }
}
