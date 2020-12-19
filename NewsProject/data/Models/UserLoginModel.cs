using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewsProject.data.Models
{
    public class UserLoginModel
    {
        [Required(ErrorMessage ="Kullanıcı adını yazınız")]
        [StringLength(500, ErrorMessage = "Username çok kısa", MinimumLength = 3)]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Kullanıcı şifresini yazınız")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
