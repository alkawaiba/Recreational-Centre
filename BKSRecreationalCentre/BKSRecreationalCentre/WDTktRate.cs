using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BKSRecreationalCentre
{
     public class WDTktRate
    {
        public string TktType { get; set; }
        public float WDRate1Hour {get; set;}
        public float WDRate2Hours { get; set; }
        public float WDRate3Hours { get; set; }
        public float WDRate4Hours { get; set; }
        public float WDRateWholeDay { get; set; }
        
    }
}
