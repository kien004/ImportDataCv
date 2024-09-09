﻿using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class HrRomoocDriver
{
    public int Id { get; set; }

    public int? Active { get; set; }

    public double? BalanceCredit { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? Email { get; set; }

    public string? IdFb { get; set; }

    public string? IdentificationImage { get; set; }

    public string? ImageCar { get; set; }

    public int? IsBusy { get; set; }

    public string? LicenseCarImage { get; set; }

    public string? LicensePlate { get; set; }

    public string? Name { get; set; }

    public string? Password { get; set; }

    public string? Phone { get; set; }

    public string? ProfilePicture { get; set; }

    public string? TaxyType { get; set; }

    public int? TypeDriver { get; set; }

    public int? TypeSeat { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? Username { get; set; }

    public int IsOnline { get; set; }

    public string? TypeCarYear { get; set; }

    public string? CompanyCode { get; set; }

    public string? Emei { get; set; }

    public string? Description { get; set; }

    public string? Brand { get; set; }

    public string? Polyline { get; set; }

    public string? VirualIntiary { get; set; }

    public string? StartName { get; set; }

    public string? EndName { get; set; }

    public string? StartNameGps { get; set; }

    public string? EndNameGps { get; set; }
}
