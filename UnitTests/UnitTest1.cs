using FundAppsTest;
using FundAppsTest.Parcels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SizeParcels_OneSmallItem_OneSmallParcel()
        {
            List<Item> items = new List<Item>()
            {
                new Item(height: 5, width: 5, depth: 5)
            };

            ParcelCostCalculator calculator = new ParcelCostCalculator();

            Order order = calculator.CreateOrder(items);

            Assert.IsFalse(order.IsSpeedyDelivery);
            Assert.AreEqual(0.00M, order.SpeedyDeliveryCost);
            Assert.AreEqual(3.00M, order.ParcelCosts);
            Assert.AreEqual(3.00M, order.TotalCost);
            Assert.AreEqual(1, order.Parcels.Count);
            Assert.IsInstanceOfType(order.Parcels[0], typeof(SmallParcel));
        }

        [DataTestMethod]
        [DataRow(30, 30, 30)]
        [DataRow(30, 5, 5)]
        [DataRow(5, 30, 5)]
        [DataRow(5, 5, 30)]
        public void SizeParcels_OneMediumItem_OneMediumParcel(int height, int width, int depth)
        {
            List<Item> items = new List<Item>()
            {
                new Item(height, width, depth)
            };

            ParcelCostCalculator calculator = new ParcelCostCalculator();

            Order order = calculator.CreateOrder(items);

            Assert.IsFalse(order.IsSpeedyDelivery);
            Assert.AreEqual(0.00M, order.SpeedyDeliveryCost);
            Assert.AreEqual(8.00M, order.ParcelCosts);
            Assert.AreEqual(8.00M, order.TotalCost);
            Assert.AreEqual(1, order.Parcels.Count);
            Assert.IsInstanceOfType(order.Parcels[0], typeof(MediumParcel));
        }

        [DataTestMethod]
        [DataRow(80, 80, 80)]
        [DataRow(80, 30, 30)]
        [DataRow(30, 80, 30)]
        [DataRow(30, 30, 80)]
        public void SizeParcels_OneLargeItem_OneLargeParcel(int height, int width, int depth)
        {
            List<Item> items = new List<Item>()
            {
                new Item(height, width, depth)
            };

            ParcelCostCalculator calculator = new ParcelCostCalculator();

            Order order = calculator.CreateOrder(items);

            Assert.IsFalse(order.IsSpeedyDelivery);
            Assert.AreEqual(0.00M, order.SpeedyDeliveryCost);
            Assert.AreEqual(15.00M, order.ParcelCosts);
            Assert.AreEqual(15.00M, order.TotalCost);
            Assert.AreEqual(1, order.Parcels.Count);
            Assert.IsInstanceOfType(order.Parcels[0], typeof(LargeParcel));
        }

        [DataTestMethod]
        [DataRow(120, 120, 120)]
        [DataRow(120, 80, 80)]
        [DataRow(80, 120, 80)]
        [DataRow(80, 80, 120)]
        public void SizeParcels_OneExtraLargeItem_OneExtraLargeParcel(int height, int width, int depth)
        {
            List<Item> items = new List<Item>()
            {
                new Item(height, width, depth)
            };

            ParcelCostCalculator calculator = new ParcelCostCalculator();

            Order order = calculator.CreateOrder(items);

            Assert.IsFalse(order.IsSpeedyDelivery);
            Assert.AreEqual(0.00M, order.SpeedyDeliveryCost);
            Assert.AreEqual(25.00M, order.ParcelCosts);
            Assert.AreEqual(25.00M, order.TotalCost);
            Assert.AreEqual(1, order.Parcels.Count);
            Assert.IsInstanceOfType(order.Parcels[0], typeof(ExtraLargeParcel));
        }

        [TestMethod]
        public void SizeParcels_OneOfEachParcel_WithoutSpeedyDelivery()
        {
            List<Item> items = new List<Item>()
            {
                new Item(height: 5, width: 5, depth: 5),
                new Item(height: 30, width: 30, depth: 30),
                new Item(height: 80, width: 80, depth: 80),
                new Item(height: 120, width: 120, depth: 120)
            };

            ParcelCostCalculator calculator = new ParcelCostCalculator();

            Order order = calculator.CreateOrder(items);

            Assert.IsFalse(order.IsSpeedyDelivery);
            Assert.AreEqual(0.00M, order.SpeedyDeliveryCost);
            Assert.AreEqual(51.00M, order.ParcelCosts);
            Assert.AreEqual(51.00M, order.TotalCost);
            Assert.AreEqual(4, order.Parcels.Count);

            Assert.IsInstanceOfType(order.Parcels[0], typeof(SmallParcel));
            Assert.IsInstanceOfType(order.Parcels[1], typeof(MediumParcel));
            Assert.IsInstanceOfType(order.Parcels[2], typeof(LargeParcel));
            Assert.IsInstanceOfType(order.Parcels[3], typeof(ExtraLargeParcel));
        }

        [TestMethod]
        public void SizeParcels_OneOfEachParcel_WithSpeedyDelivery()
        {
            List<Item> items = new List<Item>()
            {
                new Item(height: 5, width: 5, depth: 5),
                new Item(height: 30, width: 30, depth: 30),
                new Item(height: 80, width: 80, depth: 80),
                new Item(height: 120, width: 120, depth: 120)
            };

            ParcelCostCalculator calculator = new ParcelCostCalculator();

            Order order = calculator.CreateOrder(items, speedyDelivery: true);

            Assert.IsTrue(order.IsSpeedyDelivery);
            Assert.AreEqual(51.00M, order.SpeedyDeliveryCost);
            Assert.AreEqual(51.00M, order.ParcelCosts);
            Assert.AreEqual(102.00M, order.TotalCost);
            Assert.AreEqual(4, order.Parcels.Count);
            Assert.IsInstanceOfType(order.Parcels[0], typeof(SmallParcel));
            Assert.IsInstanceOfType(order.Parcels[1], typeof(MediumParcel));
            Assert.IsInstanceOfType(order.Parcels[2], typeof(LargeParcel));
            Assert.IsInstanceOfType(order.Parcels[3], typeof(ExtraLargeParcel));
        }
    }
}