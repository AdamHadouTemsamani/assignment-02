namespace Assignment2.Tests;

public class StudentTests
{
    [Fact]
    public void Test_Student_Status()
    {
        //Arrange 
        var studentActive = new Student
        {
            StartDate = new DateTime(2021, 8, 29),
            GraduationDate = new DateTime(2024, 6, 29)
        };
        var studentGraduated = new Student
        {
            StartDate = new DateTime(2019, 9, 1),
            GraduationDate = new DateTime(2022, 6, 25),
            EndDate= new DateTime(2022,6,25)
        };
        var studentNew = new Student
        {
            StartDate = new DateTime(2022, 9, 2),
            GraduationDate = new DateTime(2025, 6, 25)
        };
        var studentDropout = new Student
        {
            StartDate = new DateTime(2021, 8, 31),
            GraduationDate = new DateTime(2024, 6, 18),
            EndDate= new DateTime(2022,4,11)
        };
        
        //Assert
        Assert.Equal(status.Active,studentActive.Status);
        Assert.Equal(status.Dropout,studentDropout.Status);
        Assert.Equal(status.New,studentNew.Status);
        Assert.Equal(status.Graduated,studentGraduated.Status);
    }

    [Fact]
    public void Test_Student_ToString()
    {
       //Arrange
       var student = new Student
       {
           Id = 10, GivenName = "Per", Surname = "Hansen",
           StartDate = new DateTime(2021, 8, 29),
           GraduationDate = new DateTime(2024, 6, 29)
       };
       
       //Assert
       Assert.Equal("Id: 10, Name: Per Hansen, Status: Active",student.ToString());
    }
    
    
    [Fact]
    public void Test_ImmutableStudent_Status()
    {
        //Arrange 
        var studentActive = new ImmutableStudent(1, "ole", "olesen", new DateTime(2021, 8, 29), null,
            new DateTime(2024, 6, 29));
        var studentGraduated = new ImmutableStudent(2, "lise", "lotte", new DateTime(2019, 9, 1),
            new DateTime(2022, 6, 25), new DateTime(2022, 6, 25));
        var studentNew =
            new ImmutableStudent(3, "Ida", "Hansen", new DateTime(2022, 9, 2), null, new DateTime(2025, 6, 25));
        var studentDropout = new ImmutableStudent(4, "Morten", "nielsen", new DateTime(2021, 8, 31),
            new DateTime(2022, 4, 11), new DateTime(2024, 6, 18));
        //Assert
        Assert.Equal(status.Active,studentActive.Status);
        Assert.Equal(status.Dropout,studentDropout.Status);
        Assert.Equal(status.New,studentNew.Status);
        Assert.Equal(status.Graduated,studentGraduated.Status);
        
    }
    
    [Fact]
    public void Test_ImmutableStudent_ToString()
    {
        //Arrange
        var student = new ImmutableStudent(10, "Per", "Hansen", new DateTime(2021, 8, 29), null,
            new DateTime(2024, 6, 29));
        
        //Assert
        Assert.Equal("ImmutableStudent { Id = 10, GivenName = Per, Surname = Hansen, StartDate = 29-08-2021 00:00:00, EndDate = , GraduationDate = 29-06-2024 00:00:00, Status = Active }",student.ToString());
    }
    
    [Fact]
    public void Test_ImmutableStudent_Equality()
    {
        //Arrange
        var student = new ImmutableStudent(11, "Gustav", "Gøjler", new DateTime(2022, 7, 29), null,
            new DateTime(2025, 6, 29));
        var student2 = new ImmutableStudent(11, "Gustav", "Gøjler", new DateTime(2022, 7, 29), null,
            new DateTime(2025, 6, 29));
        
        //Assert
        Assert.Equal(student,student2);
        
    }

}