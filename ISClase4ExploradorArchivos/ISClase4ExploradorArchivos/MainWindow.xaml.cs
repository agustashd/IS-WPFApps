using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;
using System.Windows.Media;

namespace ISClase4ExploradorArchivos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // www.CodeProject.com
            // Hacer un Explorador de Archivos con un boton de actualizar, ir para atras o subir directorio
            // y un lugar que muestre la ruta o deje escribir una
            // Usando ListView y TreeView
            BotonGuardarDocumento.IsEnabled = false;
            txtEditor.IsEnabled = false;
        }

        string filePath { get; set; } = string.Empty;

        private void CambiarColor(object sender, RoutedEventArgs e)
        {
            Random ran = new Random();
            int ranNum = ran.Next(0, 11);
            if (ranNum < 4)
            {
                txtEditor.Background = Brushes.White;
            }
            else if (ranNum < 7)
            {
                txtEditor.Background = Brushes.Wheat;
            }
            else
            {
                txtEditor.Background = Brushes.WhiteSmoke;
            };
        }

        private void AbrirDocumento(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = @"C:\Users\atashdjian\source\repos\ISClase3EditorDeTexto\ISClase3EditorDeTexto\Archivos\";

            if (openFileDialog.ShowDialog() == true)
            {
                BotonGuardarDocumento.IsEnabled = true;
                txtEditor.IsEnabled = true;
                txtEditor.Text = File.ReadAllText(openFileDialog.FileName);
                this.filePath = openFileDialog.FileName;
            }
        }

        private void GuardarDocumentoComo(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, txtEditor.Text);
            }
        }

        private void GuardarDocumento(object sender, RoutedEventArgs e)
        {
            if (this.filePath == string.Empty)
            {
                MessageBox.Show("Guardar solo funciona para archivos abiertos");
            }
            else File.WriteAllText(this.filePath, txtEditor.Text);
        }

        private void NuevoDocumento(object sender, RoutedEventArgs e)
        {
            BotonGuardarDocumento.IsEnabled = true;
            txtEditor.IsEnabled = true;
        }
    }
}
