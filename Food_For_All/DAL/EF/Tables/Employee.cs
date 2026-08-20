using System;
using System.Collections.Generic;

namespace DAL.EF.Tables;

public partial class Employee
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public long Phone { get; set; }

    public string? Email { get; set; }

    public string Status { get; set; } = null!;

    public virtual ICollection<CollectRequest> CollectRequests { get; set; } = new List<CollectRequest>();

    public virtual ICollection<Distribution> Distributions { get; set; } = new List<Distribution>();
}
