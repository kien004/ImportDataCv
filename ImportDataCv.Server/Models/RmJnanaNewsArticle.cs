using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class RmJnanaNewsArticle
{
    public int Id { get; set; }

    public string? ArticleCode { get; set; }

    public string? ArticleTitle { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime CreatedTime { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateTime { get; set; }

    public int ArticleStatus { get; set; }

    public string? ArticleAvarta { get; set; }

    public string? CatCode { get; set; }

    public string? ArticleContent { get; set; }

    public int? ArtileOrder { get; set; }
}
