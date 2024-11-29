using booty;

namespace Test;

public class CheckCourseTests
{
    [Fact(DisplayName = "If there is no navalfleet in the way, return true")]
    public void CheckCourse_NoNavalFleetInTheWay_ShouldReturnTrue()
    {
        bool courseIsClear = Kata.CheckCourse(new [] { "X", "0" });
        Assert.True(courseIsClear);
    }
}
