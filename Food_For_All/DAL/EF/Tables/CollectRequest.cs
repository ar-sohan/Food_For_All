using System;
using System.Collections.Generic;

namespace DAL.EF.Tables;

public partial class CollectRequest
{
    public int Id { get; set; }

    public byte[] MaxPreserveTime { get; set; } = null!;

    public string Status { get; set; } = null!;

    public int RestaurentId { get; set; }

    public int? EmployeeId { get; set; }

    public string FoodDetails { get; set; } = null!;

    public string RequestTime { get; set; } = null!;

    public virtual ICollection<Distribution> Distributions { get; set; } = new List<Distribution>();

    public virtual Employee? Employee { get; set; }

    public virtual Restaurent Restaurent { get; set; } = null!;
}
