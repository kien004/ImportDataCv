using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class Customer
{
    /// <summary>
    /// Customer Id
    /// </summary>
    public int CusId { get; set; }

    /// <summary>
    /// Customer Code
    /// </summary>
    public string? CusCode { get; set; }

    /// <summary>
    /// Customer Name
    /// </summary>
    public string? CusName { get; set; }

    /// <summary>
    /// Birthday
    /// </summary>
    public string? LotName { get; set; }

    /// <summary>
    /// Email
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// Address
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// Telephone
    /// </summary>
    public string? Telephone { get; set; }

    /// <summary>
    /// MobilePhone
    /// </summary>
    public string? MobilePhone { get; set; }

    /// <summary>
    /// Fax
    /// </summary>
    public string? Fax { get; set; }

    /// <summary>
    /// Customer Group
    /// </summary>
    public string? CusGroup { get; set; }

    /// <summary>
    /// Activity Status
    /// </summary>
    public string? ActivityStatus { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Flag
    /// </summary>
    public bool? Flag { get; set; }

    public string? GoogleMap { get; set; }

    public string? AccountBank { get; set; }

    public string? BankName { get; set; }

    public string? Identification { get; set; }

    public string? AddressBank { get; set; }

    public string? TaxCode { get; set; }

    public string? CusType { get; set; }

    public string? Status { get; set; }

    public string? Area { get; set; }

    public string? Group { get; set; }

    public string? Role { get; set; }

    public string? InAgent { get; set; }

    public bool? HasStock { get; set; }

    public string? TotalStock { get; set; }

    public string? Resource { get; set; }

    public string? Logo { get; set; }

    public string? Transport { get; set; }

    public string? Surrogate { get; set; }

    /// <summary>
    /// ICON LEVEL CODE
    /// </summary>
    public string? IconLevel { get; set; }

    public string? ZipCode { get; set; }

    /// <summary>
    /// Người phụ trách
    /// </summary>
    public string? PersonInCharge { get; set; }

    public string? ListUserView { get; set; }

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
