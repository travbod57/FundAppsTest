namespace FundAppsTest.Parcels
{
    public class HeavyParcel : Parcel
    {
        public HeavyParcel()
        {
            Cost = 50.00M;
            MaxWeight = 50;
            OverweightChargePerKg = 1;
        }

        public override int MaxWeight { get; set; }

        public override decimal OverweightChargePerKg { get; set; }
    }
}