using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPAMS.Entity
{
    [Serializable]
   public class Transaction
    {
        public Guid Id { get; set; }
        public Guid MemberId { get; set; }
        public long BookId { get; set; }
        public DateTime TransactionDate { get; set; }
        public TransctionType TransctionType { get; set; }
    }
}
