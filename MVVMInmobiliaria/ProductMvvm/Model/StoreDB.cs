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
        
        public MyObservableCollection<Product> GetProducts()
        {
            hasError = false;
            MyObservableCollection<Product> products = new MyObservableCollection<Product>();
            try
            {
                LinqDataContext dc = new LinqDataContext();
                var query = from q in dc.LinqProducts
                    select new SqlProduct{
                        ProductId = q.ProductID, ModelNumber = q.ModelNumber,
                        ModelName=q.ModelName, UnitCost = (decimal)q.UnitCost,
                        Description = q.Description, CategoryName = q.LinqCategory.CategoryName
                    };
                foreach (SqlProduct sp in query)
                    products.Add(sp.SqlProduct2Product());
            } //try
            catch(Exception ex)
            {
                errorMessage = "GetProducts() error, " + ex.Message;
                hasError = true;
            }
            return products;
        } //GetProducts()

        public bool UpdateProduct(Product displayP)
        {
            try
            {
                SqlProduct p = new SqlProduct(displayP);
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

        public bool AddProduct(Product displayP)
        {
            hasError = false;
            try
            {
                SqlProduct p = new SqlProduct(displayP);
                LinqDataContext dc = new LinqDataContext();
                int? newProductId = 0;
                dc.AddProduct(p.CategoryName, p.ModelNumber, p.ModelName, p.UnitCost, p.Description, ref newProductId);
                p.ProductId = (int)newProductId;
                displayP.ProductAdded2DB(p);    //update corresponding Product ProductId using SqlProduct
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
