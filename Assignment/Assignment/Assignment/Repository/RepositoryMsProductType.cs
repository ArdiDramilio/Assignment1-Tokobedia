using Assignment.Factory;
using Assignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment.Repository
{
    public class RepositoryMsProductType
    {
        static TokobediaEntities2 TokobeEntities = new TokobediaEntities2();
 
        public static void InsertType(Int64 ID,String TypeName,String Desc)
        {
            TokobeEntities.MsProductTypes.Add(FactoryMsProductType.InitProductType(ID, TypeName, Desc));
            TokobeEntities.SaveChanges();
        }
        public static void DeleteType(String ID)
        {
            MsProductType product = SearchTypeByID(ID);
            TokobeEntities.MsProductTypes.Remove(product);
            TokobeEntities.SaveChanges();
        }
        public static void UpdateType(String ID,String TypeName, String Desc)
        {
            MsProductType product = SearchTypeByID(ID);
            product.ProductTypeName = TypeName;
            product.ProductTypeDescription = Desc;
            TokobeEntities.SaveChanges();
        }
        public static MsProductType SearchTypeByID(String ID)
        {
             return (from b in TokobeEntities.MsProductTypes
                                       where b.ProductTypeID == ID
                                       select b).FirstOrDefault();
        }
        public static MsProductType SearchTypeByName(String Name)
        {
            return (from b in TokobeEntities.MsProductTypes
                                      where b.ProductTypeName == Name
                                      select b).FirstOrDefault();
        }
        public static int CountData()
        {
            return (from y in TokobeEntities.MsProductTypes
                  where y.ProductTypeID != null
                  select y).Count();
        }
        public static List<DatTemp1> FetchData()
        {
            TokobediaEntities2 db = new TokobediaEntities2();
           return (from x in db.MsProductTypes
                        select new DatTemp1
                        {
                            ProductTypeID = x.ProductTypeID,
                            ProductTypeName = x.ProductTypeName,
                            ProductTypeDesc = x.ProductTypeDescription
                        }).ToList();
        }
    }
}