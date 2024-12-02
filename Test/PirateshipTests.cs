using booty;
using FluentAssertions;

namespace Test;

public class PirateshipTests
{
    [Fact(DisplayName = "PirateShip should have a row")]
    public void PirateShip_ShouldHaveARow()
    {
        // act
        var pirateShip = new Pirateship
        {
            Row = 1
        };

        // assert
        pirateShip.Row.Should().Be(1);
    }

    [Fact(DisplayName = "PirateShip should have a position from start")]
    public void PirateShip_ShouldHaveAPositionFromStart()
    {
        // act
        var pirateShip = new Pirateship();

        // assert
        pirateShip.Position.Should().Be(0);
    }
}