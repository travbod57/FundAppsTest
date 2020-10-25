using FundAppsTest.Parcels;
using System.Collections.Generic;

namespace FundAppsTest
{
    public class ParcelCostCalculator
    {
        public List<Parcel> SizeParcels(List<Item> items)
        {
            List<Parcel> parcels = new List<Parcel>();

            foreach (var item in items)
            {
                parcels.Add(ParcelFactory.GetParcel(item));
            }

            return parcels;
        }
    }
}