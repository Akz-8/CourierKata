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
            
            if (parcel.Length < 50 && parcel.Height < 50 && parcel.Width < 50)
            {
                return 8;
            }
            
            if (parcel.Length < 100 && parcel.Height < 100 && parcel.Width < 100)
            {
                return 15;
            }
            
            if (parcel.Length > 100 && parcel.Height > 100 && parcel.Width > 100)
            {
                return 25;
            }

            return 0;
        }
    }
}