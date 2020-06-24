using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Graphics.Printing;

namespace MQTT.Models
{
    class Telemetry
    {
        public double engineTemp { get; set; }
        public double engineRpm { get; set; }
        public double fuel { get; set; }

    }
}
