using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class UserDoExerciseResult
{
    public int Id { get; set; }

    public string? QuizCode { get; set; }

    public string? UserChoose { get; set; }

    public bool? Result { get; set; }

    public string? SessionCode { get; set; }

    public string? TypeTraining { get; set; }

    public string? ObjectCode { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }
}
