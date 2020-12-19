using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewsProject.data.Models
{
    public class UserRegisterModel
    {
        [Required(ErrorMessage = "Username ve Password boş bırakılamaz")]
        [StringLength(500, ErrorMessage = "Username çok kısa", MinimumLength = 3)]
        public string userName { get; set; }
        [Required(ErrorMessage = "Username ve Password boş bırakılamaz")]
        public string Password { get; set; }

    }
}
