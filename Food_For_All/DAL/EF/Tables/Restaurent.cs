using System;
using System.Collections.Generic;

namespace DAL.EF.Tables;

public partial class Restaurent
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Status { get; set; } = null!;

    public virtual ICollection<CollectRequest> CollectRequests { get; set; } = new List<CollectRequest>();
}
