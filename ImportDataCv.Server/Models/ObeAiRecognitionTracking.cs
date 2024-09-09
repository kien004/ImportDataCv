using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class ObeAiRecognitionTracking
{
    public int Id { get; set; }

    public string? FaceId { get; set; }

    public string? ObjName { get; set; }

    public string? ImgPath { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string DeviceId { get; set; } = null!;
}
