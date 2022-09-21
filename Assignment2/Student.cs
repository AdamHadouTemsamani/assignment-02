namespace Assignment2;

public class Student
{
    public int  Id { get; init; }
    public string  GivenName { get; set; }
    public string  Surname { get; set; }
    public status Status
    {
        get
        {
            if ((DateTime.Now.Year - StartDate.Year) * 12 + DateTime.Now.Month - StartDate.Month<5 && EndDate==null) return status.New;
            if (EndDate != null)
            {
                return EndDate == GraduationDate ? status.Graduated : status.Dropout;
            }
            return status.Active;
        }
    } 
    public DateTime  StartDate { get; set; }
    public DateTime?  EndDate { get; set; }
    public DateTime  GraduationDate { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {GivenName} {Surname}, Status: {Status}";
    }
}

public record ImmutableStudent(int Id, string GivenName, string Surname, DateTime StartDate, DateTime? EndDate, DateTime GraduationDate)
{
    public status Status
    {
        get
        {
            if ((DateTime.Now.Year - StartDate.Year) * 12 + DateTime.Now.Month - StartDate.Month < 5 && EndDate == null)
                return status.New;
            if (EndDate != null)
            {
                return EndDate == GraduationDate ? status.Graduated : status.Dropout;
            }

            return status.Active;
        }
    }
}




public enum status{ New, Active, Dropout, Graduated }