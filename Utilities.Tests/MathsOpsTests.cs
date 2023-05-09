namespace Utilities.Tests
{
    [TestClass]
    public class MathsOpsTests
    {
        [TestMethod]
        public void Test_Add()
        {
            var subject = new MathsOps();

            var actual = subject.Add(1, 1);

            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void Test_Divide()
        {
            var subject = new MathsOps();

            var actual = subject.Divide(4, 2);

            Assert.AreEqual(2, actual);
        }
    }
}