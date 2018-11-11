using System.Windows;
using WpfMVVM2018.MVVM.Model;
using WpfMVVM2018.MVVM.ViewModel;

namespace WpfMVVM2018
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// no deberia ir, no respeta MVVM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    AlumnosViewModel db = FindResource("database") as AlumnosViewModel;
        //    if (db!= null)
        //    {
        //        db.Alumnos[0].Apellido = "Garcia";
        //    }
        //}
    }
}
