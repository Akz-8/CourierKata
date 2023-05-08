using System;

namespace CourierKata.Tests
{
    public class ParcelPriceCalculator
    {
        public string PriceParcel(Parcel parcel)
        {
            if (parcel.Length < 10 && parcel.Height < 10 && parcel.Width < 10)
            {
                return "Small Parcel: $3 - Total Cost: $3";
            }
            
            if (parcel.Length < 50 && parcel.Height < 50 && parcel.Width < 50)
            {
                return "Medium Parcel: $8 - Total Cost: $8";
            }
            
            if (parcel.Length < 100 && parcel.Height < 100 && parcel.Width < 100)
            {
                return "Large Parcel: $15 - Total Cost: $15";
            }
            
            if (parcel.Length > 100 && parcel.Height > 100 && parcel.Width > 100)
            {
                return "XL Parcel: $25 - Total Cost: $25";
            }

            return "No parcels recorded - Total Cost: $0";
        }
    }
}