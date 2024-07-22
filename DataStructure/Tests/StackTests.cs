using DataStructure;

namespace Tests {
    public class Tests {
        [SetUp]
        public void Setup() {
        }

        [Test]
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
    }
}