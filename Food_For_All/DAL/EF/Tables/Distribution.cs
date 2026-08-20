using System;
using System.Collections.Generic;

namespace DAL.EF.Tables;

public partial class Distribution
{
    public int Id { get; set; }

    public DateOnly DistributionDate { get; set; }

    public int QuantityDistributed { get; set; }

    public string Location { get; set; } = null!;

    public int EmployeeId { get; set; }

    public int RequestId { get; set; }

    public virtual Employee Employee { get; set; } = null!;

    public virtual CollectRequest Request { get; set; } = null!;
}
