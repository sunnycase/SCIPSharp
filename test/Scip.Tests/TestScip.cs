namespace Scip.Tests;

public class TestScip
{
    [Fact]
    public void TestCreate()
    {
        using var scip = new Scip();
    }
}
