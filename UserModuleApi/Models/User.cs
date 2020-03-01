using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UserModuleApi.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [EmailAddress]
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Info { get; set; }
        public int? BirthDate { get; set; }
        public bool IsActive { get; set; }

    }
}