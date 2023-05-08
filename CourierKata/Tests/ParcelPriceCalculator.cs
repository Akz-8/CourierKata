using System;
using System.Collections.Generic;


namespace CourierKata.Tests
{
    public class ParcelPriceCalculator
    {
        public string PriceParcel(List<Parcel> parcels, bool includesSpeedyShipping = false)
        {
            var listOfParcels = String.Empty;
            var total = Decimal.Zero;
            
            for (int i = 0; i < parcels.Count; i++)
            {
                var parcelInformation = ParcelSize(parcels[i]);
                listOfParcels += $"{parcelInformation.Item1} ";
                total += parcelInformation.Item2;
            }

            if (includesSpeedyShipping)
            {
                var speedyShippingPrice = Decimal.Multiply(total, 2);
                total = speedyShippingPrice;
                listOfParcels += $"Speedy Shipping: $ {Convert.ToString(speedyShippingPrice)}";
            }
            else
            {
                listOfParcels = listOfParcels.Remove(listOfParcels.Length - 2);
            }

            var finalReceipt = listOfParcels + " - Total Cost: $ " + Convert.ToString(total);
            return finalReceipt;
        }

        private Tuple<string, Decimal> ParcelSize(Parcel parcel)
        {
            if (parcel.Length < 10 && parcel.Height < 10 && parcel.Width < 10)
            {
                return new Tuple<string, decimal>("Small Parcel: $ 3,", 3);
            }
            
            if (parcel.Length < 50 && parcel.Height < 50 && parcel.Width < 50)
            {
                return new Tuple<string, decimal>("Medium Parcel: $ 8,", 8);
            }
            
            if (parcel.Length < 100 && parcel.Height < 100 && parcel.Width < 100)
            {
                return new Tuple<string, decimal>("Large Parcel: $ 15,", 15);
            }
            
            if (parcel.Length > 100 && parcel.Height > 100 && parcel.Width > 100)
            {
                return new Tuple<string, decimal>("XL Parcel: $ 25,", 25);
            }
            
            return new Tuple<string, decimal>("No parcels recorded", 0);
        }
    }
}