using Assignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment.Factory
{
    public class FactoryProduct
    {
        public static MsProducts InitProduct(Int64 ID, String TypeID, String Nama, int Price, int Stock)
        {
            MsProducts products = new MsProducts();
            products.ProductID = "PT" + ID;
            products.ProductTypeID = TypeID;
            products.ProductName = Nama;
            products.ProductPrice = Price;
            products.ProductStock = Stock;

            return products;
        }
    }
}