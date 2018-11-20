using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace MVVMInmobiliaria.ViewModels
{
    public class Inmueble
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }

        private int _productId;
        public int _ProductId { get { return _productId; } }

        private string modelNumber;
        public string ModelNumber
        {
            get { return modelNumber; }
            set { modelNumber = value; OnPropertyChanged(new PropertyChangedEventArgs("ModelNumber"));
                }
        }

        private string modelName;
        public string ModelName
        {
            get { return modelName; }
            set { modelName = value; OnPropertyChanged(new PropertyChangedEventArgs("ModelName")); }
        }

        private string unitCost;
        public string UnitCost
        {
            get { return unitCost; }
            set { unitCost = value; OnPropertyChanged(new PropertyChangedEventArgs("UnitCost")); }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; OnPropertyChanged(new PropertyChangedEventArgs("Description")); }
        }

        private string categoryName;
        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; OnPropertyChanged(new PropertyChangedEventArgs("CategoryName")); }
        }

        // STRING PARA MOSTRAR EN PANTALLA
        public string InmuebleCompleto
        {
            get {return ModelNumber + "\t|\t" + ModelName + "\t|\t" + UnitCost + "\t|\t" + CategoryName; }
        }

        public Inmueble()
        {
        }

        public Inmueble(int productId, string modelNumber, string modelName,
                       string unitCost, string description, string categoryName)
        {
            this._productId = productId;
            ModelNumber = modelNumber;
            ModelName = modelName;
            UnitCost = unitCost;
            Description = description;
            CategoryName = categoryName;
        }

        public void CopyProduct(Inmueble inmueble)
        {
            this._productId = inmueble._ProductId;
            this.ModelNumber = inmueble.ModelNumber;
            this.ModelName = inmueble.ModelName;
            this.UnitCost = inmueble.UnitCost;
            this.CategoryName = inmueble.CategoryName;
            this.Description = inmueble.Description;
        }

        public void ProductAdded2DB(SqlInmueble sqlInmueble)
        {
            this._productId = sqlInmueble.InmuebleId;
        }


    }

    //Clase para comounicarse con SQL
    public class SqlInmueble
    {
        public int InmuebleId { get; set; }
        public string Direccion {get; set;}
        public string Vendedor {get; set;}
        public decimal Precio {get; set;}
        public string Descripcion {get; set;}
        public string Categoria {get; set;}

        public SqlInmueble() { }

        public SqlInmueble(int inmuebleId, string direccion, string vendedor,
                       decimal precio, string descripcion, string categoria)
        {
            InmuebleId = inmuebleId;
            Direccion = direccion;
            Vendedor = vendedor;
            Precio = precio;
            Descripcion = descripcion;
            Categoria = categoria;
        }

        public SqlInmueble(Inmueble inmueble)
        {
            InmuebleId = inmueble._ProductId;
            Direccion = inmueble.ModelNumber;
            Vendedor = inmueble.ModelName;
            Precio = Convert.ToDecimal(inmueble.UnitCost);
            Descripcion = inmueble.Description;
            Categoria = inmueble.CategoryName;
        }

        public Inmueble SqlProduct2Product()
        {
            string precio = Precio.ToString();
            return new Inmueble(InmuebleId, Direccion, Vendedor, precio, Descripcion, Categoria);
        }
    }

}
