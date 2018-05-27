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

namespace ParcialWpfInmobiliaria
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

            ParcialWpfInmobiliaria.InmobiliariaDunDataSet inmobiliariaDunDataSet = ((ParcialWpfInmobiliaria.InmobiliariaDunDataSet)(this.FindResource("inmobiliariaDunDataSet")));
            // Load data into the table Inmuebles. You can modify this code as needed.
            ParcialWpfInmobiliaria.InmobiliariaDunDataSetTableAdapters.InmueblesTableAdapter inmobiliariaDunDataSetInmueblesTableAdapter = new ParcialWpfInmobiliaria.InmobiliariaDunDataSetTableAdapters.InmueblesTableAdapter();
            inmobiliariaDunDataSetInmueblesTableAdapter.Fill(inmobiliariaDunDataSet.Inmuebles);
            System.Windows.Data.CollectionViewSource inmueblesViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("inmueblesViewSource")));
            inmueblesViewSource.View.MoveCurrentToFirst();
        }

        private void inmueblesListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ButtonClose(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
