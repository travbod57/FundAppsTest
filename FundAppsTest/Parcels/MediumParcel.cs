﻿namespace FundAppsTest.Parcels
{
    public class MediumParcel : Parcel
    {
        public MediumParcel()
        {
            Cost = 8.00M;
            MaxWeight = 3;
            OverweightChargePerKg = 2;
        }

        public override int MaxWeight { get; set; }

        public override decimal OverweightChargePerKg { get; set; }
    }
}