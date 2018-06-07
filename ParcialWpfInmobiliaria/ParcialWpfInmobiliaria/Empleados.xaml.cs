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

namespace ParcialWpfInmobiliaria
{
    /// <summary>
    /// Interaction logic for Empleados.xaml
    /// </summary>
    public partial class Empleados : Window
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ParcialWpfInmobiliaria.InmobiliariaDunDataSet inmobiliariaDunDataSet = ((ParcialWpfInmobiliaria.InmobiliariaDunDataSet)(this.FindResource("inmobiliariaDunDataSet")));
            // Load data into the table Inmuebles. You can modify this code as needed.
            ParcialWpfInmobiliaria.InmobiliariaDunDataSetTableAdapters.VendedoresTableAdapter inmobiliariaDunDataSetVendedoresTableAdapter = new ParcialWpfInmobiliaria.InmobiliariaDunDataSetTableAdapters.VendedoresTableAdapter();
            inmobiliariaDunDataSetVendedoresTableAdapter.Fill(inmobiliariaDunDataSet.Vendedores);
            System.Windows.Data.CollectionViewSource vendedoresViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("vendedoresViewSource")));
            //vendedoresViewSource.View.MoveCurrentToFirst();
        }

        private void ButtonClose(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
