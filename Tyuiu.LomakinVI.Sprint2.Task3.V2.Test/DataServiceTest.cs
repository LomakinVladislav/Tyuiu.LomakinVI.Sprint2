using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LomakinVI.Sprint2.Task3.V2.Lib;

namespace Tyuiu.LomakinVI.Sprint2.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(-44.654, ds.Calculate(4));
        }

        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            Assert.AreEqual(1.5, ds.Calculate(2));
        }

        [TestMethod]
        public void ValidCalculate3()
        {
            DataService ds = new DataService();
            Assert.AreEqual(-0.577, ds.Calculate(0));
        }

        [TestMethod]
        public void ValidCalculate4()
        {
            DataService ds = new DataService();
            Assert.AreEqual(-77.000, ds.Calculate(-7));
        }
    }
}
