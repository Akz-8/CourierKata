using System;

namespace CourierKata.Tests
{
    public class ParcelPriceCalculator
    {
        public decimal PriceParcel(Parcel parcel)
        {
            if (parcel.Length < 10 && parcel.Height < 10 && parcel.Width < 10)
            {
                return 3;
            }

            return 0;
        }
    }
}