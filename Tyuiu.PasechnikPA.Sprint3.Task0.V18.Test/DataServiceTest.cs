﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


using Tyuiu.PasechnikPA.Sprint3.Task0.V18.Lib;

namespace Tyuiu.PasechnikPA.Sprint3.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultSeries()
        {
            DataService ds = new DataService();
            int value = 1;
            int startValue = 1;
            int stopValue = 6;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 0.000;
            Assert.AreEqual(wait,res);
        }
    }
}
