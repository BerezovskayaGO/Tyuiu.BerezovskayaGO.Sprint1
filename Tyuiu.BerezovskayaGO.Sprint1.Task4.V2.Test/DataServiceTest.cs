using Tyuiu.BerezovskayaGO.Sprint1.Task4.V2.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint1.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.5, res);
        }
    }
}