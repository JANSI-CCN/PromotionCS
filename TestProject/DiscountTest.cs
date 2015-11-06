using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionCS;

namespace TestProject
{
    [TestClass]
    public class DiscountTest
    {
        [TestMethod]
        public void Test1ABuy1Item()
        {
            //setup
            Promotion promo = new Promotion(); //TODO: setup the promotion as you see fit
            DiscountCalculator dc = new DiscountCalculator(promo);

            Order order = new Order(); //TODO: setup the order, you can refer to SampleTest.cs for example

            //exercise
            Order newOrder = dc.CalculateDiscount(order);

            //verify
            double expectedValue = 0;//TODO: set the expected value;
            Assert.AreEqual(expectedValue, newOrder.TotalPrice, 0.001);
            //TODO: add additional verification if necessary
        }

        [TestMethod]
        public void Test1BBuy2Item()
        {
            //setup
            Promotion promo = new Promotion(); //TODO: setup the promotion as you see fit
            promo.setPromo(0.7);
            DiscountCalculator dc = new DiscountCalculator(promo);

            Order order = new Order(); //TODO: setup the order, you can refer to SampleTest.cs for example
            order.Add(Products.GetProduct("blueDress"), 1);
            order.Add(Products.GetProduct("redDress"), 1);

            //exercise
            Order newOrder = dc.CalculateDiscount(order);

            //verify
            double expectedValue = 170;//TODO: set the expected value;
            Assert.AreEqual(expectedValue, newOrder.TotalPrice, 0.001);
            //TODO: add additional verification if necessary
        }
    }
}
