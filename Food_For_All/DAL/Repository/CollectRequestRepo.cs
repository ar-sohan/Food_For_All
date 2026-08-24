using DAL.EF;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class CollectRequestRepo
    {
        FoodForAllContext db;

        public CollectRequestRepo(FoodForAllContext context)
        {
            db = context;
        }

        public bool AddCollectRequest(CollectRequest collectRequest)
        {
            db.CollectRequests.Add(collectRequest);
            return db.SaveChanges() > 0;
        }
    }
}
