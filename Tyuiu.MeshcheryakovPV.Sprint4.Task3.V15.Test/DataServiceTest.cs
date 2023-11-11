using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MeshcheryakovPV.Sprint4.Task3.V15.Lib;

namespace Tyuiu.MeshcheryakovPV.Sprint4.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();

            int[,] ar = { { 1, 2, 3, 1 },
                          { 2, 1, 3, 1 },
                          { 1, 1, 1, 1} };
            Assert.AreEqual(4, ds.Calculate(ar));
        }
    }
}
