using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLPract
{
    public class Magnitude
    {
        public Mag Mag { get; set; }
        public string Type { get; set; }
        public string OriginID { get; set; }
        public string EvaluationMode { get; set; }
        public CreationInfo CreationInfo { get; set; }
        public string PublicID { get; set; }
        public string EventID { get; set; }
        public string Eventsource { get; set; }
        public string Datasource { get; set; }
        public string DataID { get; set; }
    }
}
