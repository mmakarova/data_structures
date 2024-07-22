using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure {
    public static class StackToCheckBrackets {
        public static int IsBalanced(string str) {
            var openSymbols = new List<char> { '(', '[', '{' };
            var closeSymbols = new List<char> { ')', ']', '}' };
            var stack = new Stack<char>();
            int allStackValues = 0;
            var openValues = new Stack<BracketIndex>();

            foreach (char symbol in str) {
                char? topElement = null;
                char? closeSymbol = null;
                allStackValues++;
                if (stack.Count != 0) {
                    topElement = stack.Peek();
                    closeSymbol = closeSymbols[openSymbols.IndexOf((char)topElement)];

                }
                if (closeSymbol == symbol) {
                    stack.Pop();
                    openValues.Pop();

                } else if (openSymbols.Contains(symbol)) {
                    stack.Push(symbol);
                    openValues.Push(new BracketIndex { Index = allStackValues, Bracket = symbol });
                } else if (closeSymbols.Contains(symbol)) {
                    return allStackValues;
                }

            }
            return stack.Count == 0 ? stack.Count : openValues.Peek().Index;
        }
    }

    public class BracketIndex {
        public int Index { get; set; }
        public char Bracket { get; set; }
    }
}
