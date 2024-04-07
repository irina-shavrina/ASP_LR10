using System.ComponentModel.DataAnnotations;

public class DateInFutureAttribute : ValidationAttribute
{
    public override bool IsValid(object value)
    {
        DateTime date = (DateTime)value;
        return date >= DateTime.Now;
    }
}