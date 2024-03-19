using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProje.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen adınızı giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyadınızı giriniz")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen mail adresinizi Giriniz")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi Giriniz")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen şifrenizi tekrar Giriniz")]
        [Compare("Password",ErrorMessage ="Şifreler uyumlu değil.")]
        public string ConfirmPassword { get; set; }

    }
}
