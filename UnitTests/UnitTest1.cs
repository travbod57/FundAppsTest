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
        public void CreateOrder_OneSmallItem_OneSmallParcel_InsideWeight()
        {
            List<Item> items = new List<Item>()
            {
                new Item(height: 5, width: 5, depth: 5, weight: 1)
            };

            ParcelCostCalculator calculator = new ParcelCostCalculator();

            Order order = calculator.CreateOrder(items);

            Assert.IsFalse(order.IsSpeedyDelivery);
            Assert.AreEqual(0.00M, order.ExtraWeightCost);
            Assert.AreEqual(0.00M, order.SpeedyDeliveryCost);
            Assert.AreEqual(3.00M, order.ParcelCosts);
            Assert.AreEqual(3.00M, order.TotalCost);
            Assert.AreEqual(1, order.Parcels.Count);
            Assert.IsInstanceOfType(order.Parcels[0], typeof(SmallParcel));
        }

        [TestMethod]
        public void CreateOrder_OneSmallItem_OneSmallParcel_OutsideWeight()
        {
            List<Item> items = new List<Item>()
            {
                new Item(height: 5, width: 5, depth: 5, weight: 2)
            };

            ParcelCostCalculator calculator = new ParcelCostCalculator();

            Order order = calculator.CreateOrder(items);

            Assert.IsFalse(order.IsSpeedyDelivery);
            Assert.AreEqual(0.00M, order.SpeedyDeliveryCost);
            Assert.AreEqual(2.00M, order.ExtraWeightCost);
            Assert.AreEqual(3.00M, order.ParcelCosts);
            Assert.AreEqual(5.00M, order.TotalCost);
            Assert.AreEqual(1, order.Parcels.Count);
            Assert.IsInstanceOfType(order.Parcels[0], typeof(SmallParcel));
        }

        [DataTestMethod]
        [DataRow(30, 30, 30)]
        [DataRow(30, 5, 5)]
        [DataRow(5, 30, 5)]
        [DataRow(5, 5, 30)]
        public void CreateOrder_OneMediumItem_OneMediumParcel_InsideWeight(int height, int width, int depth)
        {
            List<Item> items = new List<Item>()
            {
                new Item(height, width, depth, weight: 3)
            };

            ParcelCostCalculator calculator = new ParcelCostCalculator();

            Order order = calculator.CreateOrder(items);

            Assert.IsFalse(order.IsSpeedyDelivery);
            Assert.AreEqual(0.00M, order.SpeedyDeliveryCost);
            Assert.AreEqual(0.00M, order.ExtraWeightCost);
            Assert.AreEqual(8.00M, order.ParcelCosts);
            Assert.AreEqual(8.00M, order.TotalCost);
            Assert.AreEqual(1, order.Parcels.Count);
            Assert.IsInstanceOfType(order.Parcels[0], typeof(MediumParcel));
        }

        [DataTestMethod]
        [DataRow(30, 30, 30)]
        [DataRow(30, 5, 5)]
        [DataRow(5, 30, 5)]
        [DataRow(5, 5, 30)]
        public void CreateOrder_OneMediumItem_OneMediumParcel_OutsideWeight(int height, int width, int depth)
        {
            List<Item> items = new List<Item>()
            {
                new Item(height, width, depth, weight: 5)
            };

            ParcelCostCalculator calculator = new ParcelCostCalculator();

            Order order = calculator.CreateOrder(items);

            Assert.IsFalse(order.IsSpeedyDelivery);
            Assert.AreEqual(0.00M, order.SpeedyDeliveryCost);
            Assert.AreEqual(4.00M, order.ExtraWeightCost);
            Assert.AreEqual(8.00M, order.ParcelCosts);
            Assert.AreEqual(12.00M, order.TotalCost);
            Assert.AreEqual(1, order.Parcels.Count);
            Assert.IsInstanceOfType(order.Parcels[0], typeof(MediumParcel));
        }

        [DataTestMethod]
        [DataRow(80, 80, 80)]
        [DataRow(80, 30, 30)]
        [DataRow(30, 80, 30)]
        [DataRow(30, 30, 80)]
        public void CreateOrder_OneLargeItem_OneLargeParcel_InsideWeight(int height, int width, int depth)
        {
            List<Item> items = new List<Item>()
            {
                new Item(height, width, depth, weight: 6)
            };

            ParcelCostCalculator calculator = new ParcelCostCalculator();

            Order order = calculator.CreateOrder(items);

            Assert.IsFalse(order.IsSpeedyDelivery);
            Assert.AreEqual(0.00M, order.SpeedyDeliveryCost);
            Assert.AreEqual(0.00M, order.ExtraWeightCost);
            Assert.AreEqual(15.00M, order.ParcelCosts);
            Assert.AreEqual(15.00M, order.TotalCost);
            Assert.AreEqual(1, order.Parcels.Count);
            Assert.IsInstanceOfType(order.Parcels[0], typeof(LargeParcel));
        }

        [DataTestMethod]
        [DataRow(80, 80, 80)]
        [DataRow(80, 30, 30)]
        [DataRow(30, 80, 30)]
        [DataRow(30, 30, 80)]
        public void CreateOrder_OneLargeItem_OneLargeParcel_OutsideWeight(int height, int width, int depth)
        {
            List<Item> items = new List<Item>()
            {
                new Item(height, width, depth, weight: 9)
            };

            ParcelCostCalculator calculator = new ParcelCostCalculator();

            Order order = calculator.CreateOrder(items);

            Assert.IsFalse(order.IsSpeedyDelivery);
            Assert.AreEqual(0.00M, order.SpeedyDeliveryCost);
            Assert.AreEqual(6.00M, order.ExtraWeightCost);
            Assert.AreEqual(15.00M, order.ParcelCosts);
            Assert.AreEqual(21.00M, order.TotalCost);
            Assert.AreEqual(1, order.Parcels.Count);
            Assert.IsInstanceOfType(order.Parcels[0], typeof(LargeParcel));
        }

        [DataTestMethod]
        [DataRow(120, 120, 120)]
        [DataRow(120, 80, 80)]
        [DataRow(80, 120, 80)]
        [DataRow(80, 80, 120)]
        public void CreateOrder_OneExtraLargeItem_OneExtraLargeParcel_InsideWeight(int height, int width, int depth)
        {
            List<Item> items = new List<Item>()
            {
                new Item(height, width, depth, weight: 10)
            };

            ParcelCostCalculator calculator = new ParcelCostCalculator();

            Order order = calculator.CreateOrder(items);

            Assert.IsFalse(order.IsSpeedyDelivery);
            Assert.AreEqual(0.00M, order.SpeedyDeliveryCost);
            Assert.AreEqual(0.00M, order.ExtraWeightCost);
            Assert.AreEqual(25.00M, order.ParcelCosts);
            Assert.AreEqual(25.00M, order.TotalCost);
            Assert.AreEqual(1, order.Parcels.Count);
            Assert.IsInstanceOfType(order.Parcels[0], typeof(ExtraLargeParcel));
        }

        [DataTestMethod]
        [DataRow(120, 120, 120)]
        [DataRow(120, 80, 80)]
        [DataRow(80, 120, 80)]
        [DataRow(80, 80, 120)]
        public void CreateOrder_OneExtraLargeItem_OneExtraLargeParcel_OutsideWeight(int height, int width, int depth)
        {
            List<Item> items = new List<Item>()
            {
                new Item(height, width, depth, weight: 14)
            };

            ParcelCostCalculator calculator = new ParcelCostCalculator();

            Order order = calculator.CreateOrder(items);

            Assert.IsFalse(order.IsSpeedyDelivery);
            Assert.AreEqual(0.00M, order.SpeedyDeliveryCost);
            Assert.AreEqual(8.00M, order.ExtraWeightCost);
            Assert.AreEqual(25.00M, order.ParcelCosts);
            Assert.AreEqual(33.00M, order.TotalCost);
            Assert.AreEqual(1, order.Parcels.Count);
            Assert.IsInstanceOfType(order.Parcels[0], typeof(ExtraLargeParcel));
        }

        [TestMethod]
        public void CreateOrder_OneOfEachParcel_WithoutSpeedyDelivery()
        {
            List<Item> items = new List<Item>()
            {
                new Item(height: 5, width: 5, depth: 5, weight: 1),
                new Item(height: 30, width: 30, depth: 30, weight: 3),
                new Item(height: 80, width: 80, depth: 80, weight: 6),
                new Item(height: 120, width: 120, depth: 120, weight: 10)
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
        public void CreateOrder_OneOfEachParcel_WithSpeedyDelivery()
        {
            List<Item> items = new List<Item>()
            {
                new Item(height: 5, width: 5, depth: 5, weight: 1),
                new Item(height: 30, width: 30, depth: 30, weight: 3),
                new Item(height: 80, width: 80, depth: 80, weight: 6),
                new Item(height: 120, width: 120, depth: 120, weight: 10),
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