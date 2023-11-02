using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.AspNetCore.Mvc;

namespace lab05.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        
        [
            Display(Name ="Họ và tên"),
            Required(ErrorMessage ="Họ không được để trống"),
            MinLength(6, ErrorMessage ="Họ tên ít nhất 6 ký tự"),
            MaxLength(20, ErrorMessage ="Họ tên tối đa 20 ký tự")
        ]
        public string FullName { get; set; }
       
        [Display(Name = "địa chỉ email")]
        [Required(ErrorMessage ="địa chỉ email không được để trống")]
        [EmailAddress(ErrorMessage ="địa chỉ email không đúng định dạng")]
        public string Email { get; set; }
 
        [Display(Name ="số điện thoại")]
        [DataType(DataType.PhoneNumber)]
        [Remote(action:"VerifyPhone",controller:"Account")]
        [Required(ErrorMessage = "số điện thoại không được để trống")]
        public string Phone { get; set; }
  
        [Display(Name ="địa chỉ thường trú")]
        [Required(ErrorMessage ="địa chỉ không được để trống")]
        [StringLength(35,ErrorMessage ="địa chỉ không vượt quá 35 ký tự")]
        public string Address { get; set; }
    
        [Display(Name ="ảnh đại diện")]          
        public string Avatar { get; set; }
        
        [Display(Name ="Ngày sinh")]
        [Required(ErrorMessage ="ngày sinh không được để trống")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        
        [Display(Name ="giới tính")]
        public string Gender { get; set; }
        
        [Display(Name ="mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [Display(Name ="Linh fb cá nhân")]
        [Required(ErrorMessage ="link fb không được để trống")]
        [Url(ErrorMessage ="url phải đúng định dạng bao gồm http hoặc https, tên miền VD: https://faceboook.com/tieens.hss/")]
        public string Facebook { get; set; }

    }
}
