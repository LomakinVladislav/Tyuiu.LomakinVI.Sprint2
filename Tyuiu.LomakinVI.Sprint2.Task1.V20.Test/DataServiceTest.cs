using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LomakinVI.Sprint2.Task1.V20.Lib;


namespace Tyuiu.LomakinVI.Sprint2.Task1.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();

            int a = 242;
            int b = 155;
            int c = 456;
            int d = 17;

            bool[] waited = { false, false, false, true, true, true };
            CollectionAssert.AreEqual(waited, ds.GetLogicOperations(a, b, c, d));
        }
    }
}
