using System.Collections.Generic;
using Xunit;
using FluentAssertions;

namespace CourierKata.Tests
{
    public class ParcelPricingTests
    {

        [Fact]
        public void CalculateCostOfSmallParcelReturnsCorrectAmount()
        {
            var calc = new ParcelPriceCalculator();
            var parcel = new Parcel(1,1,1, 1);

            var result = calc.PriceParcel(new List<Parcel> {parcel});

            result.Should().Be("Small Parcel: $ 3 - Total Cost: $ 3");
        }
        
        [Fact]
        public void CalculateCostOfMediumParcelReturnsCorrectAmount()
        {
            var calc = new ParcelPriceCalculator();
            var parcel = new Parcel(20,20,20, 3);

            var result = calc.PriceParcel(new List<Parcel> {parcel});

            result.Should().Be("Medium Parcel: $ 8 - Total Cost: $ 8");
        }
        
        [Fact]
        public void CalculateCostOfLargeParcelReturnsCorrectAmount()
        {
            var calc = new ParcelPriceCalculator();
            var parcel = new Parcel(60,70,80, 6);

            var result = calc.PriceParcel(new List<Parcel> {parcel});

            result.Should().Be("Large Parcel: $ 15 - Total Cost: $ 15");
        }
        
        [Fact]
        public void CalculateCostOfXlParcelReturnsCorrectAmount()
        {
            var calc = new ParcelPriceCalculator();
            var parcel = new Parcel(120,120,120, 10);

            var result = calc.PriceParcel(new List<Parcel> {parcel});

            result.Should().Be("XL Parcel: $ 25 - Total Cost: $ 25");
        }
        
        [Fact]
        public void CalculateCostOfMultipleParcelReturnsCorrectAmountAndFormat()
        {
            var calc = new ParcelPriceCalculator();
            var extraLargeParcel = new Parcel(120,120,120, 10);
            var smallParcel = new Parcel(3,3,4, 1);

            var parcels = new List<Parcel>
            {
                smallParcel,
                extraLargeParcel
            };

            var result = calc.PriceParcel(parcels);

            result.Should().Be("Small Parcel: $ 3, XL Parcel: $ 25 - Total Cost: $ 28");
        }
        
        
        [Fact]
        public void CalculateCostOfIncludingSpeedyShippingReturnsCorrectAmount()
        {
            var calc = new ParcelPriceCalculator();
            var extraLargeParcel = new Parcel(120,120,120, 10);
            var smallParcel = new Parcel(3,3,4, 1);

            var parcels = new List<Parcel>
            {
                smallParcel,
                extraLargeParcel
            };

            var result = calc.PriceParcel(parcels, true);

            result.Should().Be("Small Parcel: $ 3, XL Parcel: $ 25, Speedy Shipping: $ 56 - Total Cost: $ 56");
        }
        
        [Fact]
        public void CalculateCostOfOverweightParcelsReturnsCorrectAmount()
        {
            var calc = new ParcelPriceCalculator();
            var extraLargeOverWeightParcel = new Parcel(120,120,120, 12);
            var smallParcel = new Parcel(3,3,4, 1);

            var parcels = new List<Parcel>
            {
                smallParcel,
                extraLargeOverWeightParcel
            };

            var result = calc.PriceParcel(parcels, true);

            result.Should().Be("Small Parcel: $ 3, XL Parcel: $ 25, Speedy Shipping: $ 64 - Total Cost: $ 64");
        }
    
    }
}