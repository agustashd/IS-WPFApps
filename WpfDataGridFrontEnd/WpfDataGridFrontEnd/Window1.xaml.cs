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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            WpfDataGridFrontEnd.personasDataSet personasDataSet = ((WpfDataGridFrontEnd.personasDataSet)(this.FindResource("personasDataSet")));
            // Load data into the table tbltelefonos. You can modify this code as needed.
            WpfDataGridFrontEnd.personasDataSetTableAdapters.tbltelefonosTableAdapter personasDataSettbltelefonosTableAdapter = new WpfDataGridFrontEnd.personasDataSetTableAdapters.tbltelefonosTableAdapter();
            personasDataSettbltelefonosTableAdapter.Fill(personasDataSet.tbltelefonos);
            System.Windows.Data.CollectionViewSource tbltelefonosViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("tbltelefonosViewSource")));
            tbltelefonosViewSource.View.MoveCurrentToFirst();
        }
    }
}
