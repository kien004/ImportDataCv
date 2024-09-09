using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class RmVayxeActivityRequestStatusDelivery
{
    public int Id { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int IsDeleted { get; set; }

    public int IsDisable { get; set; }

    public string? RequestCode { get; set; }

    public int Status { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
