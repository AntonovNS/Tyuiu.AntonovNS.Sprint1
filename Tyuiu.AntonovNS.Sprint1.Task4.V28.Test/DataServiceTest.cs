using Tyuiu.AntonovNS.Sprint1.Task4.V28.Lib;

namespace Tyuiu.AntonovNS.Sprint1.Task4.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1, y = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.0498, res);
        }
    }
}
