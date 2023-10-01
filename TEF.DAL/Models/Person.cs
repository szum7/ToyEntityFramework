using System.ComponentModel.DataAnnotations;

namespace TEF.DAL.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{Id}-{FirstName}-{LastName}";
        }
    }
}
