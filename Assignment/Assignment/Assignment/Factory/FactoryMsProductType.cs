using Assignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment.Factory
{
    public class FactoryMsProductType
    {
        public static MsProductType InitProductType(Int64 ID,String Name,String Desc)
        {
            MsProductType ProductType = new MsProductType();
            ProductType.ProductTypeID = "PY" + ID;
            ProductType.ProductTypeName = Name;
            ProductType.ProductTypeDescription = Desc;
            return ProductType;
        }
    }
}