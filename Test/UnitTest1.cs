using booty;

namespace Test;

public class CheckCourseTests
{
    [Fact(DisplayName = "If there is no navalfleet in the way, return true")]
    public void CheckCourse_NoNavalFleetInTheWay_ShouldReturnTrue()
    {
        bool courseIsClear = Kata.CheckCourse(new string[][] { ["X", "0"] });
        Assert.True(courseIsClear);
    }
    
    [Fact(DisplayName = "If there is a navalfleet in the way, return false")]
    public void CheckCourse_NavalFleetInTheWay_ShouldReturnFalse()
    {
        bool courseIsClear = Kata.CheckCourse(new string[][] { ["X", "N"] });
        Assert.False(courseIsClear);
    }
    
    [Fact(DisplayName = "If the navalfleet moves out of the way, return true")]
    public void CheckCourse_NavalFleetMovesOutOfTheWay_ShouldReturnTrue()
    {
        bool courseIsClear = Kata.CheckCourse(new string [][] { ["X", "0", "N"],
                                                        [ "0", "0", "0" ]});
        Assert.True(courseIsClear);
    }
}
