namespace Assignment2.Tests;

public class ExtensionsTests
{
    [Fact]
    public void Flatten_oneliner_Test()
    {
        //Arrange
        IEnumerable<int>[] xs = { new[] { 0, 1, 2 }, new[] { 3, 4, 5 }, new[] { 6, 7, 8 } };
        
        //act
        IEnumerable<int> singleArray = xs.SelectMany(i=>i);
        
        //Assert
        Assert.Equal(singleArray,new []{0,1,2,3,4,5,6,7,8});
    }
    
    [Fact]
    public void Divisible_by_7_greater_than_42_oneliner_Test()
    {
        //Arrange
        int[] ys = { 1600,2016, 1233, 1500};
        
        //act
        IEnumerable<int> isLeapYears = ys.Where(x =>DateTime.IsLeapYear(x));
        
        //Assert
        Assert.Equal(new []{1600,2016},isLeapYears);
    }

    [Fact]
    public void Test_IsSecure_Extension()
    {
        //Arrange
        var uri1 = new Uri("https://learnit.itu.dk/my/");
        var uri2 = new Uri("http://www.babytree.com/baby202208_index/");
        
        //Assert
        Assert.True(uri1.IsSecure());
        Assert.False(uri2.IsSecure());
    }
    
    [Fact]
    public void Test_WordCount_Extension()
    {
        //Arrange
        var string1 = "Hej med dig";
        var string2 = "I, love it. Do you?";
        var string3 = "Are you 20 years old?";
        
        //Assert
        Assert.Equal(3,string1.WordCount());
        Assert.Equal(5,string2.WordCount());
        Assert.Equal(4,string3.WordCount());
    }
   
}
