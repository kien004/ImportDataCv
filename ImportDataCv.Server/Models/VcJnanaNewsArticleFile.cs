using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class VcJnanaNewsArticleFile
{
    public int Id { get; set; }

    public string? FileCode { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? ArticleCode { get; set; }
}
