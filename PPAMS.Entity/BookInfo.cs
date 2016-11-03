using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPAMS.Entity
{
    [Serializable]
    public class BookInfo
    {
        public long Id { get; set; }
        public long CatagoryId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public long TotalQty { get; set; }
        public long IssueQty { get; set; }
        public long CurrentrQty { get; set; }

    }
}
