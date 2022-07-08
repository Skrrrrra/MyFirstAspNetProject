using System.ComponentModel.DataAnnotations;

namespace something.Domain.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase() => DateAdded = DateTime.UtcNow;
        [Required]
        public Guid Id { get; set; }
        
        [Display(Name = "Название")]
        public virtual string Title { get; set; }

        [Display(Name = "Описание(Краткое)")]
        public virtual string Subtitle { get; set; }

        [Display(Name = "Описание(Полное)")]
        public virtual string  Text { get; set; }

        [Display(Name = "Титульная картинка")]
        public virtual string TitleImagePath { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }



    }
}
