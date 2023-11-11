using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MeshcheryakovPV.Sprint4.Task2.V9.Lib;

namespace Tyuiu.MeshcheryakovPV.Sprint4.Task2.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 1, 2, 3, 4 };
            Assert.AreEqual(8, ds.Calculate(array));
        }
    }
}
