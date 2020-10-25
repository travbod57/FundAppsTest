namespace FundAppsTest.Parcels
{
    public class ExtraLargeParcel : Parcel
    {
        public ExtraLargeParcel()
        {
            Cost = 25.00M;
            MaxWeight = 10;
        }

        public override int MaxWeight { get; set; }
    }
}