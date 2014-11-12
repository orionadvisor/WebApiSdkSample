using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrionApiSdk.Classes.Portfolio
{
    public class AccountStatus
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public bool isVisible { get; set; }
        public bool includeInBusinessMetrics { get; set; }
        public bool isDownloading { get; set; }
    }
}
