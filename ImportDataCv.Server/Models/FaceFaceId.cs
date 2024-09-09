using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class FaceFaceId
{
    public int Id { get; set; }

    public string? FaceId { get; set; }

    public string? Name { get; set; }

    public string? ImgPath { get; set; }

    public DateTime? CreatedTime { get; set; }
}
