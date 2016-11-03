using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPAMS.Entity
{
    [Serializable]
    public class Purchase
    {
        public Guid Id { get; set; }
        public DateTime PurchaseDate { get; set; }
        public long Bookid { get; set; }
        public long Qty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
