using MVVMClase1.Model;
using System.Windows;

namespace MVVMClase1
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

            // TODO: Add code here to load data into the table Telefono.
            // This code could not be generated, because the iSDatabaseDataSetTelefonoTableAdapter.Fill method is missing, or has unrecognized parameters.
            MVVMClase1.ISDatabaseDataSetTableAdapters.TelefonoTableAdapter iSDatabaseDataSetTelefonoTableAdapter = new MVVMClase1.ISDatabaseDataSetTableAdapters.TelefonoTableAdapter();
            System.Windows.Data.CollectionViewSource telefonoViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("telefonoViewSource")));
            telefonoViewSource.View.MoveCurrentToFirst();
        }
    }
}
