namespace FundAppsTest.Parcels
{
    public class MediumParcel : Parcel
    {
        public MediumParcel()
        {
            Cost = 8.00M;
            MaxWeight = 3;
        }

        public override int MaxWeight { get; set; }
    }
}