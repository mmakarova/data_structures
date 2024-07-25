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
        [Test]
        public void QueueTests() {
            using (var tw = new StringWriter()) {
                Console.SetOut(tw);
                Program.Main();
                //public StautsOfNetPackages(string size_number, string[] packages) {
                string size_number = "1 1";
                List<string> packages = new List<string>();
                packages.Add("0 0");
                StautsOfNetPackages queue = new StautsOfNetPackages(size_number, packages);
                var output = queue.GetOutputList();
                Assert.That(output == "0");

                size_number = "1 2";
                packages = new List<string>();
                packages.Add("0 1");
                packages.Add("1 1");                
                queue = new StautsOfNetPackages(size_number, packages);
                output = queue.GetOutputList();
                Assert.That(output == "0"+Environment.NewLine+"1");

                size_number = "1 2";
                packages = new List<string>();
                packages.Add("0 1");
                packages.Add("0 1");
                queue = new StautsOfNetPackages(size_number, packages);
                output = queue.GetOutputList();
                Assert.That(output == "0" + Environment.NewLine + "-1");


                size_number = "1 0";
                packages = null;// ("0 1" + Environment.NewLine + "0 1").Split(Environment.NewLine);
                queue = new StautsOfNetPackages(size_number, packages);
                output = queue.GetOutputList();
                Assert.That(output == "");
                //numberList = ("5" + Environment.NewLine + "-1 0 4 0 3").Split(Environment.NewLine);
                //treeHeight = new TreeHeight(Convert.ToInt32(numberList[0]), numberList[1]);
                //// Assert.That(treeHeight.GetHeight() == 4);

                //numberList = ("10" + Environment.NewLine + "9 7 5 5 2 9 9 9 2 -1").Split(Environment.NewLine);
                //treeHeight = new TreeHeight(Convert.ToInt32(numberList[0]), numberList[1]);
                //var height = treeHeight.GetHeight();
                //Assert.That(height == 4);
            }
        }
    }
}