using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Personal_mvc.Models
{
    public class Form
    {
        [Required(ErrorMessage = "پر کردن  فیلد اسم اجباری است!")]
        [MinLength(3,ErrorMessage = " طول نام حداقل 3 کراکتر است!")]
        [MaxLength(50,ErrorMessage = "طول نام حداکثر 50 کراکتر است ")]
        public string Name { get; set; }
        [Required(ErrorMessage = "پر کردن  فیلد ایمیل اجباری است!")]
        [EmailAddress(ErrorMessage = "مقدار وارد شده ایمیل معتبر نیست!")]
        public string Email { get; set; }
        public string Subject { get; set; }
        [Required(ErrorMessage = "پر کردن  فیلد متن پیام اجباری است!")]
        [MinLength(8, ErrorMessage = "طول نام حداقل 8 کراکتر است ")]
        public string message { get; set; }
    }
}
