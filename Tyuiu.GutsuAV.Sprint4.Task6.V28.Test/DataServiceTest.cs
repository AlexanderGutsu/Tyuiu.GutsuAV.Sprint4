using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GutsuAV.Sprint4.Task6.V28.Lib;


namespace Tyuiu.GutsuAV.Sprint4.Task6.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] array = { "Река", "Озеро", "Болото", "Океан", "Лужа", "Море"};
            string[] wait = { "Река", "Лужа", "Море" };
            string[] res = ds.Calculate(array);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
