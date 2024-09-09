using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class HrContract
{
    public int Id { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    /// <summary>
    /// Bảo hiểm
    /// </summary>
    public double? Insuarance { get; set; }

    /// <summary>
    /// Ngày thanh toán
    /// </summary>
    public DateTime? DatesOfPay { get; set; }

    /// <summary>
    /// Nơi làm việc
    /// </summary>
    public string? PlaceWork { get; set; }

    /// <summary>
    /// Thời gian làm việc
    /// </summary>
    public string? ExpTimeWork { get; set; }

    /// <summary>
    /// Bậc lương
    /// </summary>
    public string? SalaryRatio { get; set; }

    /// <summary>
    /// Thanh toán
    /// </summary>
    public string? Payment { get; set; }

    /// <summary>
    /// Loại hợp đồng
    /// </summary>
    public string? ContractType { get; set; }

    /// <summary>
    /// Người ký
    /// </summary>
    public string? Signer { get; set; }

    /// <summary>
    /// Mã nhân viên
    /// </summary>
    public int EmployeeId { get; set; }

    /// <summary>
    /// Lương
    /// </summary>
    public double? Salary { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    /// <summary>
    /// Ngày cấp sổ lao động
    /// </summary>
    public DateTime? DateOfLaborBook { get; set; }

    /// <summary>
    /// Nơi cấp sổ lao động
    /// </summary>
    public string? PlaceLaborBook { get; set; }

    /// <summary>
    /// Nội dung công việc
    /// </summary>
    public string? WorkContent { get; set; }

    /// <summary>
    /// Phụ cấp
    /// </summary>
    public string? Allowance { get; set; }

    public string? ContractCode { get; set; }

    public string? LaborBookCode { get; set; }

    public string? File { get; set; }

    /// <summary>
    /// Thỏa thuận khác
    /// </summary>
    public string? OtherAgree { get; set; }

    /// <summary>
    /// Thông tin bảo hiểm
    /// </summary>
    public string? InfoInsuarance { get; set; }

    /// <summary>
    /// Thông tin hợp đồng
    /// </summary>
    public string? InfoContract { get; set; }

    /// <summary>
    /// Tiền thưởng
    /// </summary>
    public double? Bonus { get; set; }

    /// <summary>
    /// Công cụ làm việc
    /// </summary>
    public string? ToolsWork { get; set; }

    public int? Active { get; set; }

    /// <summary>
    /// Kiểu tiền
    /// </summary>
    public string? TypeMoney { get; set; }

    public int? ValueTimeWork { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public int? Flag { get; set; }

    public string? PayScale { get; set; }
}
