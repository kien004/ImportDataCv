﻿using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class AssetRecordDeliveryDetail
{
    public int Id { get; set; }

    public string? RecordCode { get; set; }

    public string? DeliveryCode { get; set; }
}
