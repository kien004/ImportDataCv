using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class VAmchartDoExercise
{
    public Guid? Id { get; set; }

    public int? MonthData { get; set; }

    public string? CreatedBy { get; set; }

    public bool? Result { get; set; }

    public string? TypeTraining { get; set; }

    public int? TypeCount { get; set; }

    public int? LstMonth { get; set; }
}
