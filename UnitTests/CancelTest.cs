using GameOfLife;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfLife.app;

namespace UnitTests
{
    [TestClass]
    public class CancelTest
    {
        [TestMethod]
        public void Test_That_Cancel_Stays_False_On_Creating_Grid()
        {
            //Arrange
            var lifeGridControl = new exDGV();
            
            //Act
            var animateGrid = new AnimateGrid(lifeGridControl);

            //Assert
            Assert.AreEqual(animateGrid.Cancelled,false);
        }
    }
}
