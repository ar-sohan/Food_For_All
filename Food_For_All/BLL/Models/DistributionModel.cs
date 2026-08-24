using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
    public class DistributionModel
    {
        public int Id { get; set; }

        public DateOnly DistributionDate { get; set; }

        public int QuantityDistributed { get; set; }

        public string Location { get; set; } = null!;

        public int EmployeeId { get; set; }

        public int RequestId { get; set; }
    }
}
