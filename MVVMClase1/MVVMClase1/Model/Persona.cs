using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMClase1.Model
{
    public class Persona : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // Propiedad CLR
        int contador;
        public int Contador {
            get { return contador; }
            set
            {
                if (value < 0)
                    throw new Exception("No se admiten valores negativos");
                contador = value;
                OnPropertyChange("Contador");
            }
        }

        string nombre;
        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                OnPropertyChange("Nombre");
            }
        }

        string apellido;
        public string Apellido
        {
            get { return apellido; }
            set
            {
                apellido = value;
                OnPropertyChange("Apellido");
            }
        }

        // Auto Propiedades
        public int ID { get; set; }

        private void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
