using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class CardCommentList
{
    public int Id { get; set; }

    public string? CardCode { get; set; }

    public string? BoardCode { get; set; }

    public string? CmtId { get; set; }

    public string? CmtContent { get; set; }

    public string? MemberId { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public bool Flag { get; set; }

    public int? RefParent { get; set; }

    public int? Like { get; set; }

    public int? Dislike { get; set; }

    public string? LikeLog { get; set; }

    public string? JsonCanvas { get; set; }

    public bool? IsGptAnswered { get; set; }

    public string? GptAnswer { get; set; }
}
