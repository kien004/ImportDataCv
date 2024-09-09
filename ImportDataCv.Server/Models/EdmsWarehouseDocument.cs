using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class EdmsWarehouseDocument
{
    public int Id { get; set; }

    public string WhsCode { get; set; } = null!;

    public string? QrCode { get; set; }

    public string? WhsName { get; set; }

    public string? WhsNote { get; set; }

    public string? WhsAreaSquare { get; set; }

    public int? WhsCntFloor { get; set; }

    public string? WhsParentCode { get; set; }

    public string? WhsAddrText { get; set; }

    public string? WhsAddrGps { get; set; }

    public string? WhsAvatar { get; set; }

    public string? ImgWhs { get; set; }

    public string? WhsTags { get; set; }

    public string? WhsDesginMap { get; set; }

    public string? WhsStatus { get; set; }

    public string? ManagerId { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public bool WhsFlag { get; set; }

    /// <summary>
    /// PRODUCT(PR), RECORD_VOUCHER (RV)
    /// </summary>
    public string? Type { get; set; }
}
