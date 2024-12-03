namespace booty;

public class Pirateship
{
    public int Row { get; set; }
    public int Column { get; set; }

    public void Move()
    {
        Column++;
    }
}