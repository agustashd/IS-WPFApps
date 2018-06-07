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
        CollectionViewSource inmueblesViewSource;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Load_Table()
        {
            InmobiliariaDunDataSet inmobiliariaDunDataSet = ((InmobiliariaDunDataSet)(this.FindResource("inmobiliariaDunDataSet")));
            // Load data into the table Inmuebles. You can modify this code as needed.
            InmobiliariaDunDataSetTableAdapters.InmueblesTableAdapter inmobiliariaDunDataSetInmueblesTableAdapter = new InmobiliariaDunDataSetTableAdapters.InmueblesTableAdapter();
            inmobiliariaDunDataSetInmueblesTableAdapter.Fill(inmobiliariaDunDataSet.Inmuebles);
            this.inmueblesViewSource = ((CollectionViewSource)(this.FindResource("inmueblesViewSource")));
            //inmueblesViewSource.View.MoveCurrentToFirst();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Load_Table();
        }

        private void ButtonClose(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ButtonViewVendedores(object sender, RoutedEventArgs e)
        {
            Empleados windowEmpleados = new Empleados();
            windowEmpleados.Show();
        }

        private void ButtonRefresh(object sender, RoutedEventArgs e)
        {
            Load_Table();
        }

        private void ButtonViewABMInmuebles(object sender, RoutedEventArgs e)
        {
            ABMInmuebles windowABMInmuebles = new ABMInmuebles();
            windowABMInmuebles.Show();
        }
    }
}
