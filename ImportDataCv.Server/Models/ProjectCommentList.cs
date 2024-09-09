﻿using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ProjectCommentList
{
    public int Id { get; set; }

    public string? ProjectCode { get; set; }

    public string? RefContent { get; set; }

    public string? UserCreateRef { get; set; }

    public int? RefParent { get; set; }

    public int? Like { get; set; }

    public int? Dislike { get; set; }

    public string? LikeLog { get; set; }

    public string? JsonCanvas { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? DeletedBy { get; set; }
}
