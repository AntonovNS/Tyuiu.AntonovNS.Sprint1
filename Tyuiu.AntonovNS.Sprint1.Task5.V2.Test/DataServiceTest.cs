using Tyuiu.AntonovNS.Sprint1.Task5.V2.Lib;

namespace Tyuiu.AntonovNS.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 64;
            var res = ds.FahrenheitTo—elsius(x);
            Assert.AreEqual(18, res);
        }
    }
}
