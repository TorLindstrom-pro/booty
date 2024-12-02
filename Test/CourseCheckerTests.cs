using booty;
using FluentAssertions;

namespace Test;

public class CourseCheckerTests
{
    [Fact(DisplayName = "If there is no navalship in the way, return true")]
    public void CheckCourse_NoNavalshipInTheWay_ShouldReturnTrue()
    {
        // Act
        var courseIsClear = CourseChecker.CheckCourse(new string[][] {["X", "0"]});
        
        // Assert
        courseIsClear.Should().BeTrue();
    }
    
    [Fact(DisplayName = "If there is a navalship in the way, return false")]
    public void CheckCourse_NavalshipInTheWay_ShouldReturnFalse()
    {
        // Act
        var courseIsClear = CourseChecker.CheckCourse(new string[][] {["X", "N"]});
        
        // Assert
        courseIsClear.Should().BeFalse();
    }
}
