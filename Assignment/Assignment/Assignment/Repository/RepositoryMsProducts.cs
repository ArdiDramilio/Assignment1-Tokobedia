using Assignment.Factory;
using Assignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment.Repository
{
 
    public class RepositoryMsProducts
    {
        static TokobediaEntities2 TokobeEntities = new TokobediaEntities2();

        public static void InsertProduct(Int64 ID,String TypeID, String Name, int Price, int Stock)
        {
            TokobeEntities.MsProducts.Add(FactoryProduct.InitProduct(ID, TypeID, Name, Price, Stock));
            TokobeEntities.SaveChanges();
        }
        public static void DeleteProduct(String ID)
        {
            MsProducts product = SearchProductByID(ID);
            TokobeEntities.MsProducts.Remove(product);
            TokobeEntities.SaveChanges();
        }
        public static void UpdateProduct(String ID, String Name, int Price, int Stock)
        {
            MsProducts product = SearchProductByID(ID);
            product.ProductName = Name;
            product.ProductPrice = Price;
            product.ProductStock = Stock;
            TokobeEntities.SaveChanges();
        }
        public static int CountData()
        {
           return (from y in TokobeEntities.MsProducts
                  where y.ProductID != null
                  select y).Count();
        }
        public static MsProducts SearchProductByID(String ID)
        {
            return (from x in TokobeEntities.MsProducts
                               where x.ProductID ==ID
                               select x).FirstOrDefault();
        }
        public static MsProducts SearchProductByTypeID(String ID)
        {
            return (from x in TokobeEntities.MsProducts
                    where x.ProductTypeID == ID
                    select x).FirstOrDefault();
        }
        public static List<DatTemp> FetchDataRandom()
        {
            Random randd = new Random();
            int id = CountData();
            int[] rando = new int[5];
            for (int i = 0; i < 5; i++)
            {
                int temp = randd.Next(id + 1);
                while (temp == rando[0] || temp == rando[1] || temp == rando[2] || temp == rando[3] || temp == rando[4])
                {
                    temp = randd.Next(id + 1);
                }
                rando[i] = temp;
            }
            String ran1 = "PT" + rando[0];
            String ran2 = "PT" + rando[1];
            String ran3 = "PT" + rando[2];
            String ran4 = "PT" + rando[3];
            String ran5 = "PT" + rando[4];
            return (from x in TokobeEntities.MsProducts
                            join y in TokobeEntities.MsProductTypes
                            on x.ProductTypeID equals y.ProductTypeID
                            where x.ProductID == ran5 || x.ProductID == ran2 || x.ProductID == ran1 || x.ProductID == ran4 || x.ProductID == ran3
                            select new DatTemp
                            {
                                ProductID = x.ProductID,
                                ProductName = x.ProductName,
                                ProductsStock = x.ProductStock,
                                ProductType = y.ProductTypeName,
                                ProductPrice = x.ProductPrice
                            }).ToList();
        }
        public static List<DatTemp> FetchDataProduct()
        {
               return (from x in TokobeEntities.MsProducts
                            join y in TokobeEntities.MsProductTypes
                            on x.ProductTypeID equals y.ProductTypeID
                            orderby x.ProductID ascending
                            select new DatTemp
                            {
                                ProductID = x.ProductID,
                                ProductName = x.ProductName,
                                ProductsStock = x.ProductStock,
                                ProductType = y.ProductTypeName,
                                ProductPrice = x.ProductPrice
                            }).ToList();
        }
    }
}