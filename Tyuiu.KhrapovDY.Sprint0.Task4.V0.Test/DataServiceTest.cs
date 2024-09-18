using Tyuiu.KhrapovDY.Sprint0.Task4.V0.Lib;

namespace Tyuiu.KhrapovDY.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }


        [TestMethod]
        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }


        [TestMethod]
        public void CheckedMultiplicationnValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }

        [TestMethod]
        public void CheckedDivisoinValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }

    }
}