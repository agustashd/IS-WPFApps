using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Input;
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
        }

        private void CargarArchivos(object sender, RoutedEventArgs e)
        {
            LeerDirectorio("c:/");
        }

        private void PresionarTecla(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key != Key.Enter)
            {
                return;
            }

            LeerDirectorio(ruta.Text);
        }

        private void LeerDirectorio(string path)
        {
            if (!Directory.Exists(path))
            {
                estado.Content = $"La ruta {path} especificada";
                return;
            }

            var archivos = Directory.GetFiles(path);
            var directorios = Directory.GetDirectories(path);
            var files = new List<string>();

            foreach (var item in archivos)
            {
                files.Add(Path.GetFileName(item));
            }
            foreach (var item in directorios)
            {
                files.Add(Path.GetFileName(item));
            }
            explorer.ItemsSource = files;
            ruta.Text = path;
            estado.Content = string.Empty;
        }

        private void AbrirDirectorio(object sender, MouseButtonEventArgs e)
        {
            string item = explorer.SelectedItem.ToString();
            if (string.IsNullOrWhiteSpace(item))
            {
                return;
            }
            string path = ruta.Text;
            if (!path.EndsWith("/"))
            {
                path += "/";
            }
            LeerDirectorio(path + item);
        }
    }
}
