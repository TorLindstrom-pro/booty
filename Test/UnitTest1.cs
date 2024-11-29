using booty;

namespace Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        bool courseIsClear = Kata.CheckCourse(new [] { "X", "0" });
        Assert.True(courseIsClear);
    }
}
