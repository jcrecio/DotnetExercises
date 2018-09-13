namespace DotnetExerciseSolutions.test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FishingTest
    {
        [TestMethod]
        public void ThereAreTwoFishesAlive()
        {
            var fishSizes = new[] { 4, 3, 2, 1, 5 };
            var fishesOrienation = new[] { 0, 1, 0, 0, 0 };
            var alive = Fishing.GetAliveFishesFromStream(fishSizes, fishesOrienation);

            Assert.AreEqual(2, alive);
        }
    }
}
