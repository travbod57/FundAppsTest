﻿using FundAppsTest.Parcels;
using System.Collections.Generic;

namespace FundAppsTest
{
    public class ParcelCostCalculator
    {
        public Order CreateOrder(List<Item> items)
        {
            Order order = new Order();

            foreach (var item in items)
            {
                order.Parcels.Add(ParcelFactory.GetParcel(item));
            }

            return order;
        }
    }
}