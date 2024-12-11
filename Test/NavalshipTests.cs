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
	
	[Fact(DisplayName = "Navalship should be able to move, increasing its position")]
	public void Navalship_ShouldBeAbletoMove()
	{
		// Arrange
		var subject = new Navalship
		{
			Position = 0,
			RowCount = 4
		};
		
		//Act
		subject.Move();

		// Assert
		subject.Position.Should().Be(1);
	}

	[Fact(DisplayName = "Navalship should move upwards if starting in the bottom")]
	public void Navalship_StartingOnTheBottomRow_ShouldMoveUpwards()
	{
		// Arrange
		var subject = new Navalship
		{
			Position = 4,
			RowCount = 4
		};
		
		//Act
		subject.Move();

		// Assert
		subject.Position.Should().Be(3);
	}

	[Fact(DisplayName = "Navalship should move upward after reaching the bottom")]
	public void Navalship_AfterReachingTheBottom_ShouldMoveUpwards()
	{
		// Arrange
		var subject = new Navalship
		{
			Position = 3,
			RowCount = 4,
			Direction = Direction.Down
		};
		
		//Act
		subject.Move();
		subject.Move();
		subject.Move();

		// Assert
		subject.Position.Should().Be(2);
		subject.Direction.Should().Be(Direction.Up);
	}

	[Fact(DisplayName = "Navalship should move downward after reaching the top")]
	public void Navalship_AfterReachingTheTop_ShouldMoveDownward()
	{
		// Arrange
		var subject = new Navalship
		{
			Position = 2,
			RowCount = 4,
			Direction = Direction.Up
		};
		
		//Act
		subject.Move();
		subject.Move();
		subject.Move();

		// Assert
		subject.Position.Should().Be(1);
		subject.Direction.Should().Be(Direction.Down);
	}
}