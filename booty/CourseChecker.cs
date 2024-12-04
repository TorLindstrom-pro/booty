namespace booty;

public class CourseChecker
{
    public static bool CheckCourse(string[][] strings)
    {
        var tiles = strings
            .SelectMany((row, rowIndex) => row.Select((tile, columnIndex) => (tile, rowIndex, columnIndex)))
            .ToList();

        var navalships = tiles
            .Where(tile => tile.tile == "N")
            .Select(tile => new Navalship { Column = tile.columnIndex})
            .ToList();

        var pirateship = tiles
            .Where(tile => tile.tile == "X")
            .Select(tile => new Pirateship { Row = tile.rowIndex })
            .Single();

        while (pirateship.Column < tiles.Count)
        {
            pirateship.Move();
            navalships.ForEach(navalship => navalship.Move());
            
            if (navalships.Any(navalship => WithinCannonReach(pirateship, navalship)))
            {
                return false;
            }
        }

        return true;
        
        static bool WithinCannonReach(Pirateship pirateship, Navalship navalship)
        {
            var columnWithinReach = navalship.Column >= pirateship.Column - 1 && navalship.Column <= pirateship.Column + 1;
            var rowWithinReach = navalship.Position >= pirateship.Row - 1 && navalship.Position <= pirateship.Row + 1;
            
            return columnWithinReach && rowWithinReach;
        }
    }
}
