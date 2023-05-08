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
            var parcel = new Parcel(1,1,1);

            var result = calc.PriceParcel(parcel);

            result.Should().Be("Small Parcel: $3 - Total Cost: $3");
        }
        
        [Fact]
        public void CalculateCostOfMediumParcelReturnsCorrectAmount()
        {
            var calc = new ParcelPriceCalculator();
            var parcel = new Parcel(20,20,20);

            var result = calc.PriceParcel(parcel);

            result.Should().Be("Medium Parcel: $8 - Total Cost: $8");
        }
        
        [Fact]
        public void CalculateCostOfLargeParcelReturnsCorrectAmount()
        {
            var calc = new ParcelPriceCalculator();
            var parcel = new Parcel(60,70,80);

            var result = calc.PriceParcel(parcel);

            result.Should().Be("Large Parcel: $15 - Total Cost: $15");
        }
        
        [Fact]
        public void CalculateCostOfXlParcelReturnsCorrectAmount()
        {
            var calc = new ParcelPriceCalculator();
            var parcel = new Parcel(120,120,120);

            var result = calc.PriceParcel(parcel);

            result.Should().Be("XL Parcel: $25 - Total Cost: $25");
        }

    }
}