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

        public List<CollectRequest> GetAllCollectRequests()
        {
            return db.CollectRequests.ToList();
        }
        public bool AddCollectRequest(CollectRequest collectRequest)
        {
            var data = db.Restaurents.Find(collectRequest.RestaurentId);
            if (data == null) { 
                return false;
            }
            db.CollectRequests.Add(collectRequest);
            return db.SaveChanges() > 0;
            
        }

        public bool updateCollectRequest(CollectRequest collectRequest)
        {
            var data = db.CollectRequests.Find(collectRequest.Id);
            if (data == null)
            {
                return false;
            }

            var employee = db.Employees.Find(collectRequest.EmployeeId);
            if (employee == null)
            {
                return false;
            }

            data.Status = collectRequest.Status;
            data.EmployeeId = collectRequest.EmployeeId;
            return db.SaveChanges() > 0;
        }

    }
}
