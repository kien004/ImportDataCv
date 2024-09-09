using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AddonApp
{
    public int Id { get; set; }

    public string AppCode { get; set; } = null!;

    public string? AppTitle { get; set; }

    /// <summary>
    /// Ngày xuất bản
    /// </summary>
    public DateTime? AppDate { get; set; }

    public string? Icon { get; set; }

    public string? LinkChplay { get; set; }

    public string? LinkIos { get; set; }

    public string? Status { get; set; }

    public string? Note { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public bool IsDeleted { get; set; }
}
