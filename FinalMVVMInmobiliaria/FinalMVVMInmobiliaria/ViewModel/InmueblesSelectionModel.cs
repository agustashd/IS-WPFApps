using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalMVVMInmobiliaria.ViewModel
{
    class InmueblesSelectionModel
    {
        //SELECCION DE DATOS Y VALIDACIONES CON PROPERTY CHANGE
        public class BandasSelectionModel : INotifyPropertyChanged
        {

            public BandasSelectionModel()
            {
                dataItems = new MyObservableCollection<InmueblesViewModel>();
                DataItems = App.Inmuebles.GetBandas();
                listBoxCommand = new RelayCommand(() => SelectionHasChanged());
                App.Messenger.Register("BandaCleared", (Action)(() => SelectedBanda = null));
                App.Messenger.Register("GetBandas", (Action)(() => GetBandas()));
                App.Messenger.Register("UpdateBanda", (Action<InmueblesViewModel>)(param => UpdateBanda(param)));
                App.Messenger.Register("DeleteBanda", (Action)(() => DeleteBanda()));
                App.Messenger.Register("AddBanda", (Action<InmueblesViewModel>)(param => AddBanda(param)));
            }


            private void GetBandas()
            {
                DataItems = App.Inmuebles.GetBandas();
                if (App.Inmuebles.hasError)
                    App.Messenger.NotifyColleagues("Estado", App.Inmuebles.errorMessage);
            }


            private void AddBanda(InmueblesViewModel p)
            {
                dataItems.Add(p);
            }


            private void UpdateBanda(InmueblesViewModel p)
            {
                int index = dataItems.IndexOf(selectedBanda);
                dataItems.ReplaceItem(index, p);
                SelectedBanda = p;
            }


            private void DeleteBanda()
            {
                dataItems.Remove(selectedBanda);
            }

            public event PropertyChangedEventHandler PropertyChanged;
            public void OnPropertyChanged(PropertyChangedEventArgs e)
            {
                if (PropertyChanged != null)
                    PropertyChanged(this, e);
            }

            private MyObservableCollection<InmueblesViewModel> dataItems;
            public MyObservableCollection<InmueblesViewModel> DataItems
            {
                get { return dataItems; }
                set { dataItems = value; OnPropertyChanged(new PropertyChangedEventArgs("DataItems")); }
            }

            private InmueblesViewModel selectedBanda;
            public InmueblesViewModel SelectedBanda
            {
                get { return selectedBanda; }
                set { selectedBanda = value; OnPropertyChanged(new PropertyChangedEventArgs("SelectedBanda")); }
            }

            private RelayCommand listBoxCommand;
            public ICommand ListBoxCommand
            {
                get { return listBoxCommand; }
            }

            private void SelectionHasChanged()
            {
                Messenger messenger = App.Messenger;
                messenger.NotifyColleagues("BandaSelectionChanged", selectedBanda);
            }
        }



        public class MyObservableCollection<InmueblesViewModel> : ObservableCollection<InmueblesViewModel>
        {
            public void UpdateCollection()
            {
                OnCollectionChanged(new NotifyCollectionChangedEventArgs(
                                    NotifyCollectionChangedAction.Reset));
            }


            public void ReplaceItem(int index, Bandas item)
            {
                base.SetItem(index, item);
            }

        }
    }
}
