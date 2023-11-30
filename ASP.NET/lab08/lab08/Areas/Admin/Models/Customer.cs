using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab08.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="họ và tên")]
        [Required(ErrorMessage = "Họ không được để trống")]
        [MinLength(6, ErrorMessage = "họ tên ít nhất 6 ký tự")]
        [MaxLength(20, ErrorMessage = "họ tên tối đa 20 ký tự")]
        public string FullName { get; set; }

        [Display(Name = "địa chỉ email")]
        [Required(ErrorMessage = "địa chỉ email không được để trống")]
        [EmailAddress(ErrorMessage = "địa chỉ email không đúng định dạng")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "số điện thoại")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "số điện thoại không được để trống")]
        public string  Phone { get; set; }

        [Display(Name = "địa chỉ thường trú")]
        [Required(ErrorMessage = "địa chỉ không được để trống")]
        [StringLength(35, ErrorMessage = "địa chỉ không vượt quá 35 ký tự")]
        public string Address { get; set; }

        [Display(Name = "ảnh đại diện")]
        public string Avatar { get; set; }

        [Display(Name = "ngày sinh")]
        [Required(ErrorMessage = "ngày sinh không được để trống")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Display(Name = "giới tính")]
        public string Gender { get; set; }

        [Display(Name = "mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "link fb cá nhân")]
        [Required(ErrorMessage = "linh fb không được để trống")]
        [Url(ErrorMessage = "url phải đúng định dạng bao gồm http hoặc https, tên miền ")]
        public string FB { get; set; }
    }
}
