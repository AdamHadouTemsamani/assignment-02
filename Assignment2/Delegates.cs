namespace Assignment2;

public static class Delegates
{
   
     static Action<string> reverse = s => Console.WriteLine(s.Reverse());
    
     static Action<string> reverseString = s => 
     {  
        var reversedString = String.Empty;
        char[] charArray = s.ToCharArray();

        for(int i = charArray.Length-1; i > -1; i--)
        {
            reversedString += charArray[i];
        }
        Console.WriteLine(reversedString);
        
     };


     static Func<decimal, decimal, decimal> product = ((value1, value2) => value1 * value2);

     static Func<int, string, bool> numericallyEqual = ((value, stringValue) => 
     {
        var parsedValue = Int32.Parse(stringValue);
        if(value == parsedValue) return true;
        return false;
     });

     static Func<int, string, bool> numericallyEquals = ((value, stringValue) =>
     {
        if(Int32.TryParse(stringValue, out int parsedValue))
        {
            if(parsedValue == value) return true;
        }
        return false;

     });

    


}