namespace Assignment2.Tests;

using System.Reflection;

public class DelegatesTests
{
    // Delegates
    Action<string> reverseString = s => 
     {  
        var reversedString = String.Empty;
        char[] charArray = s.ToCharArray();

        for(int i = charArray.Length-1; i > -1; i--)
        {
            reversedString += charArray[i];
        }
        Console.WriteLine(reversedString);
        
     };

     public static Func<decimal, decimal, decimal> product = ((value1, value2) => value1 * value2);

     public static Func<int, string, bool> numericallyEquals = ((value, stringValue) =>
     {
        if(Int32.TryParse(stringValue, out int parsedValue))
        {
            if(parsedValue == value) return true;
        }
        return false;

     });

    // Tests 

    [Fact]
    public void Check_If_Reverse_Prints__retcarahc()
    {
        // Arrange
            string input = "character";
            string answer = "retcarahc";

            using var writer = new StringWriter();
            Console.SetOut(writer);

        // Act
            reverseString(input);

        // Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal(answer, output);
    }

    [Fact]
    public void Check_If_Product_Returns_30()
    {
        // Arrange
            decimal value1 = 6, value2 = 5, answer = 30;

        // Act
            var productVal = product(value1,value2);
            
        // Assert
            Assert.Equal(answer, productVal);
    }

    [Fact]
    public void Check_If_NumericallyEquals_Returns_True()
    {
        // Arrange
            int value = 50;
            string stringValue = "0050"; 
            
        // Act & Assert
            Assert.True(numericallyEquals(value, stringValue));

    }


}
