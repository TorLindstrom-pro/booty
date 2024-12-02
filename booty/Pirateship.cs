namespace booty;

public class Pirateship
{
    public int Row { get; set; }
    public int Position { get; set; }

    public void Move()
    {
        Position++;
    }
}