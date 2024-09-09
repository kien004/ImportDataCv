using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class LmsUserMsg
{
    public int Id { get; set; }

    public int? MsgId { get; set; }

    public string? UsrSend { get; set; }

    public string? UsrReceiver { get; set; }

    public bool? Confirm { get; set; }

    public string? Note { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public bool? IsEnabled { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }
}
