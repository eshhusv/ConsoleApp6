using static Program;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MyClass myClass = new();

            Assert.AreEqual(myClass.IsOnGraph(1, 1, 2, 2), true);
            Assert.AreEqual(myClass.IsOnGraph(2, 2, 1, 1), false);
            Assert.AreEqual(myClass.IsOnGraph(3, 2, 2, 2), true);
            Assert.AreEqual(myClass.IsOnGraph(5, 5, 2, 2), false);
            Assert.AreEqual(myClass.IsOnGraph(0,0, 0, 0), true);
            Assert.AreEqual(myClass.IsOnGraph(-1, -1, -2, -2), false);
        }
    }
}