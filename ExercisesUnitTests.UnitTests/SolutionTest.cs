using NUnit.Framework;
using ExercisesUnitTests;

namespace ExercisesUnitTests.UnitTests
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual("Even", SolutionClass.EvenOrOdd(2));
            Assert.AreEqual("Odd", SolutionClass.EvenOrOdd(1));
            Assert.AreEqual("Even", SolutionClass.EvenOrOdd(0));
            Assert.AreEqual("Odd", SolutionClass.EvenOrOdd(7));
            Assert.AreEqual("Odd", SolutionClass.EvenOrOdd(-1));
        }

        //[Test, Description("should fire the cannons when ready")]
        //public void SampleAyeTest()
        //{
        //    Dictionary<string, string> gunners = new Dictionary<string, string>
        //    {
        //      {"Mike", "aye"},
        //      {"Joe", "aye"},
        //      {"Johnson", "aye"},
        //      {"Peter", "aye"}
        //    };

        //    Assert.AreEqual("Fire!", Pirates.CannonsReady(gunners));
        //}

        //[Test, Description("should shiver me timbers if not ready")]
        //public void SampleNayTest()
        //{
        //    Dictionary<string, string> gunners = new Dictionary<string, string>
        //    {
        //      {"Mike", "aye"},
        //      {"Joe", "nay"},
        //      {"Johnson", "aye"},
        //      {"Peter", "aye"}
        //    };

        //    Assert.AreEqual("Shiver me timbers!", Pirates.CannonsReady(gunners));
        //}
    }
}