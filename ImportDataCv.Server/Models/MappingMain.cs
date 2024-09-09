using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class MappingMain
{
    public int Id { get; set; }

    /// <summary>
    /// Danh sách tất cả key (Code Y/C đặt hàng, Code Dự án...)
    /// </summary>
    public string? ObjRootCode { get; set; }

    /// <summary>
    /// PROJECT, PO_BUY, PO_SALE, ORDER, REQ_PRICE
    /// </summary>
    public string? ObjType { get; set; }

    public string? ObjCode { get; set; }

    /// <summary>
    /// (Chính, Hỗ trợ, Bổ sung, Phụ lục)
    /// </summary>
    public string? ObjRelative { get; set; }

    public string? ObjNote { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? ObjRootType { get; set; }
}
