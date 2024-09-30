using Tyuiu.BerezovskayaGO.Sprint1.Task7.V6.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint1.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(-22, res);
        }
    }
}