using System.ComponentModel.DataAnnotations;

namespace something.Domain.Entities
{
    public class ServiceItem:EntityBase
    {
        [Required(ErrorMessage = "Заполните название услуги")]

        [Display(Name = "Название услуги")]
        public virtual string Title { get; set; }

        [Display(Name = "Краткое описание услуги")]
        public virtual string Subtitle { get; set; }

        [Display(Name = "Полное описание услуги")]
        public virtual string Text { get; set; }
    }
}
