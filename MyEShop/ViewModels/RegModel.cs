using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyEShop.Models
{
    public class RegModel
    {
        [Key]
        public Guid ID_User { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [MaxLength(15, ErrorMessage = "Максимальная длина пароля, 15 символов")]
        [MinLength(6, ErrorMessage = "Минимальная длина пароля, 6 символов.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
