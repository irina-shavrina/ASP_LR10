using System.ComponentModel.DataAnnotations;

public class ConsultationRequest
{
    [Required(ErrorMessage = "Поле імені є обов'язковим")]
    public string FullName { get; set; }

    [Required(ErrorMessage = "Поле Email є обов'язковим")]
    [EmailAddress(ErrorMessage = "Введіть коректний Email")]
    public string Email { get; set; }

    [NotOnWeekend(ErrorMessage = "Консультація не може проходити вихідними")]
    [NotOnMondayIfBasics(ErrorMessage = "Консультація з основ не може бути у понеділок")]
    [Required(ErrorMessage = "Поле дати консультації є обов'язковим")]
    [DateInFuture(ErrorMessage = "Дата має бути у майбутньому")]
    public DateTime ConsultationDate { get; set; }

    [Required(ErrorMessage = "Поле типу консультації є обов'язковим")]
    public string Theme { get; set; }
}