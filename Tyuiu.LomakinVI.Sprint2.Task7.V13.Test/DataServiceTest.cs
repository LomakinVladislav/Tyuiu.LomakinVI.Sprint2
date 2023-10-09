using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LomakinVI.Sprint2.Task7.V13.Lib;

namespace Tyuiu.LomakinVI.Sprint2.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = 0.8;
            double y = 0.7;

            Assert.AreEqual(true, ds.CheckDotInShadedArea(x, y));
        }
    }
}
