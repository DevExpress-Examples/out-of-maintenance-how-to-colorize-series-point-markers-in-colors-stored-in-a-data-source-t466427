using ColorObjectColorizerExample.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorObjectColorizerExample.ViewModel {
    class BubblesViewModel {
        public IEnumerable<BubbleDataPoint> DataPoints { get; private set; }

        public BubblesViewModel() {
            DataPoints = new Collection<BubbleDataPoint>() {
                new BubbleDataPoint(xArgument: "A", yArgument: "B", value: 10.0d, weight: 2.0d, color: 0xFF5B9BD5),
                new BubbleDataPoint(xArgument: "B", yArgument: "C", value:  3.0d, weight: 3.0d, color: 0xFFED7D31),
                new BubbleDataPoint(xArgument: "C", yArgument: "E", value:  8.0d, weight: 4.0d, color: 0xFFED7D31),
                new BubbleDataPoint(xArgument: "D", yArgument: "D", value:  7.0d, weight: 1.0d, color: 0xFFA5A5A5),
                new BubbleDataPoint(xArgument: "E", yArgument: "A", value:  5.0d, weight: 2.0d, color: 0xFF5B9BD5)
            };
        }
    }
}
