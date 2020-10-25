namespace FundAppsTest.Parcels
{
    public class SmallParcel : Parcel
    {
        public SmallParcel()
        {
            Cost = 3.00M;
            MaxWeight = 1;
            OverweightChargePerKg = 2;
        }

        public override int MaxWeight { get; set; }

        public override decimal OverweightChargePerKg { get; set; }
    }
}