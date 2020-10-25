namespace FundAppsTest.Parcels
{
    public abstract class Parcel
    {
        public decimal Cost { get; protected set; }
        public abstract int MaxWeight { get; set; }

        public decimal ExtraWeightCost { get; set; }

        public void SetExtraWeightCost(int weight)
        {
            if (weight > MaxWeight)
            {
                int overweightAmount = weight - MaxWeight;

                ExtraWeightCost = overweightAmount * 2;
            }
        }
    }
}