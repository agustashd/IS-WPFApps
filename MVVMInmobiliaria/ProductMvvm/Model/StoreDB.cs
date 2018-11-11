using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
using MVVMInmobiliaria;
using MVVMInmobiliaria.ViewModels;

namespace MVVMInmobiliaria.Model
{
    public class StoreDB
    {
        public bool hasError = false;
        public string errorMessage;
        
        public MyObservableCollection<Inmueble> GetProducts()
        {
            hasError = false;
            MyObservableCollection<Inmueble> products = new MyObservableCollection<Inmueble>();
            try
            {
                LinqDataContext dc = new LinqDataContext();
                var query = from q in dc.LinqProducts
                    select new SqlInmueble{
                        ProductId = q.ProductID, ModelNumber = q.ModelNumber,
                        ModelName=q.ModelName, UnitCost = (decimal)q.UnitCost,
                        Description = q.Description, CategoryName = q.LinqCategory.CategoryName
                    };
                foreach (SqlInmueble sp in query)
                    products.Add(sp.SqlProduct2Product());
            } //try
            catch(Exception ex)
            {
                errorMessage = "GetProducts() error, " + ex.Message;
                hasError = true;
            }
            return products;
        } //GetProducts()

        public bool UpdateProduct(Inmueble displayP)
        {
            try
            {
                SqlInmueble p = new SqlInmueble(displayP);
                LinqDataContext dc = new LinqDataContext();
                dc.UpdateProduct(p.ProductId, p.CategoryName, p.ModelNumber, p.ModelName, p.UnitCost, p.Description);
            }
            catch (Exception ex)
            {
                errorMessage = "Update error, " + ex.Message;
                hasError = true;
            }
            return (!hasError);
        } //UpdateProduct()

        public bool DeleteProduct(int productId)
        {
            hasError = false;
            try
            {
                LinqDataContext dc = new LinqDataContext();
                dc.DeleteProduct(productId);
            }
            catch (Exception ex)
            {
                errorMessage = "Delete error, " + ex.Message;
                hasError = true;
            }
            return !hasError;
        }// DeleteProduct()

        public bool AddProduct(Inmueble displayP)
        {
            hasError = false;
            try
            {
                SqlInmueble p = new SqlInmueble(displayP);
                LinqDataContext dc = new LinqDataContext();
                int? newProductId = 0;
                dc.AddProduct(p.CategoryName, p.ModelNumber, p.ModelName, p.UnitCost, p.Description, ref newProductId);
                p.ProductId = (int)newProductId;
                displayP.ProductAdded2DB(p);    //update corresponding Inmueble ProductId using SqlInmueble
            }
            catch (Exception ex)
            {
                errorMessage = "Add error, " + ex.Message;
                hasError = true;
            }
            return !hasError;
        } //AddProduct()
    } //class StoreDB
}
