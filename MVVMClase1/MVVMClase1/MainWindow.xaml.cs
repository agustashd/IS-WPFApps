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
            var persona = new Persona();
            persona.Apellido = "Lopez";
            persona.Contador = -10;
        }
    }
}
