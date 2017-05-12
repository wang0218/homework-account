using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace account.Models
{
    public class Myclass
    {
        public Guid num { get; set; }
        public string category{ get; set; }
        public DateTime date { get; set; }
        public Decimal money { get; set; }
        public string remark { get; set; }
    }
}