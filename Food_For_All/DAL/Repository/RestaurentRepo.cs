using DAL.EF;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class RestaurentRepo
    {
        FoodForAllContext db;
        public RestaurentRepo(FoodForAllContext db)
        {
            this.db = db;
        }

        public List<Restaurent> GetAllRestaurents()
        {
            return db.Restaurents.ToList();
        }

        public Restaurent GetRestaurentById(int id)
        {
            return db.Restaurents.FirstOrDefault(r => r.Id == id);
        }

        public bool AddRestaurent(Restaurent restaurent)
        {
            db.Restaurents.Add(restaurent);
            return db.SaveChanges() > 0;
        }
    }
}
