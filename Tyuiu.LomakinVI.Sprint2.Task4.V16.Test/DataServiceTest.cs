using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LomakinVI.Sprint2.Task4.V16.Lib;


namespace Tyuiu.LomakinVI.Sprint2.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalcualte1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            Assert.AreEqual(1.129, ds.Calculate(x, y));
        }

        [TestMethod]
        public void ValidCalcualte2()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 2;
            Assert.AreEqual(1.96, ds.Calculate(x, y));
        }
    }
}
