using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrionApiSdk.Classes.LaserApp
{
    public class Form
    {
        public int id { get; set; }
        public string guid { get; set; }
        public string title { get; set; }
        public int majorVersion { get; set; }
        public int minorVersion { get; set; }
        public DateTime cDate { get; set; }
        public DateTime rDate { get; set; }
        public int pages { get; set; }
        public bool isRequired { get; set; }
    }
}
