using booty;

namespace Test;

public class CourseCheckerTests
{
    [Fact(DisplayName = "If there is no navalfleet in the way, return true")]
    public void CheckCourse_NoNavalFleetInTheWay_ShouldReturnTrue()
    {
        // Act
        var courseIsClear = CourseChecker.CheckCourse(["X", "0"]);
        
        // Assert
        Assert.True(courseIsClear);
    }
    
    [Fact(DisplayName = "If there is a navalfleet in the way, return false")]
    public void CheckCourse_NavalFleetInTheWay_ShouldReturnFalse()
    {
        // Act
        var courseIsClear = CourseChecker.CheckCourse(["X", "N"]);
        
        // Assert
        Assert.False(courseIsClear);
    }
}
