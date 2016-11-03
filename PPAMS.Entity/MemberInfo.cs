using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPAMS.Entity
{
    [Serializable]
    public class MemberInfo
    {
        public Guid Id { get; set; }
        public string MemberNo { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public DateTime ExpiredData { get; set; }

    }
}
