using Assignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment.Repository
{
    public class RepositoryDetailTrans
    {
        static TokobediaEntities2 TokobeEntities = new TokobediaEntities2();

        public static DetailTran SearchDetailByID(String ID)
        {
           return (from y in TokobeEntities.DetailTrans
                                    where y.ProductID == ID
                                    select y).FirstOrDefault();
        }
    }
}