using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using FinalMVVMInmobiliaria.Model;

namespace FinalMVVMInmobiliaria.ViewModel
{
    public class InmueblesViewModel : INotifyPropertyChanged
    {
        private string _id;
        private string _fechaPublicacion;
        private string _idVendedor;
        private string _direccion;
        private string _ambientes;
        private int _precio;
        private bool _reservado;

        public InmueblesViewModel()
        {

        }

        public string ID
        {
            get { return _id; }
            set
            {
                _id = value;
                NotifyOfPropertyChange("ID");
            }
        }

        public string FechaPublicacion
        {
            get { return _fechaPublicacion; }
            set
            {
                _fechaPublicacion = Convert.ToDateTime(value).ToString("MM/dd/yyyy");
                NotifyOfPropertyChange("Fecha Publicacion");
            }
        }

        public string IDVendedor
        {
            get { return _idVendedor; }
            set
            {
                _idVendedor = value;
                NotifyOfPropertyChange("ID Vendedor");
            }
        }

        public string Direccion
        {
            get { return _direccion; }
            set
            {
                _direccion = value;
                NotifyOfPropertyChange("Direccion");
            }
        }

        public string Ambientes
        {
            get { return _ambientes; }
            set
            {
                _ambientes = value;
                NotifyOfPropertyChange("Ambientes");
            }
        }

        public int Precio
        {
            get { return _precio; }
            set
            {
                _precio = value;
                NotifyOfPropertyChange("Precio");
            }
        }

        public bool Rservado
        {
            get { return _reservado; }
            set
            {
                _reservado = value;
                NotifyOfPropertyChange("Reservado");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyOfPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
