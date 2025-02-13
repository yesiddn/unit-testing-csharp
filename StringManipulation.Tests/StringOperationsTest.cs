namespace StringManipulation.Tests;

public class StringOperationsTest
{
    [Fact]
    public void ConcatenateStrings()
    {
        var strOperations = new StringOperations();

        var result = strOperations.ConcatenateStrings("Hello", "world");

        Assert.Equal("Hello world", result);
    }
}
