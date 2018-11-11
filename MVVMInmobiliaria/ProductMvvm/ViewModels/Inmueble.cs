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

        public void CopyProduct(Inmueble p)
        {
            this._productId = p._ProductId;
            this.ModelNumber = p.ModelNumber;
            this.ModelName = p.ModelName;
            this.UnitCost = p.UnitCost;
            this.CategoryName = p.CategoryName;
            this.Description = p.Description;
        }

        public void ProductAdded2DB(SqlInmueble sqlProduct)
        {
            this._productId = sqlProduct.ProductId;
        }

    }

    //Clase para comounicarse con SQL
    public class SqlInmueble
    {
        public int ProductId { get; set; }
        public string ModelNumber {get; set;}
        public string ModelName {get; set;}
        public decimal UnitCost {get; set;}
        public string Description {get; set;}
        public string CategoryName {get; set;}

        public SqlInmueble() { }

        public SqlInmueble(int productId, string modelNumber, string modelName,
                       decimal unitCost, string description, string categoryName)
        {
            ProductId = productId;
            ModelNumber = modelNumber;
            ModelName = modelName;
            UnitCost = unitCost;
            Description = description;
            CategoryName = categoryName;
        }

        public SqlInmueble(Inmueble p)
        {
            ProductId = p._ProductId;
            ModelNumber = p.ModelNumber;
            ModelName = p.ModelName;
            UnitCost = Convert.ToDecimal(p.UnitCost);
            Description = p.Description;
            CategoryName = p.CategoryName;
        }

        public Inmueble SqlProduct2Product()
        {
            string unitCost = UnitCost.ToString();
            return new Inmueble(ProductId, ModelNumber, ModelName, unitCost, Description, CategoryName);
        }
    }

}
