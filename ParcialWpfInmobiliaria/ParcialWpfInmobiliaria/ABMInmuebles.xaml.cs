using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for ABMInmuebles.xaml
    /// </summary>
    public partial class ABMInmuebles : Window
    {
        CollectionViewSource inmueblesViewSource;
        CollectionViewSource vendedoresViewSource;

        public ABMInmuebles()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            InmobiliariaDunDataSet inmobiliariaDunDataSet = ((InmobiliariaDunDataSet)(this.FindResource("inmobiliariaDunDataSet")));
            // Load data into the table Inmuebles. You can modify this code as needed.
            InmobiliariaDunDataSetTableAdapters.InmueblesTableAdapter inmobiliariaDunDataSetInmueblesTableAdapter = new InmobiliariaDunDataSetTableAdapters.InmueblesTableAdapter();
            inmobiliariaDunDataSetInmueblesTableAdapter.Fill(inmobiliariaDunDataSet.Inmuebles);
            this.inmueblesViewSource = ((CollectionViewSource)(this.FindResource("inmueblesViewSource")));

            InmobiliariaDunDataSetTableAdapters.VendedoresTableAdapter inmobiliariaDunDataSetVendedoresTableAdapter = new InmobiliariaDunDataSetTableAdapters.VendedoresTableAdapter();
            inmobiliariaDunDataSetVendedoresTableAdapter.Fill(inmobiliariaDunDataSet.Vendedores);
            this.vendedoresViewSource = ((CollectionViewSource)(this.FindResource("vendedoresViewSource")));
            inmueblesViewSource.View.MoveCurrentToFirst();

            idVendedorList.ItemsSource = inmobiliariaDunDataSet.Vendedores.Select(x => x.ID).ToList();
        }

        private void ButtonClose(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void NavegacionClick(object sender, RoutedEventArgs e)
        {
            this.inmueblesViewSource = ((CollectionViewSource)(this.FindResource("inmueblesViewSource")));

            if (sender == primero)
            {
                this.inmueblesViewSource.View.MoveCurrentToFirst();
            }
            else if (sender == atras)
            {
                if (!this.inmueblesViewSource.View.MoveCurrentToPrevious()) { this.inmueblesViewSource.View.MoveCurrentToFirst(); }
            }
            else if (sender == adelante)
            {
                this.inmueblesViewSource.View.MoveCurrentToNext();
            }
            else if (sender == ultimo)
            {
                this.inmueblesViewSource.View.MoveCurrentToLast();
            }
        }

        private void ButtonAdd(object sender, RoutedEventArgs e)
        {
            InmobiliariaDunDataSet inmobiliariaDunDataSet = ((InmobiliariaDunDataSet)(this.FindResource("inmobiliariaDunDataSet")));
            InmobiliariaDunDataSetTableAdapters.InmueblesTableAdapter inmobiliariaDunDataSetInmueblesTableAdapter = new InmobiliariaDunDataSetTableAdapters.InmueblesTableAdapter();

            int success = 0;
            try
            {
                success = inmobiliariaDunDataSetInmueblesTableAdapter.Insert(fechaPublicacionDatePicker.DisplayDate, int.Parse(idVendedorList.SelectedItem.ToString()), direccionTextBox.Text, ambientesTextBox.Text, int.Parse(precioTextBox.Text), reservadoCheckBox.IsChecked.Value);
            }
            catch
            {
                MessageBox.Show("Ocurrio un error");
            }

            if (success == 0) { MessageBox.Show("No se pudo agregar el registro"); }
            if (success == 1) { MessageBox.Show("El registro se agrego con éxito"); }

            inmobiliariaDunDataSet.AcceptChanges();
            inmobiliariaDunDataSetInmueblesTableAdapter.Fill(inmobiliariaDunDataSet.Inmuebles);
            inmueblesViewSource.View.MoveCurrentToLast();
        }

        private void ButtonDelete(object sender, RoutedEventArgs e)
        {
            InmobiliariaDunDataSet inmobiliariaDunDataSet = ((InmobiliariaDunDataSet)(this.FindResource("inmobiliariaDunDataSet")));
            InmobiliariaDunDataSetTableAdapters.InmueblesTableAdapter inmobiliariaDunDataSetInmueblesTableAdapter = new InmobiliariaDunDataSetTableAdapters.InmueblesTableAdapter();

            int success = 0;
            try
            {
                success = inmobiliariaDunDataSetInmueblesTableAdapter.Delete(int.Parse(idTextBox.Text), fechaPublicacionDatePicker.DisplayDate, int.Parse(idVendedorList.SelectedItem.ToString()), direccionTextBox.Text, ambientesTextBox.Text, int.Parse(precioTextBox.Text), reservadoCheckBox.IsChecked.Value);
            }
            catch
            {
                MessageBox.Show("Seleccione un registro para eliminar");
            }

            if (success == 0) { MessageBox.Show("El registro no existe"); }
            if (success == 1) { MessageBox.Show("El registro se eliminó con éxito"); }

            inmobiliariaDunDataSet.AcceptChanges();
            inmobiliariaDunDataSetInmueblesTableAdapter.Fill(inmobiliariaDunDataSet.Inmuebles);
            inmueblesViewSource.View.MoveCurrentToLast();
        }

        private void ButtonModify(object sender, RoutedEventArgs e)
        {
            InmobiliariaDunDataSet inmobiliariaDunDataSet = ((InmobiliariaDunDataSet)(this.FindResource("inmobiliariaDunDataSet")));
            InmobiliariaDunDataSetTableAdapters.InmueblesTableAdapter inmobiliariaDunDataSetInmueblesTableAdapter = new InmobiliariaDunDataSetTableAdapters.InmueblesTableAdapter();
            var originalRow = inmobiliariaDunDataSet.Inmuebles.Where(x => x.ID == int.Parse(idTextBox.Text)).ToList();
            int success = 0;
            success = inmobiliariaDunDataSetInmueblesTableAdapter.Update(fechaPublicacionDatePicker.DisplayDate, int.Parse(idVendedorList.SelectedItem.ToString()), direccionTextBox.Text, ambientesTextBox.Text, int.Parse(precioTextBox.Text), reservadoCheckBox.IsChecked.Value, originalRow[0].ID, originalRow[0].FechaPublicacion, originalRow[0].IDVendedor, originalRow[0].Direccion, originalRow[0].Ambientes, originalRow[0].Precio, originalRow[0].Reservado);
            inmobiliariaDunDataSet.AcceptChanges();
            inmobiliariaDunDataSetInmueblesTableAdapter.Fill(inmobiliariaDunDataSet.Inmuebles);
            inmueblesViewSource.View.MoveCurrentToLast();
        }

        private void ValidateInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }

        private bool IsTextAllowed(string text)
        {
            Regex regex = new Regex("[^0-9]+");
            return !regex.IsMatch(text);
        }
    }
}
