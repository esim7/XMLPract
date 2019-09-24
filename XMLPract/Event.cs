using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLPract
{
    public class Event
    {
        public Description Description { get; set; }
        public Origin Origin { get; set; }
        public Magnitude Magnitude { get; set; }
        public string PreferredOriginID { get; set; }
        public string PreferredMagnitudeID { get; set; }
        public string Type { get; set; }
        public CreationInfo CreationInfo { get; set; }
        public string PublicID { get; set; }
        public string EventID { get; set; }
        public string Eventsource { get; set; }
        public string Datasource { get; set; }
    }
}
