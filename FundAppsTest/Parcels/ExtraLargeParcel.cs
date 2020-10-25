namespace FundAppsTest.Parcels
{
    public class ExtraLargeParcel : Parcel
    {
        public ExtraLargeParcel()
        {
            Cost = 25.00M;
            MaxWeight = 10; 
            OverweightChargePerKg = 2;
        }

        public override int MaxWeight { get; set; }

        public override decimal OverweightChargePerKg { get; set; }
    }
}