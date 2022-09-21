namespace Assignment2;

public class Queries
{
    public static IEnumerable<string> WizardsByRowlingExtensions() =>
        WizardCollection.Create().Where(x => x.Creator == "Rowling").Select(x => x.Name);

    public static IEnumerable<string> WizardsByRowlingLinQ()
    {
        return from Wizard w in WizardCollection.Create()
            where w.Creator == "Rowling"
            select w.Name;
    }
    
    public static int? YearOfFirstSithLordExtensions() =>
        WizardCollection.Create().Where(x =>x.Name.StartsWith("Darth")).OrderBy(x=>x.Year).First().Year;

    public static int? YearOfFirstSithLordLinQ()
    {
        return (from Wizard w in WizardCollection.Create()
                where w.Name.StartsWith("Darth")
                orderby w.Year
                select w.Year).First();
    }
    
    public static IEnumerable<(string,int?)> HarryPotterWizardsExtensions() =>
        WizardCollection.Create().Where(x => x.Medium.StartsWith("Harry Potter")).Select(x => (x.Name,x.Year)).Distinct();

    public static IEnumerable<(string,int?)> HarryPotterWizardsLinQ()
    {
        return (from Wizard w in WizardCollection.Create()
            where w.Medium.StartsWith("Harry Potter")
            select (w.Name, w.Year)).Distinct();
    }
    
    public static IEnumerable<string> WizardsByCreatorExtensions() =>
        WizardCollection.Create().OrderByDescending(x=>x.Creator).ThenBy(x=>x.Name).Select(x=>x.Name);

    public static IEnumerable<string> WizardsByCreatorLinQ()
    {
        return from Wizard w in WizardCollection.Create()
            orderby w.Creator descending, w.Name 
            select w.Name;
    }



}
