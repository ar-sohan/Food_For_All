using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BLL.Models
{
    public class RestaurentModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;
        [Required] 
        [StringLength(50)]
        public string Email { get; set; } = null!;
        [Required]
        [StringLength (20)]
        public string Status { get; set; } = null!;
    }
}
