using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class Supplier
{
    /// <summary>
    /// Supplier Id
    /// </summary>
    public int SupId { get; set; }

    /// <summary>
    /// Supplier Code
    /// </summary>
    public string? SupCode { get; set; }

    /// <summary>
    /// Supplier Name
    /// </summary>
    public string? SupName { get; set; }

    /// <summary>
    /// Address
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// Telephone
    /// </summary>
    public string? Telephone { get; set; }

    /// <summary>
    /// Mobile
    /// </summary>
    public string? Mobile { get; set; }

    /// <summary>
    /// Tax Code
    /// </summary>
    public string? TaxCode { get; set; }

    /// <summary>
    /// Supplier Type
    /// </summary>
    public string? LotName { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// UserId
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Email
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// Website
    /// </summary>
    public string? Website { get; set; }

    /// <summary>
    /// Supplier Group
    /// </summary>
    public string? SupGroup { get; set; }

    /// <summary>
    /// Note
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Fax
    /// </summary>
    public string? Fax { get; set; }

    public bool? Flag { get; set; }

    public string? GoogleMap { get; set; }

    public string? Identification { get; set; }

    public string? AddressBank { get; set; }

    public string? AccountBank { get; set; }

    public string? CusType { get; set; }

    public string? Area { get; set; }

    public string? Group { get; set; }

    public string? Role { get; set; }

    public string? IconLevel { get; set; }

    public string? ListUserView { get; set; }

    public string? AccountBankList { get; set; }

    public string? JsonStatus { get; set; }

    public string? FinanceInfo { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public bool? IsDeleted { get; set; }
}
