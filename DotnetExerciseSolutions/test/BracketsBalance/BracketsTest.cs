namespace DotnetExerciseSolutions.test
{
    using DotnetExerciseSolutions.src.BracketsBalance;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class BracketsTest
    {
        [TestMethod]
        public void ExpressionIsBalanced()
        {
            Assert.IsTrue(BracketsBalance.IsBalanced("{[()()]}"));
        }

        [TestMethod]
        public void ExpressionIsNotBalanced()
        {
            Assert.IsFalse(BracketsBalance.IsBalanced("())"));
        }
    }
}
