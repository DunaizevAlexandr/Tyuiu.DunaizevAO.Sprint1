using Tyuiu.DunaizevAO.Sprint1.Task4.V22.Lib;

namespace Tyuiu.DunaizevAO.Sprint1.Task4.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double itog = 0.054;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(itog, res);
        }
    }
}
