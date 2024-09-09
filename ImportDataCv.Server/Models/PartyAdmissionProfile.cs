using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class PartyAdmissionProfile
{
    /// <summary>
    /// Tên hiên nay
    /// </summary>
    public string? CurrentName { get; set; }

    /// <summary>
    /// id - Id
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Tên thường dùng 
    /// </summary>
    public string? BirthName { get; set; }

    /// <summary>
    /// Giới tính - Gender
    /// </summary>
    public int? Gender { get; set; }

    /// <summary>
    /// Dân tộc - Nation
    /// </summary>
    public string? Nation { get; set; }

    /// <summary>
    /// Tôn giáo - Religion
    /// </summary>
    public string? Religion { get; set; }

    /// <summary>
    /// Ngày sinh - Birthday
    /// </summary>
    public DateTime? Birthday { get; set; }

    /// <summary>
    /// Hộ khẩu thường trú - PermanentResidence
    /// </summary>
    public string? PermanentResidence { get; set; }

    /// <summary>
    /// Số điện thoại - Phone
    /// </summary>
    public string? Phone { get; set; }

    /// <summary>
    /// Id Hình ảnh - Picture
    /// </summary>
    public string? Picture { get; set; }

    /// <summary>
    /// Quê quán
    /// </summary>
    public string? HomeTown { get; set; }

    /// <summary>
    /// Nơi sinh
    /// </summary>
    public string? PlaceBirth { get; set; }

    public string? Job { get; set; }

    /// <summary>
    /// Địa chỉ tạm trú
    /// </summary>
    public string? TemporaryAddress { get; set; }

    /// <summary>
    /// Giáo dục phổ thông
    /// </summary>
    public string? GeneralEducation { get; set; }

    /// <summary>
    /// Giáo dục nghề nghiệp
    /// </summary>
    public string? JobEducation { get; set; }

    /// <summary>
    /// Giáo dục đại học và sau đại học
    /// </summary>
    public string? UnderPostGraduateEducation { get; set; }

    /// <summary>
    /// Học hàm
    /// </summary>
    public string? Degree { get; set; }

    /// <summary>
    /// Lí luận chính trị
    /// </summary>
    public string? PoliticalTheory { get; set; }

    /// <summary>
    /// Ngoại ngữ
    /// </summary>
    public string? ForeignLanguage { get; set; }

    /// <summary>
    /// Tin học
    /// </summary>
    public string? ItDegree { get; set; }

    /// <summary>
    /// Tiếng dân tộc thiểu số
    /// </summary>
    public string? MinorityLanguages { get; set; }

    /// <summary>
    /// Tự nhận xét
    /// </summary>
    public string? SelfComment { get; set; }

    /// <summary>
    /// Nơi tạo
    /// </summary>
    public string? CreatedPlace { get; set; }

    /// <summary>
    /// Số lí lịch
    /// </summary>
    public string? ResumeNumber { get; set; }

    public int? UserCode { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Status { get; set; }

    public string? Username { get; set; }

    public string? ProfileLink { get; set; }

    public string? CreatedBy { get; set; }

    public string? WfInstCode { get; set; }
}
