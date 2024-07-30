using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure {
    public class MaxValueInWindow {
        //O(n*m)
        //public MaxValueInWindow(List<int> values, int windowSize) {
        //    MaxValues = new List<int>();
        //    int windowIndex = 0;
        //    int maxValue = -1;
        //    int maxValueBla = -1;
        //    do {

        //        maxValue = Math.Max(values[windowIndex],maxValue);

        //        if ((windowIndex + 1) % windowSize == 0) {
        //            MaxValues.Add(maxValue);
        //            if (values[0] < maxValue) {
        //                if (windowIndex + 1 < values.Count && maxValue >= values[windowIndex + 1]) {
        //                    MaxValues.Add(maxValue);
        //                    values.RemoveAt(0);
        //                }
        //            }
        //            windowIndex = 0;
        //            values.RemoveAt(0);
        //            maxValue = -1;
        //        } else {
        //            windowIndex++;
        //        }

        //    } while (values.Count > windowSize);           
        //}

        public MaxValueInWindow(List<int> values, int windowSize) {
            MaxValues = new List<int>();
            Stack<StackObject> inputStack = new Stack<StackObject>();
            Stack<StackObject> outputStack = new Stack<StackObject>();
            for (int i = 0; i < values.Count; i++) {
                PushStackMaxValue(inputStack, values[i]);
                if (outputStack.Count != 0) {
                    StackObject outputObject = outputStack.Pop();
                    StackObject stackObject = inputStack.Peek();
                    MaxValues.Add(Math.Max(outputObject.StackMaxValue, stackObject.StackMaxValue));
                }
                if (inputStack.Count == windowSize) {
                    do {
                        PushStackMaxValue(outputStack, inputStack.Pop().Value);
                    } while (inputStack.Count != 0);
                    MaxValues.Add(outputStack.Pop().StackMaxValue);
                }
            }
        }

        public void PushStackMaxValue(Stack<StackObject> stack, int value) {
            if (stack.Count == 0) {
                stack.Push(new StackObject() { Value = value, StackMaxValue = value });
            } else {
                var maxValue = Math.Max(stack.Peek().StackMaxValue, value);
                stack.Push(new StackObject() { Value = value, StackMaxValue = maxValue });

            }
        }
        public List<int> MaxValues { get; set; }
    }

}
