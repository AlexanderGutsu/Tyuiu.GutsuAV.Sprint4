using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GutsuAV.Sprint4.Task7.V13.Lib;

namespace Tyuiu.GutsuAV.Sprint4.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int rows = 3;
            int colums = 3;
            int[,] mtrx = new int[rows, colums];
            string str = "159357246";
            int res = ds.Calculate(rows, colums, str);
            int wait = 30;
            Assert.AreEqual(res, wait);
        }
    }
}
