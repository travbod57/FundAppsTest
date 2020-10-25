using FundAppsTest.Parcels;

namespace FundAppsTest
{
    public static class ParcelFactory
    {
        public static Parcel GetParcel(Item item)
        {
            if (item.Height < 10 && item.Width < 10 && item.Depth < 10)
            {
                return new SmallParcel();
            }
            else if (item.Height < 50 && item.Width < 50 && item.Depth < 50)
            {
                return new MediumParcel();
            }
            else if (item.Height < 100 && item.Width < 100 && item.Depth < 100)
            {
                return new LargeParcel();
            }
            else
            {
                return new ExtraLargeParcel();
            }
        }
    }
}