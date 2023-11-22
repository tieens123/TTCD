using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab08.Models
{
    [Table("Account")]
    public class Account
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Họ tên")]
        [Required(ErrorMessage = "Họ không được để trống")]
        [MinLength(6, ErrorMessage = "họ tên ít nhất 6 ký tự")]
        [MaxLength(20, ErrorMessage = "họ tên tối đa 20 ký tự")]
        public string  Name { get; set; }

        [Display(Name = "địa chỉ email")]
        [Required(ErrorMessage = "địa chỉ email không được để trống")]
        [EmailAddress(ErrorMessage = "địa chỉ email không đúng định dạng")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "ảnh đại diện")]
        public string Avatar { get; set; }

        [Display(Name = "mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
