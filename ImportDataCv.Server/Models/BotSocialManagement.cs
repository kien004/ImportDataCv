using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class BotSocialManagement
{
    public int Id { get; set; }

    public string? BotSocialCode { get; set; }

    public string? BotSocialName { get; set; }

    public string? BotSocialType { get; set; }

    public string? UserName { get; set; }

    public string? PassWord { get; set; }

    public string? Credential { get; set; }

    public string? Tocken { get; set; }

    public string? ConditionStatement { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }
}
