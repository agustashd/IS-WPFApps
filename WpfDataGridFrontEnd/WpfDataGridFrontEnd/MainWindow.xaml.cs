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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfDataGridFrontEnd
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            WpfDataGridFrontEnd.personasDataSet personasDataSet = ((WpfDataGridFrontEnd.personasDataSet)(this.FindResource("personasDataSet")));
            // Load data into the table tblpersonas. You can modify this code as needed.
            WpfDataGridFrontEnd.personasDataSetTableAdapters.tblpersonasTableAdapter personasDataSettblpersonasTableAdapter = new WpfDataGridFrontEnd.personasDataSetTableAdapters.tblpersonasTableAdapter();
            personasDataSettblpersonasTableAdapter.Fill(personasDataSet.tblpersonas);
            System.Windows.Data.CollectionViewSource tblpersonasViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("tblpersonasViewSource")));
            tblpersonasViewSource.View.MoveCurrentToFirst();
        }
    }
}
