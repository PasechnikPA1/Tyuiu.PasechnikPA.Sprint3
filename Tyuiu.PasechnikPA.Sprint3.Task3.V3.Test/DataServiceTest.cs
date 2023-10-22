using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


using Tyuiu.PasechnikPA.Sprint3.Task3.V3.Lib;

namespace Tyuiu.PasechnikPA.Sprint3.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMinCharCount()
        {
            DataService ds = new DataService();
            string str = "cvbmzff orffgtrr dkfvfffdr";
            char chr ='f';
            double res = ds.GetMinCharCount(str, chr);
            int wait = 6;

            Assert.AreEqual(wait, res);


        }
    }
}
