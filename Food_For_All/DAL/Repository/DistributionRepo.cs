using DAL.EF;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class DistributionRepo
    {
        FoodForAllContext db;
        public DistributionRepo(FoodForAllContext context)
        {
            db = context;
        }

        public List<Distribution> GetAllDistributions()
        {
            return db.Distributions.ToList();
        }

        public Distribution GetDistributionById(int id)
        {
            return db.Distributions.Find(id);
        }
        public bool AddDistribution(Distribution distribution)
        {
            var data = db.CollectRequests.Find(distribution.RequestId);
            if (data == null)
            {
                return false;
            }
            data.Status = "Distributed";
            db.Distributions.Add(distribution);
            return db.SaveChanges() > 0;
        }
    }
}
