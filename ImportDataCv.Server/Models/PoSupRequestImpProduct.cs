using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class PoSupRequestImpProduct
{
    public int Id { get; set; }

    /// <summary>
    /// Mã Po sup
    /// </summary>
    public string? PoSupCode { get; set; }

    /// <summary>
    /// Mã yêu cầu nhập khẩu
    /// </summary>
    public string? ReqCode { get; set; }
}
