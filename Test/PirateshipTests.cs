using booty;
using FluentAssertions;

namespace Test;

public class PirateshipTests
{
    [Fact(DisplayName = "PirateShip should have a row")]
    public void PirateShip_ShouldHaveARow()
    {
        var pirateShip = new Pirateship();
        pirateShip.Row = 1;
        
        Assert.NotNull(pirateShip.Row);
        pirateShip.Row.Should().Be(1);
    }
}