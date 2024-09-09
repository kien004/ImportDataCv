﻿using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class UrencoRoute
{
    public int Id { get; set; }

    public string? RouteCode { get; set; }

    public string? RouteName { get; set; }

    public int? RouteLevel { get; set; }

    public int? RouteType { get; set; }

    public int? RoutePriority { get; set; }

    public string? Note { get; set; }

    public int? Manager { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public string? DeletedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Status { get; set; }

    public int? NumLine { get; set; }

    public int? NumLength { get; set; }

    public string? TimeActive { get; set; }

    public string? QrCode { get; set; }

    public string? Images { get; set; }

    public DateTime? DeletedTime { get; set; }

    public string? RouteDataGps { get; set; }
}
