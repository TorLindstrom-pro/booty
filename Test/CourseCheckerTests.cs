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

    [Fact(DisplayName = "If there is a navalship within cannon reach from start return false")]
    public void CheckCourse_NavalshipStartsWithinReach_ShouldReturnFalse()
    {
        // Arrange
        var map = new string[][]
        {
            ["X", "0", "0"], 
            ["N", "0", "0"] 
        };
        
        // Act
        var result = CourseChecker.CheckCourse(map);
        
        // Assert
        result.Should().BeFalse();
    }

    [Fact(DisplayName = "If there is a navalship that will catch the pirates return false")]
    public void CheckCourse_NavalshipWillCatchThePirates_ShouldReturnFalse()
    {
        // Arrange
        var map = new string[][]
        {
            ["X", "0", "0"], 
            ["0", "0", "N"], 
        };
        
        // Act
        var result = CourseChecker.CheckCourse(map);
        
        // Assert
        result.Should().BeFalse();
    }
}
