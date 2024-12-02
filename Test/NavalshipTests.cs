using booty;
using FluentAssertions;

namespace Test;

public class NavalshipTests
{
	[Fact(DisplayName = "Navalship should have a column")]
	public void Navalship_ShouldHaveAColumn()
	{
		// Act
		var subject = new Navalship
		{
			Column = 1
		};

		// Assert
		subject.Column.Should().Be(1);
	}

	[Fact(DisplayName = "Navalship should have a position")]
	public void Navalship_ShouldHaveAPosition()
	{
		// Act
		var subject = new Navalship
		{
			Position = 1
		};

		// Assert
		subject.Position.Should().Be(1);
	}

	[Fact(DisplayName = "Navalship should have a direction")]
	public void Navalship_ShouldHaveADirection()
	{
		// Act
		var subject = new Navalship
		{
			Direction = Direction.Down
		};

		// Assert
		subject.Direction.Should().Be(Direction.Down);
	}
}