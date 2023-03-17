using System.ComponentModel.DataAnnotations;

namespace ClassExample.Data.Models
{
    public class Person
    {
        public int PersonId { get; set; }

        [Required]
        public required string FirstName { get; set; }

        [Required]
        public required string LastName { get; set; }

        public int Age { get; set; }

        public string? Address { get; set; }

        public string? City { get; set; }

        public string? Country { get; set; }
    }
}
