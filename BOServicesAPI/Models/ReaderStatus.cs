﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BOServicesAPI.Models
{
    public partial class ReaderStatus
    {
        public ReaderStatus()
        {
            MalfunctionReaders = new HashSet<MalfunctionReader>();
        }

        public int Id { get; set; }
        public byte[] RowVersion { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? Modified { get; set; }

        public virtual ICollection<MalfunctionReader> MalfunctionReaders { get; set; }
    }
}
