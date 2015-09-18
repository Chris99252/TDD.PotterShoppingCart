using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterShoppingCart.Service.Chris;
using System.Collections.Generic;

namespace PotterShoppingCart.Tests.Chris
{
    [TestClass]
    public class PotterShoppingCartTests
    {
        // 單元測試是直述句。
        /// <summary>
        /// Scenario: 第一集買了一本，其他都沒買，價格應為100*1=100元
        /// </summary>
        [TestMethod]
        public void BuyOneBook_第一集買了一本其_他都沒買_價格應為100元()
        {
            // arrange
            var target = new PotterShopping();

            Dictionary<string, double> potterBooks = new Dictionary<string, double>();
            potterBooks.Add("episode1", 1);
            potterBooks.Add("episode2", 0);
            potterBooks.Add("episode3", 0);
            potterBooks.Add("episode4", 0);
            potterBooks.Add("episode5", 0);

            double expected = 100;

            // act
            double actual = target.PotterCalculator(potterBooks);

            // assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Scenario: 第一集買了一本，第二集也買了一本，價格應為100*2*0.95=190
        /// </summary>
        [TestMethod]
        public void BuyTwoBook_第一集買了一本_第二集也買了一本_價格應為_190元()
        {
            // arrange
            var target = new PotterShopping();

            Dictionary<string, double> potterBooks = new Dictionary<string, double>();
            potterBooks.Add("episode1", 1);
            potterBooks.Add("episode2", 1);
            potterBooks.Add("episode3", 0);
            potterBooks.Add("episode4", 0);
            potterBooks.Add("episode5", 0);

            double expected = 190;

            // act
            double actual = target.PotterCalculator(potterBooks);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
