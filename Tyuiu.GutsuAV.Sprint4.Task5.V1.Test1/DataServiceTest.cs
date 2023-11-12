using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GutsuAV.Sprint4.Task5.V1.Lib;

namespace Tyuiu.GutsuAV.Sprint4.Task5.V1.Test1
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { { -3, 2, 0, -4, 1 },
                                            { -2, 0, -1, -4, -2 },
                                            { 0, 2, 1, -4, -3 },
                                            { -3, 0, 1, 2, -1 },
                                            { 2, 2, 1, -2, 0 } };
            int[,] res = ds.Calculate(matrix);
            int[,] wait = new int[5, 5] { { -3, 1, 0, -4, 1 },
                                          { -2, 0, -1, -4, -2 },
                                          { 0, 1, 1, -4, -3 },
                                          { -3, 0, 1, 1, -1 },
                                          { 1, 1, 1, -2, 0 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
