using System;
using System.Collections.Generic;

namespace ImportDataCv.Server.Models;

public partial class GetCountCardWork
{
    public Guid? Id { get; set; }

    public int? SumCardWork { get; set; }

    public int? CardWorkPending { get; set; }

    public int? CardWorkSuccess { get; set; }

    public int? CardWorkcancel { get; set; }

    public int? CardWorkExpires { get; set; }
}
