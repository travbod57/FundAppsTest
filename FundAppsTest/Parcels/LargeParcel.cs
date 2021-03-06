﻿namespace FundAppsTest.Parcels
{
    public class LargeParcel : Parcel
    {
        public LargeParcel()
        {
            Cost = 15.00M;
            MaxWeight = 6;
            OverweightChargePerKg = 2;
        }

        public override int MaxWeight { get; set; }

        public override decimal OverweightChargePerKg { get; set; }
    }
}