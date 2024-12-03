﻿namespace booty;

public class CourseChecker
{
    public static bool CheckCourse(string[][] strings)
    {
        var tiles = strings
            .SelectMany((row, rowIndex) => row.Select((tile, columnIndex) => (tile, rowIndex, columnIndex)))
            .ToList();

        var navalships = tiles
            .Where(tile => tile.tile == "N")
            .Select(tile => new Navalship { Column = tile.columnIndex});

        var pirateship = tiles
            .Where(tile => tile.tile == "X")
            .Select(tile => new Pirateship { Row = tile.rowIndex })
            .First();

        return !navalships.Any(navalship => WithinCannonReach(pirateship, navalship));
        
        static bool WithinCannonReach(Pirateship pirateship, Navalship navalship)
        {
            var columnWithinReach = navalship.Column >= pirateship.Position - 1 && navalship.Column <= pirateship.Position + 1;
            var rowWithinReach = navalship.Position >= pirateship.Row - 1 && navalship.Position <= pirateship.Row + 1;
            
            return columnWithinReach && rowWithinReach;
        }
    }
}
