using DataStructure;

namespace Tests {
    public class Tests {
        [SetUp]
        public void Setup() {
        }


        public void StackTests() {
            using (var tw = new StringWriter()) {
                Console.SetOut(tw);
                Program.Main();
                Assert.That(StackToCheckBrackets.IsBalanced("()[]}"), Is.EqualTo(5));
                Assert.That(StackToCheckBrackets.IsBalanced("()[]}"), Is.EqualTo(5));
                Assert.That(StackToCheckBrackets.IsBalanced("{{{[][][]"), Is.EqualTo(3));
                Assert.That(StackToCheckBrackets.IsBalanced("{*{{}"), Is.EqualTo(3));
                Assert.That(StackToCheckBrackets.IsBalanced("[[***"), Is.EqualTo(2));
                Assert.That(StackToCheckBrackets.IsBalanced("{*}"), Is.EqualTo(0));
                Assert.That(StackToCheckBrackets.IsBalanced("foo(bar[i);"), Is.EqualTo(10));
                Assert.That(StackToCheckBrackets.IsBalanced("[[***;"), Is.EqualTo(2));
                Assert.That(StackToCheckBrackets.IsBalanced("{{{[][][]"), Is.EqualTo(3));
            }
        }

        public void TreeTests() {
            using (var tw = new StringWriter()) {
                Console.SetOut(tw);
                Program.Main();
                string[] numberList = ("5" + Environment.NewLine + "4 -1 4 1 1").Split(Environment.NewLine);
                TreeHeight treeHeight = new TreeHeight(Convert.ToInt32(numberList[0]), numberList[1]);
                //  Assert.That(treeHeight.GetHeight()==3);

                numberList = ("5" + Environment.NewLine + "-1 0 4 0 3").Split(Environment.NewLine);
                treeHeight = new TreeHeight(Convert.ToInt32(numberList[0]), numberList[1]);
                // Assert.That(treeHeight.GetHeight() == 4);

                numberList = ("10" + Environment.NewLine + "9 7 5 5 2 9 9 9 2 -1").Split(Environment.NewLine);
                treeHeight = new TreeHeight(Convert.ToInt32(numberList[0]), numberList[1]);
                var height = treeHeight.GetHeight();
                Assert.That(height == 4);
            }
        }
        
