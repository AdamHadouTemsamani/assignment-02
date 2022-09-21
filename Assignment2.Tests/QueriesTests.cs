namespace Assignment2.Tests;

public class QueriesTests
{
    
    [Fact]
    public void Test_Wizards_By_Rowling()
    {
        //Arrange
        var expectedWizards = new[] { "Harry Potter", "Voldemort", "Dumbledore" };
        var wizardsExtensions = Queries.WizardsByRowlingExtensions();
        var wizardsLinQ = Queries.WizardsByRowlingLinQ();
        
        Assert.Equal(expectedWizards,wizardsExtensions);
        Assert.Equal(expectedWizards,wizardsLinQ);
    }
    
    [Fact]
    public void Test_Year_Of_First_Sith_Lord()
    {
        //Arrange
        var yearExtensions = Queries.YearOfFirstSithLordExtensions();
        var yearLinQ = Queries.YearOfFirstSithLordLinQ();
        
        Assert.Equal(1977,yearExtensions);
        Assert.Equal(1977,yearLinQ);
    }
    
    [Fact]
    public void Test_Harry_Potter_Wizards_By_Rowling()
    {
        //Arrange
        IEnumerable<(string,int?)> expectedWizards = new (string,int?)[] { ("Harry Potter",1997), ("Voldemort",1997), ("Dumbledore",1997) };
        var wizardsExtensions = Queries.HarryPotterWizardsExtensions();
        var wizardsLinQ = Queries.HarryPotterWizardsLinQ();
        
        Assert.Equal(expectedWizards,wizardsExtensions);
        Assert.Equal(expectedWizards,wizardsLinQ);
    }
    
    [Fact]
    public void Test_Wizards_By_Creator()
    {
        //Arrange
        var expectedWizards = new [] { "Dr. Strange", "Dumbledore", "Harry Potter","Voldemort", "Merlin", "Jafar","Yen Sid", "Gandalf", "Sauroman", "Sauron","Darth Sidious", "Darth Vader", "Obi Wan Kenobi"};
        var wizardsExtensions = Queries.WizardsByCreatorExtensions();
        var wizardsLinQ = Queries.WizardsByCreatorLinQ();
        
        Assert.Equal(expectedWizards,wizardsExtensions);
        Assert.Equal(expectedWizards,wizardsLinQ);
    }
}
