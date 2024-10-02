using Tyuiu.AntonovNS.Sprint1.Task7.V22.Lib;

namespace Tyuiu.AntonovNS.Sprint1.Task7.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0.5, y = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1.113, res);
        }
    }
}
