namespace booty;

public class CourseChecker
{
    public static bool CheckCourse(string[][] strings)
    {
        var tiles = strings
            .SelectMany((row, rowIndex) => row.Select((tile, columnIndex) => (tile, rowIndex, columnIndex)));

        var navalships = tiles
            .Where(tile => tile.tile == "N")
            .Select(tile => new Navalship { Column = tile.columnIndex});
        
        return !navalships.Any();
    }
}
