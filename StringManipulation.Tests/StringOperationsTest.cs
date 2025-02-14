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

    [Fact]
    public void QuantityInWords()
    {
        // Arrange
        var strOperations = new StringOperations();

        // Act
        var result = strOperations.QuantintyInWords("cat", 10);

        // Assert
        Assert.StartsWith("ten", result);
        Assert.Contains("cat", result);
    }

    [Fact]
    public void GetStringLength_Exception()
    {
        // Arrange
        var strOperations = new StringOperations();

        // En este caso tenemos que omitir el Act porque va a saltar una excepcion

        // Assert
        // este metodo se le pasa el tipo de excepcion y como argumento una funcion lambda la cual le retornara al metodo la excepcion que se genera
        Assert.ThrowsAny<ArgumentNullException>(() => strOperations.GetStringLength(null));
    }

    [Fact]
    public void GetStringLength()
    {
        // Arrange
        var strOperations = new StringOperations();

        // Act
        var result = strOperations.GetStringLength("world");

        // Assert
        Assert.Equal(5, result);
    }
}
