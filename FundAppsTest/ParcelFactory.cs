using FundAppsTest.Parcels;

namespace FundAppsTest
{
    public static class ParcelFactory
    {
        public static Parcel GetParcel(Item item)
        {
            Parcel parcel;

            if (item.Height < 10 && item.Width < 10 && item.Depth < 10)
            {
                parcel = new SmallParcel();
            }
            else if (item.Height < 50 && item.Width < 50 && item.Depth < 50)
            {
                parcel = new MediumParcel();
            }
            else if (item.Height < 100 && item.Width < 100 && item.Depth < 100)
            {
                parcel = new LargeParcel();
            }
            else
            {
                parcel = new ExtraLargeParcel();
            }

            parcel.SetExtraWeightCost(item.Weight);

            return parcel;
        }
    }
}