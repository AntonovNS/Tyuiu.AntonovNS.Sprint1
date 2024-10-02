using Tyuiu.AntonovNS.Sprint1.Task3.V15.Lib;

namespace Tyuiu.AntonovNS.Sprint1.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double v1 = 30, v2 = 40, S = 10, T = 3;
            var res = ds.DistanceOverTime(v1, v2, S, T);
            Assert.AreEqual(220, res);
        }
    }
}
