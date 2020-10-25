using FundAppsTest.Parcels;
using System.Collections.Generic;
using System.Linq;

namespace FundAppsTest
{
    public class Order
    {
        public Order()
        {
            Parcels = new List<Parcel>();
        }

        public List<Parcel> Parcels { get; set; }

        public decimal TotalCost 
        { 
            get
            {
                return Parcels.Sum(p => p.Cost);
            }
        }
    }
}