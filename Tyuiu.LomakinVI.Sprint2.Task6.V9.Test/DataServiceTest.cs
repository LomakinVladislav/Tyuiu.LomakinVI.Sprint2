using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LomakinVI.Sprint2.Task6.V9.Lib;

namespace Tyuiu.LomakinVI.Sprint2.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidMonthDate()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Месяц: Май\nДата: 6", ds.FindDateOfNextDay(5, 5));
            Assert.AreEqual("Месяц: Ноябрь\nДата: 1", ds.FindDateOfNextDay(10, 31));
            Assert.AreEqual("Месяц: Январь\nДата: 1", ds.FindDateOfNextDay(12, 31));
            Assert.AreEqual("Месяц: Июнь\nДата: 4", ds.FindDateOfNextDay(6, 3));
            Assert.AreEqual("Месяц: Февраль\nДата: 21", ds.FindDateOfNextDay(2, 20));
            Assert.AreEqual("Месяц: Июль\nДата: 16", ds.FindDateOfNextDay(7, 15));
            Assert.AreEqual("Месяц: Октябрь\nДата: 1", ds.FindDateOfNextDay(9, 30));
            Assert.AreEqual("Месяц: Март\nДата: 1", ds.FindDateOfNextDay(2, 28));

         }
    }
}
