namespace booty;

public class CourseChecker
{
    public static bool CheckCourse(string[][] map)
    {
        var tiles = GetTilesFromMap(map);

        var navalships = tiles
            .Where(tile => tile.Tile == "N")
            .Select(tile => new Navalship
            {
                Column = tile.ColumnIndex, 
                Position = tile.RowIndex,
                IndexOfBottomRow = map.Length - 1
            })
            .ToList();

        var pirateship = tiles
            .Where(tile => tile.Tile == "X")
            .Select(tile => new Pirateship { Row = tile.RowIndex })
            .Single();

        while (!PirateShipHasReachedSafety())
        {
            pirateship.Move();
            navalships.ForEach(navalship => navalship.Move());
            
            if (navalships.Any(navalship => WithinCannonReach(pirateship, navalship)))
            {
                return false;
            }
        }

        return true;

        bool PirateShipHasReachedSafety()
        {
            return pirateship.Column >= map[0].Length;
        }

        static bool WithinCannonReach(Pirateship pirateship, Navalship navalship)
        {
            var columnWithinReach = navalship.Column >= pirateship.Column - 1 && navalship.Column <= pirateship.Column + 1;
            var rowWithinReach = navalship.Position >= pirateship.Row - 1 && navalship.Position <= pirateship.Row + 1;
            
            return columnWithinReach && rowWithinReach;
        }
    }

    private static List<MapTile> GetTilesFromMap(string[][] strings)
    {
        return strings
            .SelectMany((row, rowIndex) => row.Select((tile, columnIndex) => new MapTile(tile, rowIndex, columnIndex)))
            .ToList();
    }
}

internal class MapTile(string tile, int rowIndex, int columnIndex)
{
    public string Tile { get; } = tile;
    public int RowIndex { get; } = rowIndex;
    public int ColumnIndex { get; } = columnIndex;
}
