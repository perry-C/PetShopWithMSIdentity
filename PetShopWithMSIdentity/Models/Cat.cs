using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PetShopWithMSIdentity.Models
{
    public class Cat : Pet
    {

        [Column(TypeName = "varchar(100)")]
        [DataType(DataType.Text)]
        [Display(Name = "Cat Breed")]
        [MinLength(1)]
        public string Breed { get; set; }
    }
}
