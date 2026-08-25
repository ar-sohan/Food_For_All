using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BLL.Models
{
    public class DistributionModel
    {

        public int Id { get; set; }
        [Required]
        public DateOnly DistributionDate { get; set; }
        [Required]
        public int QuantityDistributed { get; set; }
        [Required]
        [StringLength(50)]
        public string Location { get; set; } = null!;
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public int RequestId { get; set; }
    }
}
