using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PetShopWithMSIdentity.Models
{
    public class Dog : Pet
    {
        [Required]
        [Column(TypeName = "varchar(100)")]
        [DataType(DataType.Text)]
        [Display(Name = "Dog Breed")]
        [MinLength(1)]
        public string Breed { get; set; }
    }
}
