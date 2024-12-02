namespace booty;

public class Navalship
{
	public int Column { get; set; }
	public int Position { get; set; }
	public Direction Direction { get; set; }
}

public enum Direction
{
	Up = 1,
	Down = 2
}