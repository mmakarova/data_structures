using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure {
    public class MaxValueInWindow {

        public MaxValueInWindow(List<int> values, int windowSize) {
            MaxValues = new List<int>();
            int windowIndex = 0;
            int maxValue = -1;
            int maxValueBla = -1;
            do {
                
                maxValue = Math.Max(values[windowIndex],maxValue);
                
                if ((windowIndex + 1) % windowSize == 0) {
                    MaxValues.Add(maxValue);
                    if (values[0] < maxValue) {
                        if (windowIndex + 1 < values.Count && maxValue >= values[windowIndex + 1]) {
                            MaxValues.Add(maxValue);
                            values.RemoveAt(0);
                        }
                    }
                    windowIndex = 0;
                    values.RemoveAt(0);
                    maxValue = -1;
                } else {
                    windowIndex++;
                }

            } while (values.Count > windowSize);

           
        }
        public List<int> MaxValues { get; set; }

    }

}
