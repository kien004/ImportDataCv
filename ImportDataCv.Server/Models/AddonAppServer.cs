using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AddonAppServer
{
    public int Id { get; set; }

    public string AppCode { get; set; } = null!;

    public string? AppVendorCode { get; set; }

    public string? ServerCode { get; set; }

    public string? ServerAddress { get; set; }

    public string? Status { get; set; }

    public string? QrCode { get; set; }

    public string? Note { get; set; }

    public string? Logo { get; set; }

    public string? Background { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public bool IsDeleted { get; set; }

    public string? Color { get; set; }

    public string? FontFamily { get; set; }

    public string? FontSize { get; set; }

    public string? BackgroundColor { get; set; }

    public string? ButtonColor { get; set; }

    public string? QrcodeColor { get; set; }

    public string? TextloginColor { get; set; }

    public string? PinColor { get; set; }
}
