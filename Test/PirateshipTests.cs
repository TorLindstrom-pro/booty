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

    [Fact(DisplayName = "PirateShip should have a column from start")]
    public void PirateShip_ShouldHaveAColumnFromStart()
    {
        // act
        var pirateShip = new Pirateship();

        // assert
        pirateShip.Column.Should().Be(0);
    }

    [Fact(DisplayName = "PirateShip should be able to move, increasing it's column")]
    public void PirateShip_ShouldBeAbleToMove()
    {
        // arrange
        var pirateShip = new Pirateship();

        // act
        pirateShip.Move();
        
        // assert
        pirateShip.Column.Should().Be(1);
    }
}