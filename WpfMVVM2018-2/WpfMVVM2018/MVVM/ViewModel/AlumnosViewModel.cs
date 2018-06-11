﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMVVM2018.MVVM.Model;

namespace WpfMVVM2018.MVVM.ViewModel
{
    public class AlumnosViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// emula una "Base de datos" de alumnos
        /// </summary>
        public ObservableCollection<Persona> Alumnos { get; private set; }

        int indice;
        public int Indice
        {
            get { return indice; }
            set {
                if (value < 0 || value > Alumnos.Count - 1)
                    return;

                if (value != indice)
                {
                    indice = value;
                    OnPropertyChange("Indice");
                    OnPropertyChange("AlumnoSeleccionado");
                }
            }
        }

        public Persona AlumnoSeleccionado
        {
            get { return Alumnos[indice]; }
        }

        public AlumnosViewModel()
        {
            Alumnos = new ObservableCollection<Persona>();
            Alumnos.Add(new Persona() {
                Apellido = "Rodriguez",
                Nombre = "Lucia",
                Edad = 22
            });
            Alumnos.Add(new Persona()
            {
                Apellido = "Perez",
                Nombre = "Eva",
                Edad = 27
            });

        }

        private void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
        }


    }
}
