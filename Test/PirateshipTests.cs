using booty;
using FluentAssertions;

namespace Test;

public class PirateshipTests
{
    [Fact(DisplayName = "PirateShip should have a row")]
    public void PirateShip_ShouldHaveARow()
    {
        // arrange
        var pirateShip = new Pirateship();
        
        // act
        pirateShip.Row = 1;
        
        // assert
        pirateShip.Row.Should().Be(1);
    }
}