using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ItemPackUser
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public string? ItemPack { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }
}
