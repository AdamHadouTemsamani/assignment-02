namespace Assignment2.Tests;

using System.Reflection;

public class DelegatesTests
{

    public void Check_If_Reverse_Prints__retcarahc()
    {
        // Arrange
            string input = "character";
            string answer = "retcarahc";

            using var writer = new StringWriter();
            Console.SetOut(writer);

        // Act
            Delegates.reverseString(input);

            var program = Assembly.Load(nameof(Assignment2.Tests));
            program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>()});

        // Assert
            var output = writer.GetStringBuilder().ToString().TrimEnd();
            Assert.Equal(answer, output);
    }

    public void Check_If_Product_Returns_30()
    {
        // Arrange
            decimal value1 = 6, value2 = 5, answer = 30;

        // Act
            var product = Delegates.product(value1,value2);
            
        // Assert
            Assert.Equal(answer, product);
    }

    public void Check_If_NumericallyEquals_Returns_True()
    {
        // Arrange
            int value = 50;
            string stringValue = "0050"; 
            
        // Act & Assert
            Assert.True(Delegates.numericallyEquals(value, stringValue));

    }


}
