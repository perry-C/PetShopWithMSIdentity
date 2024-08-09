using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopWithMSIdentity.Models
{
    public class Pet
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [Display(Name = "Pet Name")]
        [Column(TypeName = "varchar(100)")]
        [StringLength(100)]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Specie")]
        [Column(TypeName = "varchar(100)")]
        [StringLength(100)]
        [DataType(DataType.Text)]
        public string Specie { get; set; }


        [Required]
        [Display(Name = "Description")]
        [Column(TypeName = "varchar(100)")]
        [StringLength(100)]
        [DataType(DataType.Text)]
        public string Description { get; set; }


        [Required]
        [Display(Name = "Date Of Birth")]
        [Column(TypeName = "varchar(100)")]
        [StringLength(100)]
        [DataType(DataType.Text)]
        public DateTime DOB { set; get; }


        [Required]
        [Display(Name = "Sound Type")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public string SoundType { set; get; }

        [Required]
        [Display(Name = "Sound")]
        [Column(TypeName = "varchar(100)")]
        [StringLength(100)]
        [DataType(DataType.Text)]
        public string Sound { set; get; }

        public int Age
        {
            get
            {
                DateTime now = new DateTime();
                int age = now.Year - DOB.Year;

                // If the pet's birthday hasn't yet come, minus 1 to age 
                if (DOB.AddYears(age) > now)
                {
                    age--;
                }
                return age;
            }
        }

        public string MakeSound()
        {
            return Sound;
        }

        public virtual string MakeSoundType()
        {
            return SoundType;
        }
    }
}
