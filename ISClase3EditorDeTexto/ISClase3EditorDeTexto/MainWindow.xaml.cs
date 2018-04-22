using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;
using System.Windows.Media;

namespace ISClase3EditorDeTexto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
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
            openFileDialog.InitialDirectory = @"C:\Users\atashdjian\source\repos\IS-WPFApps\ISClase3EditorDeTexto\ISClase3EditorDeTexto\Archivos\";

            if (openFileDialog.ShowDialog() == true)
            {
                BotonGuardarDocumento.IsEnabled = true;
                txtEditor.IsEnabled = true;
                txtEditor.Text = File.ReadAllText(openFileDialog.FileName);
                this.filePath = openFileDialog.FileName;
                LabelPath.Content = this.filePath;
                LabelStatus.Content = string.Empty;
            }
        }

        private void GuardarDocumentoComo(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, txtEditor.Text);
                LabelStatus.Content = "El archivo se guardo correctamente";
            }
        }

        private void GuardarDocumento(object sender, RoutedEventArgs e)
        {
            if (this.filePath == string.Empty)
            {
                MessageBox.Show("Guardar solo funciona para archivos abiertos");
            }
            else
            {
                File.WriteAllText(this.filePath, txtEditor.Text);
                LabelStatus.Content = "El archivo se guardo correctamente";
            }
        }

        private void NuevoDocumento(object sender, RoutedEventArgs e)
        {
            BotonGuardarDocumento.IsEnabled = true;
            txtEditor.IsEnabled = true;
        }
    }
}
