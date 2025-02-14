namespace StringManipulation.Tests;

public class StringOperationsTest
{
    [Fact]
    public void ConcatenateStrings()
    {
        // Arrange
        var strOperations = new StringOperations();

        // Act
        var result = strOperations.ConcatenateStrings("Hello", "world");

        // Assert
        Assert.NotNull(result);
        Assert.NotEmpty(result);
        Assert.Equal("Hello world", result);
    }

    // es buena practica con los booleanos que existan pruebas diferentes para ambos casos, true y false
    // para diferenciar los metodos, en los nombres se usa _False o _True
    [Fact]
    public void IsPalindrome_True()
    {
        // Arrangevar
        var strOperations = new StringOperations();

        // Act
        var result = strOperations.IsPalindrome("ama");

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsPalindrome_False()
    {
        // Arrangevar
        var strOperations = new StringOperations();

        // Act
        var result = strOperations.IsPalindrome("roma");

        // Assert
        Assert.False(result);
    }
}
