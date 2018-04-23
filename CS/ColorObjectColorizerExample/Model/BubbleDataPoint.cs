using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorObjectColorizerExample.Model {
    class BubbleDataPoint {
        public string XArgument { get; private set; }
        public string YArgument { get; private set; }
        public double Value { get; private set; }
        public double Weight { get; private set; }
        public uint Color { get; private set; }

        public BubbleDataPoint(string xArgument, string yArgument, double value, double weight, uint color) {
            XArgument = xArgument;
            YArgument = yArgument;
            Value = value;
            Weight = weight;
            Color = color;
        }
    }
}
