using System;
using System.ComponentModel;
using System.Windows.Threading;

namespace WpfMVVM2018.MVVM.Model
{
    public class Persona : INotifyPropertyChanged
    {
        DispatcherTimer timer;

        public Persona()
        {
            Apellido = "";
            Nombre = "";
            Edad = 1;
            //ID
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += Cumpleanios;
            timer.Start();
        }

        private void Cumpleanios(object sender, EventArgs e)
        {
            Edad++;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        int edad;
        public int Edad
        {
            get { return edad; }
            set {
                if (value < 0)
                    return;
                edad = value;
                OnPropertyChange("Edad");
            }
        }





        int contador;
        //propiedad CLR
        public int Contador {
            get { return contador; }
            set
            {
                if (value < 0)
                    throw new Exception("No se admiten numeros negativos!!");
                contador = value;
                OnPropertyChange("Contador");
            }
        }
        /// <summary>
        /// Metodo que lanza el evento PropertyChanged
        /// </summary>
        /// <param name="propertyName"></param>
        private void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }


        //Auto Propiedades
        public int ID { get; set; }

        string nombre;
        public string Nombre {
            get { return nombre; }
            set {
                nombre = value;
                OnPropertyChange("Nombre");
            }
        }

        string apellido;
        public string Apellido {
            get { return apellido; }
            set
            {
                apellido = value;
                OnPropertyChange("Apellido");
            }
        }

    }
}
