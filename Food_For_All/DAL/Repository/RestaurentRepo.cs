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

        public bool CreateRestaurent(Restaurent restaurent)
        {
            db.Restaurents.Add(restaurent);
            return db.SaveChanges() > 0;
        }

        public bool DeleteRestaurent(int id)
        {
            var restaurent = GetRestaurentById(id);
            if (restaurent != null)
            {
                db.Restaurents.Remove(restaurent);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public bool UpdateRestaurent(Restaurent restaurent)
        {
            var existingRestaurent = GetRestaurentById(restaurent.Id);
            if (existingRestaurent != null)
            {
                existingRestaurent.Name = restaurent.Name;
                existingRestaurent.Email = restaurent.Email;
                existingRestaurent.Status = restaurent.Status;
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
