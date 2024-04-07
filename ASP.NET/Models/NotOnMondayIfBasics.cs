using System.ComponentModel.DataAnnotations;

public class NotOnMondayIfBasicsAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var consultationDate = (DateTime)value;
        var model = (ConsultationRequest)validationContext.ObjectInstance;

        if (model.Theme == "Basics" && consultationDate.DayOfWeek == DayOfWeek.Monday)
            return new ValidationResult(ErrorMessage);
        return ValidationResult.Success;
    }
}