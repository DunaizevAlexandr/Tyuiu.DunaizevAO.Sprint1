using Tyuiu.DunaizevAO.Sprint1.Task3.V1.Lib;

namespace Tyuiu.DunaizevAO.Sprint1.Task3.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double r = 2;
            double h = 3;
            double y = 37.68;
            var res = ds.CylinderVolume(r, h);
            Assert.AreEqual(y, res);
        }
    }
}
