using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LomakinVI.Sprint2.Task2.V29.Lib;

namespace Tyuiu.LomakinVI.Sprint2.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            int x = 6;
            int y = 10;

            Assert.AreEqual(true, ds.CheckDotInShadedArea(x, y));
        }
    }
}
