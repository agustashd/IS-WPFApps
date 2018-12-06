using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvvmFoundation.Wpf;
using System.ComponentModel;
using System.Windows.Input;
using System.Windows.Media;



namespace MVVMInmobiliaria.ViewModels
{
    public class InmuebleDisplayModel : INotifyPropertyChanged
    {
        private bool isSelected = false;


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }
        
        private readonly InmuebleDisplayModelStatus stat = new InmuebleDisplayModelStatus();
        public InmuebleDisplayModelStatus Stat { get { return stat; } }

        private Inmueble displayedProduct = new Inmueble();
        public Inmueble DisplayedProduct
        {
            get { return displayedProduct; }
            set { displayedProduct = value; OnPropertyChanged(new PropertyChangedEventArgs("DisplayedProduct")); }
        }

        // COMMANDOS PARA MOSTRAR BOTONES O DESHABILITARLOS
        // BOTON RECARGAR TABLA CON VALORES
        private RelayCommand getProductsCommand;
        public ICommand GetProductsCommand
        {
            get { return getProductsCommand ?? (getProductsCommand = new RelayCommand(() => GetInmuebles())); }
        }

        private void GetInmuebles()
        {
            isSelected = false;
            stat.NoError();
            DisplayedProduct = new Inmueble();
            App.Messenger.NotifyColleagues("GetInmuebles");
        }

        // BOTON LIMPIAR CAMPOS A COMPLETAR
        private RelayCommand clearCommand;
        public ICommand ClearCommand
        {
            get { return clearCommand ?? (clearCommand = new RelayCommand(() => ClearProductDisplay())); }
        }

        private void ClearProductDisplay()
        {
            isSelected = false;
            stat.NoError();
            DisplayedProduct = new Inmueble();
            App.Messenger.NotifyColleagues("ProductCleared");
        }


        // BOTON ACTUALIZAR INMUEBLE
        private RelayCommand updateCommand;
        public ICommand UpdateCommand
        {
            get { return updateCommand ?? (updateCommand = new RelayCommand(() => UpdateInmueble(), ()=>isSelected)); }
        }
        private void UpdateInmueble()
        {
            if (!stat.ChkProductForUpdate(DisplayedProduct)) return;
                if(!App.StoreDB.UpdateInmueble(DisplayedProduct))
                {
                    stat.Status = App.StoreDB.errorMessage;
                    return;
                }
                App.Messenger.NotifyColleagues("UpdateInmueble", DisplayedProduct);
        }

        // BOTON BORRAR INMUEBLE
        private RelayCommand deleteCommand;
        public ICommand DeleteCommand
        {
            get { return deleteCommand ?? (deleteCommand = new RelayCommand(() => DeleteInmueble(), () => isSelected)); }
        }
        private void DeleteInmueble()
        {
            if (!App.StoreDB.DeleteInmueble(DisplayedProduct._ProductId))
            {
                stat.Status = App.StoreDB.errorMessage;
                return;
            }
            isSelected = false;
            App.Messenger.NotifyColleagues("DeleteInmueble");
        }

        // BOTON AGREGAR INMUEBLE
        private RelayCommand addCommand;
        public ICommand AddCommand
        {
            get { return addCommand ?? (addCommand = new RelayCommand(() => AddInmueble(), () => !isSelected)); }
        }
        private void AddInmueble()
        {
            if (!stat.ChkProductForAdd(DisplayedProduct)) return;
            if (!App.StoreDB.AddInmueble(DisplayedProduct))
            {
                stat.Status = App.StoreDB.errorMessage;
                return;
            }
            App.Messenger.NotifyColleagues("AddInmueble", DisplayedProduct);
        }

        // PROCESAR INMUEBLE EDITADO
        public InmuebleDisplayModel()
        {
            Messenger messenger = App.Messenger;
            messenger.Register("ProductSelectionChanged", (Action<Inmueble>)(param => ProcessProduct(param)));
            messenger.Register("SetStatus", (Action<String>)(param => stat.Status = param));
        }
        public void ProcessProduct(Inmueble inmueble)
        {
            if (inmueble == null) { isSelected = false;  return; }
            Inmueble temp = new Inmueble();
            temp.CopyProduct(inmueble);
            DisplayedProduct = temp;
            isSelected = true;
            stat.NoError();
        }
    }
}
