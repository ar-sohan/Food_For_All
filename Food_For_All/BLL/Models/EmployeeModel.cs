using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Text;

namespace BLL.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; } = null!;
        [Required]
        [StringLength(15)]
        public long Phone { get; set; }

        public string? Email { get; set; }
        [Required]
        [StringLength(10)]
        public string Status { get; set; } = null!;
    }
}
