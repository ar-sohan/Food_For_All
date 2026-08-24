using DAL.EF;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class EmployeeRepo
    {
        FoodForAllContext db;
        public EmployeeRepo(FoodForAllContext db) { 
            this.db = db;
        }

        
    }
}
