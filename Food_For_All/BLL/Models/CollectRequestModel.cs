using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace BLL.Models
{
    public class CollectRequestModel
    {
        public int Id { get; set; }

        [Required]
        [Timestamp]
        public byte[] MaxPreserveTime { get; set; } = null!;

        [Required]
        [StringLength(10)]
        public string Status { get; set; } = null!;
        [Required]
        public int RestaurentId { get; set; }
        [Required]
        public int? EmployeeId { get; set; }
        [Required]
        [StringLength(50)]
        public string FoodDetails { get; set; } = null!;
        [Required]
        public string RequestTime { get; set; } = null!;
    }
}
