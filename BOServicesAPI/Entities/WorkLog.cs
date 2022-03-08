using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOServicesAPI.Entities
{
    public class WorkLog
    {
        public string KeySegment { get; set; }
        public string ChangeType { get; set; }
        public string ChangedBy { get; set; }
        public string OriginalValues { get; set; }
        public string NewValues { get; set; }
        public string ReferenceType { get; set; }
        public string DataSource { get; set; }
        public int IdUserWeb { get; set; }
    }
}
