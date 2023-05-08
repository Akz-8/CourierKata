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

            result.Should().Be(3);
        }
        
        
        
    }
}