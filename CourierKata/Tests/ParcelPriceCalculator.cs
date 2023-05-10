using System;
using System.Collections.Generic;


namespace CourierKata.Tests
{
    public class ParcelPriceCalculator
    {
        string listOfParcels = String.Empty;
        Decimal total = Decimal.Zero;
        
        public string PriceParcel(List<Parcel> parcels, bool includesSpeedyShipping = false)
        {
            foreach (var parcel in parcels)
            {
                ProcessParcel(parcel);
            }
            
            IncludesSpeedyShipping(includesSpeedyShipping);
            listOfParcels = listOfParcels.Remove(listOfParcels.Length - 2);
            var finalReceipt = listOfParcels + " - Total Cost: $ " + Convert.ToString(total);
            return finalReceipt;
        }
        
        private void IncludesSpeedyShipping(bool includesSpeedyShipping)
        {
            if (includesSpeedyShipping)
            {
                var speedyShippingPrice = Decimal.Multiply(total, 2);
                total = speedyShippingPrice;
                listOfParcels += $"Speedy Shipping: $ {Convert.ToString(speedyShippingPrice)}, ";
            }
        }

        private void ProcessParcel(Parcel parcel)
        {
            if (parcel.Length < 10 && parcel.Height < 10 && parcel.Width < 10)
            {
                listOfParcels += "Small Parcel: $ 3, ";
                total += 3 + CheckForOverweightParcel(parcel.Weight, 1);
            }
            
            if (parcel.Length > 10 && parcel.Height > 10 && parcel.Width > 10 &&
                parcel.Length < 50 && parcel.Height < 50 && parcel.Width < 50)
            {
                listOfParcels += "Medium Parcel: $ 8, ";
                total += 8 + CheckForOverweightParcel(parcel.Weight, 3);
            }
            
            if (parcel.Length > 50 && parcel.Height > 50 && parcel.Width > 50 &&
                parcel.Length < 100 && parcel.Height < 100 && parcel.Width < 100)
            {
                listOfParcels += "Large Parcel: $ 15, ";
                total += 15 + CheckForOverweightParcel(parcel.Weight, 6);
            }
            
            if (parcel.Length > 100 && parcel.Height > 100 && parcel.Width > 100)
            {
                listOfParcels += "XL Parcel: $ 25, ";
                total += (25 + CheckForOverweightParcel(parcel.Weight, 10));
            }
        }

        private decimal CheckForOverweightParcel(int parcelWeight, int limit)
        {
            switch (limit)
            {
                case 1 when parcelWeight > 1:
                {
                    var additionalFeeMultiplier = parcelWeight - 3;
                    return additionalFeeMultiplier * 2;
                }
                case 3 when parcelWeight > 3 && parcelWeight < 6:
                {
                    var additionalFeeMultiplier = parcelWeight - 3;
                    return additionalFeeMultiplier * 2;
                }
                case 6 when parcelWeight > 6 && parcelWeight < 10:
                {
                    var additionalFeeMultiplier = parcelWeight - 6;
                    return additionalFeeMultiplier * 2;
                }
                case 10 when parcelWeight >= 10:
                {
                    var additionalFeeMultiplier = parcelWeight - 10;
                    return additionalFeeMultiplier * 2;
                }
                default:
                    return 0;
            }
        }
    }
}