namespace booty;

public class Navalship
{
	public int Column { get; set; }
	public int Position { get; set; }
	public Direction Direction { get; set; }
	public int IndexOfBottomRow { get; init; }

	public void Move()
	{
		if (Position == IndexOfBottomRow) Direction = Direction.Up;
		else if (Position == 0) Direction = Direction.Down;

		if (Direction == Direction.Up) Position--;
		else Position++;
	}
}

public enum Direction
{
	Up = 1,
	Down = 2
}