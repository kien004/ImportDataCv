using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class Contact
{
    /// <summary>
    /// Contact Id
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Contact Name
    /// </summary>
    public string? ContactName { get; set; }

    /// <summary>
    /// Address
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// Telephone
    /// </summary>
    public string? Telephone { get; set; }

    /// <summary>
    /// Mobile Phone
    /// </summary>
    public string? MobilePhone { get; set; }

    /// <summary>
    /// Fax
    /// </summary>
    public string? Fax { get; set; }

    /// <summary>
    /// Email
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// Note
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// User Id
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Create time
    /// </summary>
    public DateTime? CreateTime { get; set; }

    /// <summary>
    /// Update time
    /// </summary>
    public DateTime? UpdateTime { get; set; }

    /// <summary>
    /// Facebook
    /// </summary>
    public string? Facebook { get; set; }

    /// <summary>
    /// Google Plus
    /// </summary>
    public string? GooglePlus { get; set; }

    /// <summary>
    /// Skype
    /// </summary>
    public string? Skype { get; set; }

    /// <summary>
    /// Twitter
    /// </summary>
    public string? Twitter { get; set; }

    /// <summary>
    /// Image
    /// </summary>
    public string? Image { get; set; }

    /// <summary>
    /// Customer Code
    /// </summary>
    public string? CusCode { get; set; }

    /// <summary>
    /// Supplier Code
    /// </summary>
    public string? SuppCode { get; set; }

    /// <summary>
    /// Flag
    /// </summary>
    public bool? Flag { get; set; }

    public string? FilePath { get; set; }

    public string? Title { get; set; }

    public string? InChargeOf { get; set; }

    public bool IsDeleted { get; set; }

    public string? Sex { get; set; }

    public DateTime? Birthday { get; set; }

    public string? Career { get; set; }

    public string? Position { get; set; }

    public string? Hashtag { get; set; }

    public string? Source { get; set; }
}
