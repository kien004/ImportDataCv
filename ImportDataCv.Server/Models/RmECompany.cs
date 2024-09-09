using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class RmECompany
{
    public int Id { get; set; }

    public string? CompanyCode { get; set; }

    public string? CompanyContact { get; set; }

    public string? CompanyImage { get; set; }

    public string? CompanyName { get; set; }

    public string? CompanyOwner { get; set; }

    public string? CompanyPhone { get; set; }

    public string? CompanyType { get; set; }

    public string? CompanyWebsite { get; set; }

    public int? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Description { get; set; }

    public int Flag { get; set; }

    public int? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
