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
    }
}
