using ConsolePipeline;

namespace TestProject1
{
    [TestClass]
    public class TestNameClass
    {
        [TestMethod]
        public void TestMethod1()
        {
          Name name = new Name();
          var expected = "Hi Kavinya";
            var actual = name.GetName();
            Assert.AreEqual(expected, actual);  
        }
    }
}