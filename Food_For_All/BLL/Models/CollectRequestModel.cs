using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
    public class CollectRequestModel
    {
        public int Id { get; set; }

        public int MaxPreserveUnit { get; set; }

        public string Status { get; set; } = null!;

        public int RestaurentId { get; set; }

        public int? EmployeeId { get; set; }

        public string FoodDetails { get; set; } = null!;

        public string RequestTime { get; set; } = null!;
    }
}
