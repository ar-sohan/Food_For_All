using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public long Phone { get; set; }

        public string? Email { get; set; }

        public string Status { get; set; } = null!;
    }
}
