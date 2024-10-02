using Tyuiu.AntonovNS.Sprint1.Task6.V15.Lib;

namespace Tyuiu.AntonovNS.Sprint1.Task6.V15.Test
{
    [TestClass]
    public class DataSeriveTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "eriygeh@@";
            DataService ds = new DataService();
            bool res = ds.CheckLettersCount(strTest);
            Assert.AreEqual(true, res);
        }
    }
}