        public void QueueTests() {
            using (var tw = new StringWriter()) {
                Console.SetOut(tw);
                Program.Main();

                ////-------------1------------------
                string size_number = "1 1";
                List<string> packages = new List<string>();
                packages.Add("0 0");

                StautsOfNetPackages queue = new StautsOfNetPackages(size_number, packages);

                //actual
                List<int> valuesActual = queue.GetOutputString();
                string outputActual = String.Join(Environment.NewLine, valuesActual);

                //expected
                List<int> valuesExpected = new List<int>() { 0 };
                string outputExpected = String.Join(Environment.NewLine, valuesExpected);

                //Assert.That(outputActual == outputExpected);

                ////-------------2------------------
                size_number = "1 2";
                packages = new List<string>();
                packages.Add("0 1");
                packages.Add("1 1");
                queue = new StautsOfNetPackages(size_number, packages);

                //actual
                valuesActual = queue.GetOutputString();
                outputActual = String.Join(Environment.NewLine, valuesActual);

                //expected
                valuesExpected = new List<int>() { 0, 1 };
                outputExpected = String.Join(Environment.NewLine, valuesExpected);

                Assert.That(outputActual == outputExpected);

                ////-------------3------------------
                size_number = "1 0";
                packages = null;
                queue = new StautsOfNetPackages(size_number, packages);

                //actual
                valuesActual = queue.GetOutputString();
                outputActual = String.Join(Environment.NewLine, valuesActual);

                //expected
                valuesExpected = new List<int>() { };
                outputExpected = String.Join(Environment.NewLine, valuesExpected);

                Assert.That(outputActual == outputExpected);

                //-------------4------------------
                size_number = "2 5";
                packages = new List<string>();
                packages.Add("2 9");
                packages.Add("4 8");
                packages.Add("10 9");
                packages.Add("15 2");
                packages.Add("19 1");
                queue = new StautsOfNetPackages(size_number, packages);

                //actual
                valuesActual = queue.GetOutputString();
                outputActual = String.Join(Environment.NewLine, valuesActual);

                //expected
                valuesExpected = new List<int>() { 2, 11, -1, 19, 21 };
                outputExpected = String.Join(Environment.NewLine, valuesExpected);

                Assert.That(outputActual==outputExpected);

            }
        }
        [Test]
        public void StackWithMax() {
            using (var tw = new StringWriter()) {
                Console.SetOut(tw);
                Program.Main();

                ////-------------1------------------
                string size_number = "10";
                List<string> commands = new List<string>();
                commands.Add("push 2");
                commands.Add("push 3");
                commands.Add("push 9");
                commands.Add("push 7");
                commands.Add("push 2");
                commands.Add("max");
                commands.Add("max");
                commands.Add("max");
                commands.Add("pop");
                commands.Add("max");

                StackWithMaxValue myStack = new StackWithMaxValue(size_number, commands);

                //actual
                List<int> valuesActual = myStack.MaxValues;
                string outputActual = String.Join(Environment.NewLine, valuesActual);

                //expected
                List<int> valuesExpected = new List<int>() { 9,9,9,9 };
                string outputExpected = String.Join(Environment.NewLine, valuesExpected);

                Assert.That(outputActual == outputExpected);

                ////-------------2------------------
                //size_number = "3";
                //commands = new List<string>();
                //commands.Add("push 1");
                //commands.Add("push 7");                
                //commands.Add("pop");                

                //myStack = new StackWithMaxValue(size_number, commands);

                ////actual
                //valuesActual = myStack.MaxValues;
                //outputActual = String.Join(Environment.NewLine, valuesActual);

                ////expected
                //valuesExpected = new List<int>() { };
                //outputExpected = String.Join(Environment.NewLine, valuesExpected);

                //Assert.That(outputActual == outputExpected);

                //////-------------2------------------
                //size_number = "6";
                //commands = new List<string>();
                //commands.Add("push 7");
                //commands.Add("push 1");
                //commands.Add("push 7");
                //commands.Add("max");
                //commands.Add("pop");
                //commands.Add("max");

                //myStack = new StackWithMaxValue(size_number, commands);

                ////actual
                //valuesActual = myStack.MaxValues;
                //outputActual = String.Join(Environment.NewLine, valuesActual);

                ////expected
                //valuesExpected = new List<int>() { 7,7 };
                //outputExpected = String.Join(Environment.NewLine, valuesExpected);

                //Assert.That(outputActual == outputExpected);
            }
        }

        [Test]
        public void MaxValueInWindow() {
            using (var tw = new StringWriter()) {
                Console.SetOut(tw);
                Program.Main();

                ////-------------1------------------
                int windowSize = 7;
                List<int> values = new List<int>() { 73, 65, 24, 14, 44, 20, 65, 97, 27, 6, 42, 1, 6, 41, 16 };

                MaxValueInWindow myStack = new MaxValueInWindow(values, windowSize);

                //actual
                List<int> valuesActual = myStack.MaxValues;
                string outputActual = String.Join(" ", valuesActual);

                //expected
                List<int> valuesExpected = new List<int>() { 73, 97, 97, 97, 97, 97, 97, 97, 42 };
                string outputExpected = String.Join(" ", valuesExpected);

                Assert.That(outputActual == outputExpected);

                ////-------------2------------------
                windowSize = 4;
                values = new List<int>() { 2, 7, 3, 1, 5, 2, 6, 2 };

                myStack = new MaxValueInWindow(values, windowSize);

                //actual
                valuesActual = myStack.MaxValues;
                outputActual = String.Join(" ", valuesActual);

                //expected
                valuesExpected = new List<int>() { 7, 7, 5, 6, 6 };
                outputExpected = String.Join(" ", valuesExpected);

                Assert.That(outputActual == outputExpected);

                //////-------------2------------------
                //size_number = "6";
                //commands = new List<string>();
                //commands.Add("push 7");
                //commands.Add("push 1");
                //commands.Add("push 7");
                //commands.Add("max");
                //commands.Add("pop");
                //commands.Add("max");

                //myStack = new StackWithMaxValue(size_number, commands);

                ////actual
                //valuesActual = myStack.MaxValues;
                //outputActual = String.Join(Environment.NewLine, valuesActual);

                ////expected
                //valuesExpected = new List<int>() { 7,7 };
                //outputExpected = String.Join(Environment.NewLine, valuesExpected);

                //Assert.That(outputActual == outputExpected);
            }
        }
    }
}