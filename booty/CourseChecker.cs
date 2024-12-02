namespace booty;

public class CourseChecker
{
    public static bool CheckCourse(string[][] strings)
    {
        return !strings.SelectMany(tile => tile).Contains("N");
    }
}
