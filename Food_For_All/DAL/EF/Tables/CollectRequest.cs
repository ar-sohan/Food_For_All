using System;
using System.Collections.Generic;

namespace DAL.EF.Tables;

public partial class CollectRequest
{
    public int Id { get; set; }

    public int MaxPreserveUnit { get; set; }

    public string Status { get; set; } = null!;

    public int RestaurentId { get; set; }

    public int EmployeeId { get; set; }

    public virtual ICollection<Distribution> Distributions { get; set; } = new List<Distribution>();

    public virtual Employee Employee { get; set; } = null!;

    public virtual Restaurent Restaurent { get; set; } = null!;
}
