using SliderCrud.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SliderCrud.Models
{
    public class Slider : BaseEntity
    {
        [Required(ErrorMessage ="Title required..")]
        [
            StringLength(100,ErrorMessage ="Title maximum contains 100 characters..."),
            MinLength(5,ErrorMessage ="Title minimum contains 5 chracters...")
            ]
        public string Title { get; set; }
        [Required(ErrorMessage ="Descriion required..")]
        [
            StringLength(200,ErrorMessage ="Description maximum contains 200 characters..."),
            MinLength(2,ErrorMessage ="Description min contains 2 characters...")
            ]
        public string Description { get; set; }
        public string? ImageUrl { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
