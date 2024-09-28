using Tyuiu.BerezovskayaGO.Sprint1.Task2.V6.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint1.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = (int)1234.000;
            var res = ds.ConvertMToKm(x);
            Assert.AreEqual(1.234, res);
        }
    }
}