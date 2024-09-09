using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class JobcardDataLogger
{
    public int Id { get; set; }

    public string? DtCode { get; set; }

    public string? DtTitle { get; set; }

    public string? DtValue { get; set; }

    public string? DtUnit { get; set; }

    public string? DtGroup { get; set; }

    public string? DtValueType { get; set; }

    public string? ShiftCode { get; set; }

    public string? ItemList { get; set; }

    public string? JobcardCode { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public bool? Flag { get; set; }

    public string? ActInstCode { get; set; }

    public string? WfInstCode { get; set; }

    public string? SessionId { get; set; }

    public string? SessionCode { get; set; }
}
