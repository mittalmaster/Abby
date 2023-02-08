using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AbbyWeb.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name="Display Order")]//this will alow to display the custom name in the property 
        [Range(1,100,ErrorMessage ="Display Order Value must be between 1 to 100")]
        public int DisplayOrder { get; set; }
    }
}
