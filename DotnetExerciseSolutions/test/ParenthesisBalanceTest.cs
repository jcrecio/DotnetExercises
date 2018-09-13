namespace DotnetExerciseSolutions.test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ParenthesisTest
    {
        [TestMethod]
        public void ExpressionIsBalanced()
        {
            Assert.IsTrue(ParenthesisBalance.IsBalanced("(()(())())"));
        }

        [TestMethod]
        public void ExpressionIsNotBalanced()
        {
            Assert.IsFalse(ParenthesisBalance.IsBalanced("(()(())()"));
        }
    }
}
