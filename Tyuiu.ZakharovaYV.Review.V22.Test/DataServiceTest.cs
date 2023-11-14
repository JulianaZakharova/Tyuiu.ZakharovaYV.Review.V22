using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZakharovaYV.Review.V22.Lib;

namespace Tyuiu.ZakharovaYV.Review.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            int rows = 5;
            int columns = 3;
            int[,] mtrx = new int[rows, columns];
            string str = "695324951753684";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, columns, str);
            int wait = 9216;
            Assert.AreEqual(wait, res);
        }
    }
}
