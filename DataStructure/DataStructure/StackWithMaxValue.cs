using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure {
    public class StackWithMaxValue {
        public StackWithMaxValue(string size, List<string> commands) {
            stack = new Stack<StackObject>();
            MaxValues = new List<int>();
            foreach (string command in commands) {
                string[] command_value = command.Split(' ');
                string op =command_value[0];
                switch (op) {
                    case "push":
                        int operatorValue = Convert.ToInt32(command_value[1]);
                        if (stack.Count == 0) {
                            stack.Push(new StackObject() { Value = operatorValue, StackMaxValue = operatorValue });
                        } else {
                            StackObject topObject = stack.Peek();
                            int max = topObject.StackMaxValue > operatorValue? topObject.StackMaxValue : operatorValue ;
                            stack.Push(new StackObject() { Value = operatorValue, StackMaxValue = max });
                        }
                        break;
                    case "pop":
                        stack.Pop();
                        break;
                    case "max":
                        StackObject obj =stack.Peek();
                        MaxValues.Add(obj.StackMaxValue);
                        break;

                    default:
                        break;
                }

            }
        }

        public List<int> MaxValues { get; set; }
        private Stack<StackObject> stack;
    }

    public class StackObject {
        public int Value { get; set; }
        public int StackMaxValue { get; set; }
    }
}
