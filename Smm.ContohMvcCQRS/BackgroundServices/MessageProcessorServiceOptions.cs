using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMvcCQRS.BackgroundServices
{
    public class MessageProcessorServiceOptions
    {
        public double IntervalOnSeconds { get; set; }
        public int BatchSize { get; set; }
    }
}
