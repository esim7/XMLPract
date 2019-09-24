using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLPract
{
    public class Origin
    {
        public Time Time { get; set; }
        public Longitude Longitude { get; set; }
        public Latitude Latitude { get; set; }
        public Depth Depth { get; set; }
        public OriginUncertainty OriginUncertainty { get; set; }
        public Quality Quality { get; set; }
        public string EvaluationMode { get; set; }
        public CreationInfo CreationInfo { get; set; }
        public string PublicID { get; set; }
        public string EventID { get; set; }
        public string Eventsource { get; set; }
        public string Datasource { get; set; }
        public string DataID { get; set; }
    }
}
