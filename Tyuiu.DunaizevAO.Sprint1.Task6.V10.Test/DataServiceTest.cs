using Tyuiu.DunaizevAO.Sprint1.Task6.V10.Lib;

namespace Tyuiu.DunaizevAO.Sprint1.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "ФУ не нравится задача 333 3333 33333";
            string itog = "ФУ не нравится задача 33 3333 3333";
            var res = ds.DeleteMiddleLetter(str);
            Assert.AreEqual(itog, res);
        }
    }
}
