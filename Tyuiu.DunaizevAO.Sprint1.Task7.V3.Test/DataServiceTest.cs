using Tyuiu.DunaizevAO.Sprint1.Task7.V3.Lib;

namespace Tyuiu.DunaizevAO.Sprint1.Task7.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double y = 2;
            double x = 3;
            double z = 0.282;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(z, res);
        }
    }
}
