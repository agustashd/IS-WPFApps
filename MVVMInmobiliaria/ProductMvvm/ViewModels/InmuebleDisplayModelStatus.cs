using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Media;


namespace MVVMInmobiliaria.ViewModels
{
    // CHEQUEA ESTADO DEL MODELO EN LOS UPDATES Y DELETES
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

        private SolidColorBrush modelNumberBrush = okBrush;
        public SolidColorBrush ModelNumberBrush
        {
            get { return modelNumberBrush; }
            set { modelNumberBrush = value; OnPropertyChanged(new PropertyChangedEventArgs("ModelNumberBrush")); }
        }

        private SolidColorBrush modelNameBrush = okBrush;
        public SolidColorBrush ModelNameBrush
        {
            get { return modelNameBrush; }
            set { modelNameBrush = value; OnPropertyChanged(new PropertyChangedEventArgs("ModelNameBrush")); }
        }

        private SolidColorBrush categoryNameBrush = okBrush;
        public SolidColorBrush CategoryNameBrush
        {
            get { return categoryNameBrush; }
            set { categoryNameBrush = value; OnPropertyChanged(new PropertyChangedEventArgs("CategoryNameBrush")); }
        }

        private SolidColorBrush unitCostBrush = okBrush;
        public SolidColorBrush UnitCostBrush
        {
            get { return unitCostBrush; }
            set { unitCostBrush = value; OnPropertyChanged(new PropertyChangedEventArgs("UnitCostBrush")); }
        }


        // ESTADO SIN ERRORES
        public void NoError()
        {
            ModelNumberBrush = ModelNameBrush = CategoryNameBrush = UnitCostBrush = okBrush;
            Status = "Estado correcto";
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
            if (String.IsNullOrEmpty(p.ModelNumber))
            { errCnt++; ModelNumberBrush = errorBrush; }
            else ModelNumberBrush = okBrush;
            if (String.IsNullOrEmpty(p.ModelName))
            { errCnt++; ModelNameBrush = errorBrush; }
            else ModelNameBrush = okBrush;
            if (String.IsNullOrEmpty(p.CategoryName))
            { errCnt++; CategoryNameBrush = errorBrush; }
            else CategoryNameBrush = okBrush;

            if (!ChkUnitCost(p.UnitCost))
            { errCnt++; UnitCostBrush = errorBrush; }

            if (errCnt == 0) { Status = "OK"; return true; }
            else { Status = "Agregar Inmueble, falta un campo o esta incorrecto."; return false; }
        }


        // VERIFICAR SI SE COMPLETAN LOS DEMAS CAMPOS AL EDITAR UN INMUEBLE
        public bool ChkProductForUpdate(Inmueble p)
        {
            int errCnt = 0;
            if (String.IsNullOrEmpty(p.ModelNumber))
            { errCnt++; ModelNumberBrush = errorBrush; }
            else ModelNumberBrush = okBrush;
            if (String.IsNullOrEmpty(p.ModelName))
            { errCnt++; ModelNameBrush = errorBrush; }
            else ModelNameBrush = okBrush;
            if (String.IsNullOrEmpty(p.CategoryName))
            { errCnt++; CategoryNameBrush = errorBrush; }
            else CategoryNameBrush = okBrush;

            if (!ChkUnitCost(p.UnitCost))
            { errCnt++; UnitCostBrush = errorBrush; }
            else UnitCostBrush = okBrush;

            if (errCnt == 0) { Status = "OK"; return true; }
            else { Status = "Editar Inmueble, falta un campo o esta incorrecto."; return false; }
        }

    }
}
