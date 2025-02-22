using Microsoft.Extensions.Logging;
using Moq;

namespace StringManipulation.Tests;

public class StringOperationsTest
{
    // si se requiere omitir un test (como en jasmin con xit o xdescription) se usa Skip
    [Fact(Skip = "Test de skip - TICKET-fix")]
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

    // un test no puede tener parametros por lo que se tiene que usar otra propiedad
    // [Fact]
    [Theory] // util para comprobar varios escenarios de pruebas
    [InlineData("V", 5)] // usando InlineData se puede pasar argumentos al metodo del test
    [InlineData("III", 3)]
    [InlineData("X", 10)]
    public void FromRomanToNumber(string romanNumber, int expected)
    {
        var strOperations = new StringOperations();

        var result = strOperations.FromRomanToNumber(romanNumber);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void CountOccurrences()
    {
        var mockLogger = new Mock<ILogger<StringOperations>>(); // usando la libreria Moq se crea el mock de la deependencia deseada
        var strOperations = new StringOperations(mockLogger.Object); // se le pasa el objet de la deependencia

        var result = strOperations.CountOccurrences("Hello world", 'l');

        Assert.Equal(3, result);
    }
}
