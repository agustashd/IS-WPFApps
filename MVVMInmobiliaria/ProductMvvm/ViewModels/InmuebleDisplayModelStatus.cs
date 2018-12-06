using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Media;


namespace MVVMInmobiliaria.ViewModels
{
    // CHEQUEA ESTADO DEL MODELO Y VERIFICACIONES EN LOS UPDATES Y DELETES
    // MANEJO DE MENSAJES DE ERROR
    public class InmuebleDisplayModelStatus : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }

        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; OnPropertyChanged(new PropertyChangedEventArgs("Status")); }
        }
        private static SolidColorBrush errorBrush = new SolidColorBrush(Colors.Red);
        private static SolidColorBrush okBrush = new SolidColorBrush(Colors.Black);

        private SolidColorBrush direccionBrush = okBrush;
        public SolidColorBrush DireccionBrush
        {
            get { return direccionBrush; }
            set { direccionBrush = value; OnPropertyChanged(new PropertyChangedEventArgs("DireccionBrush")); }
        }

        private SolidColorBrush nombreVendedorBrush = okBrush;
        public SolidColorBrush NombreVendedorBrush
        {
            get { return nombreVendedorBrush; }
            set { nombreVendedorBrush = value; OnPropertyChanged(new PropertyChangedEventArgs("NombreVendedorBrush")); }
        }

        private SolidColorBrush nombreCategoriaBrush = okBrush;
        public SolidColorBrush NombreCategoriaBrush
        {
            get { return nombreCategoriaBrush; }
            set { nombreCategoriaBrush = value; OnPropertyChanged(new PropertyChangedEventArgs("NombreCategoriaBrush")); }
        }

        private SolidColorBrush costBrush = okBrush;
        public SolidColorBrush CostBrush
        {
            get { return costBrush; }
            set { costBrush = value; OnPropertyChanged(new PropertyChangedEventArgs("CostBrush")); }
        }


        // ESTADO SIN ERRORES
        public void NoError()
        {
            DireccionBrush = NombreVendedorBrush = NombreCategoriaBrush = CostBrush = okBrush;
            Status = "Correcto";
        }


        public InmuebleDisplayModelStatus()
        {
            NoError();
        }


        // VERIFICAR QUE SE INGRESE UN NUMERO POSITIVO
        private bool ChkUnitCost(string costString)
        {
            if (String.IsNullOrEmpty(costString))
                return false;
            else
            {
                decimal unitCost;
                try
                {
                    unitCost = Decimal.Parse(costString);
                }
                catch
                {
                    return false;
                }
                if (unitCost < 0)
                    return false;
                else return true;
            }
        }


        // VERIFICAR SI SE COMPLETAN LOS DEMAS CAMPOS AL AGREGAR INMUEBLE
        public bool ChkProductForAdd(Inmueble p)
        {
            int errCnt = 0;
            if (String.IsNullOrEmpty(p.Direccion))
            { errCnt++; DireccionBrush = errorBrush; }
            else DireccionBrush = okBrush;
            if (String.IsNullOrEmpty(p.Vendedor))
            { errCnt++; NombreVendedorBrush = errorBrush; }
            else NombreVendedorBrush = okBrush;
            if (String.IsNullOrEmpty(p.Categoria))
            { errCnt++; NombreCategoriaBrush = errorBrush; }
            else NombreCategoriaBrush = okBrush;

            if (!ChkUnitCost(p.Precio))
            { errCnt++; CostBrush = errorBrush; }

            if (errCnt == 0) { Status = "OK"; return true; }
            else { Status = "Agregar Inmueble, falta un campo o esta incorrecto."; return false; }
        }


        // VERIFICAR SI SE COMPLETAN LOS DEMAS CAMPOS AL EDITAR UN INMUEBLE
        public bool ChkProductForUpdate(Inmueble p)
        {
            int errCnt = 0;
            if (String.IsNullOrEmpty(p.Direccion))
            { errCnt++; DireccionBrush = errorBrush; }
            else DireccionBrush = okBrush;
            if (String.IsNullOrEmpty(p.Vendedor))
            { errCnt++; NombreVendedorBrush = errorBrush; }
            else NombreVendedorBrush = okBrush;
            if (String.IsNullOrEmpty(p.Categoria))
            { errCnt++; NombreCategoriaBrush = errorBrush; }
            else NombreCategoriaBrush = okBrush;

            if (!ChkUnitCost(p.Precio))
            { errCnt++; CostBrush = errorBrush; }
            else CostBrush = okBrush;

            if (errCnt == 0) { Status = "OK"; return true; }
            else { Status = "Editar Inmueble, falta un campo o esta incorrecto."; return false; }
        }

    }
}
