namespace booty;

public class CourseChecker
{
    public static bool CheckCourse(string[] strings)
    {
        return !strings.Contains("N");
    }
}
