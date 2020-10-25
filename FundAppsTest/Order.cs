using FundAppsTest.Parcels;
using System.Collections.Generic;
using System.Linq;

namespace FundAppsTest
{
    public class Order
    {
        public Order(bool isSpeedyDelivery = false)
        {
            Parcels = new List<Parcel>();

            IsSpeedyDelivery = isSpeedyDelivery;
        }

        public List<Parcel> Parcels { get; set; }

        public bool IsSpeedyDelivery { get; private set; }

        public decimal ParcelCosts
        {
            get
            {
                return Parcels.Sum(p => p.Cost);
            }
        }

        public decimal ExtraWeightCost
        {
            get
            {
                return Parcels.Sum(p => p.ExtraWeightCost);
            }
        }

        public decimal SpeedyDeliveryCost
        {
            get
            {
                if (IsSpeedyDelivery)
                {
                    return TotalCost / 2;
                }

                return 0;
            }
        }

        public decimal TotalCost 
        { 
            get
            {
                if (IsSpeedyDelivery)
                {
                    return (ParcelCosts * 2) + ExtraWeightCost;
                }
                else
                {
                    return ParcelCosts + ExtraWeightCost;
                }
            }
        }
    }
}