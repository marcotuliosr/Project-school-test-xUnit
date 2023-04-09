using Xunit;

namespace Teste;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        int x = 1 + 2;
        Assert.Equal(3, x);
    }
}
