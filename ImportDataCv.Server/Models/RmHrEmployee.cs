using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class RmHrEmployee
{
    /// <summary>
    /// id - Id
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Họ vs tên - FullName
    /// </summary>
    public string Fullname { get; set; } = null!;

    /// <summary>
    /// Tên thường dùng - NickName
    /// </summary>
    public string Nickname { get; set; } = null!;

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
    /// Nguyên quán - BirthOfPlace
    /// </summary>
    public string? Birthofplace { get; set; }

    /// <summary>
    /// Hộ khẩu thường trú - PermanentResidence
    /// </summary>
    public string? Permanentresidence { get; set; }

    /// <summary>
    /// Số điện thoại - Phone
    /// </summary>
    public string? Phone { get; set; }

    /// <summary>
    /// Ngày vào đảng - FactionDate
    /// </summary>
    public DateTime? Factiondate { get; set; }

    /// <summary>
    /// Trình độ văn hóa - EducationalLevel
    /// </summary>
    public string? Educationallevel { get; set; }

    /// <summary>
    /// Trình độ ngoại ngử - LanguageLevel
    /// </summary>
    public string? Languagelevel { get; set; }

    /// <summary>
    /// Sức khẻo - Health
    /// </summary>
    public string? Health { get; set; }

    /// <summary>
    /// Chứng minh nhân dân - IdentityCard
    /// </summary>
    public string? Identitycard { get; set; }

    /// <summary>
    /// Ngày cấp chứng minh thư - IdentityCardDate
    /// </summary>
    public DateTime? Identitycarddate { get; set; }

    /// <summary>
    /// Nới cấp chứng minh thư - IdentityCardPlace
    /// </summary>
    public string? Identitycardplace { get; set; }

    /// <summary>
    /// Số bảo hiểm xã hội - SocialInsurance
    /// </summary>
    public string? Socialinsurance { get; set; }

    /// <summary>
    /// Ngày cấp bảo hiểm xa hội - SocialInsuranceDate
    /// </summary>
    public DateTime? Socialinsurancedate { get; set; }

    /// <summary>
    /// Nơi cấp bảo hiểm xã hội - SocialInsurancePlace
    /// </summary>
    public string? Socialinsuranceplace { get; set; }

    /// <summary>
    /// Nhận dạng - Identification
    /// </summary>
    public string? Identification { get; set; }

    /// <summary>
    /// Đơn vị - Unit
    /// </summary>
    public int? Unit { get; set; }

    /// <summary>
    /// Bậc lương - Wage
    /// </summary>
    public string? Wage { get; set; }

    /// <summary>
    /// Loại lương - SalaryType
    /// </summary>
    public string? Salarytype { get; set; }

    /// <summary>
    /// Nhóm lương - SalaryGroup
    /// </summary>
    public string? Salarygroup { get; set; }

    /// <summary>
    /// Hệ số lương - SalaryFactor
    /// </summary>
    public double? Salaryfactor { get; set; }

    /// <summary>
    /// Trường đào tạo - TrainingSchool
    /// </summary>
    public string? Trainingschool { get; set; }

    /// <summary>
    /// Thời gian đào tạo - TrainingTime
    /// </summary>
    public string? Trainingtime { get; set; }

    /// <summary>
    ///  TrainingType
    /// </summary>
    public string? Trainingtype { get; set; }

    /// <summary>
    /// Ngành học - Disciplines
    /// </summary>
    public string? Disciplines { get; set; }

    /// <summary>
    /// Chuyên ngành - Specialized
    /// </summary>
    public string? Specialized { get; set; }

    /// <summary>
    /// Id Hình ảnh - Picture
    /// </summary>
    public string? Picture { get; set; }

    /// <summary>
    /// Mã số thuế - TaxCode
    /// </summary>
    public string? Taxcode { get; set; }

    /// <summary>
    /// Chức vụ - Position
    /// </summary>
    public string? Position { get; set; }

    /// <summary>
    /// Loại hình nhân viên - EmployeeKind
    /// </summary>
    public int? Employeekind { get; set; }

    /// <summary>
    /// EmailUser
    /// </summary>
    public string? Emailuser { get; set; }

    /// <summary>
    /// EmailPassword
    /// </summary>
    public string? Emailpassword { get; set; }

    /// <summary>
    /// Quốc tịch - Nationlaty
    /// </summary>
    public string? Nationlaty { get; set; }

    /// <summary>
    /// Trạng thái - Status
    /// </summary>
    public int? Status { get; set; }

    /// <summary>
    /// Kiểu nhân viên - EmployeeType
    /// </summary>
    public int? Employeetype { get; set; }

    /// <summary>
    /// Ngân hàng - Bank
    /// </summary>
    public string? Bank { get; set; }

    /// <summary>
    /// Chủ tài khoản - AccountHolder
    /// </summary>
    public string? Accountholder { get; set; }

    /// <summary>
    /// Nơi mở tài khoản - AccountOpenPlace
    /// </summary>
    public string? Accountopenplace { get; set; }

    /// <summary>
    /// Số tài khoản - AccountNumber
    /// </summary>
    public string? Accountnumber { get; set; }

    /// <summary>
    /// Tình trạng hôn nhân - MaritalStatus
    /// </summary>
    public int? Maritalstatus { get; set; }

    /// <summary>
    /// Trình độ tin học - ComputerSkill
    /// </summary>
    public string? Computerskill { get; set; }

    /// <summary>
    /// 1: Nhân viên
    /// 2: Giáo viên
    /// 3: Gia sư
    /// 4: Thực tập - EmployeeGroup
    /// </summary>
    public int? Employeegroup { get; set; }

    public DateTime? Createtime { get; set; }

    public DateTime? Updatetime { get; set; }

    public string? Language { get; set; }

    public int? Flag { get; set; }

    public int? CreateBy { get; set; }

    public int? UpdatedBy { get; set; }

    public int? IdDriver { get; set; }

    public string? CompanyCode { get; set; }
}
