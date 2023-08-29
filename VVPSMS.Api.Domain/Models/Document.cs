﻿using System;
using System.Collections.Generic;

namespace VVPSMS.Domain.Models;

public partial class Document
{
    public int DocumentId { get; set; }

    public int StudentId { get; set; }

    public int TeacherId { get; set; }

    public string DocumentName { get; set; } = null!;

    public string DocumentPath { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? ModifiedAt { get; set; }

    public int? ModifiedBy { get; set; }

    public virtual Student Student { get; set; } = null!;

    public virtual Teacher Teacher { get; set; } = null!;
}
