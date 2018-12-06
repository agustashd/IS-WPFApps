using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows.Input;
using System.Linq;
using System.Text;
using System.ComponentModel;
using MvvmFoundation.Wpf;

namespace MVVMInmobiliaria.ViewModels
{
    public class InmuebleSelectionModel : INotifyPropertyChanged
    {
        // MANEJO DE EVENTOS QUE LANZAN LOS COMANDOS, SE LLAMA A LOS METODOS DEL MODELO
        public InmuebleSelectionModel()
        {
            dataItems = new MyObservableCollection<Inmueble>();
            DataItems = App.StoreDB.GetInmuebles();
            listBoxCommand = new RelayCommand(() => SelectionHasChanged());
            App.Messenger.Register("ProductCleared", (Action)(() => SelectedProduct=null));
            App.Messenger.Register("GetInmuebles", (Action)(() => GetInmuebles()));
            App.Messenger.Register("UpdateInmueble",  (Action<Inmueble>)(param => UpdateInmueble(param)));
            App.Messenger.Register("DeleteInmueble", (Action)(() => DeleteInmueble()));
            App.Messenger.Register("AddInmueble", (Action<Inmueble>)(param => AddInmueble(param)));
        }

        // TRAER INMUEBLES
        private void GetInmuebles()
        {
            DataItems = App.StoreDB.GetInmuebles();
            if (App.StoreDB.hasError)
                App.Messenger.NotifyColleagues("SetStatus", App.StoreDB.errorMessage);
        }

        // AGREGAR INMUEBLES
        private void AddInmueble(Inmueble inmueble)
        {
            dataItems.Add(inmueble);
        }

        // ACTUALIZAR INMUEBLE
        private void UpdateInmueble(Inmueble inmueble)
        {
            int index = dataItems.IndexOf(selectedProduct);
            dataItems.ReplaceItem(index, inmueble);
            SelectedProduct = inmueble;
        }

        // BOORAR INMUEBLE
        private void DeleteInmueble()
        {
            dataItems.Remove(selectedProduct);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }


        private MyObservableCollection<Inmueble> dataItems;
        public MyObservableCollection<Inmueble> DataItems
        {
            get { return dataItems; }
            set { dataItems = value; OnPropertyChanged(new PropertyChangedEventArgs("DataItems")); }
        }

        private Inmueble selectedProduct;
        public Inmueble SelectedProduct
        {
            get { return selectedProduct; }
            set { selectedProduct = value; OnPropertyChanged(new PropertyChangedEventArgs("SelectedProduct")); }
        }

        private RelayCommand listBoxCommand;
        public ICommand ListBoxCommand
        {
            get { return listBoxCommand; }
        }

        private void SelectionHasChanged()
        {
            Messenger messenger = App.Messenger;
            messenger.NotifyColleagues("ProductSelectionChanged", selectedProduct);
        }
    }



    public class MyObservableCollection<Inmueble> : ObservableCollection<Inmueble>
    {
        public void UpdateCollection()
        {
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(
                                NotifyCollectionChangedAction.Reset));
        }


        public void ReplaceItem(int index, Inmueble item)
        {
             base.SetItem(index, item);      
        }

    }
}
