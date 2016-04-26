using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;
namespace Tests
{
    [TestClass()]
    public class DeploymentControllerTests
    {
        [TestMethod()]
        public void DoDeployClickTest()
        {
            //arange
            Point2D mouse1 = default(Point2D);
            Point2D mouse2 = default(Point2D);
            mouse1.X = 360;
            mouse1.Y = 140;
            mouse2.X = 750;
            mouse2.Y = 520;
            int expectedX1 = 0;
            int expectedY1 = 0;
            int expectedX2 = 9;
            int expectedY2 = 9;

            //act
            int actualX1 = DeploymentController.GetCol(360);
            int actualY1 = DeploymentController.GetRow(140);
            int actualX2 = DeploymentController.GetCol(750);
            int actualY2 = DeploymentController.GetRow(520);

            //assert
            Assert.AreEqual(expectedX1, actualX1);
            Assert.AreEqual(expectedY1, actualY1);
            Assert.AreEqual(expectedX2, actualX2);
            Assert.AreEqual(expectedY2, actualY2);

        }
    }
}