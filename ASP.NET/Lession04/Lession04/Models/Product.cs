using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
//using System.Text.RegularExpressions;
//using RequiredAttibute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace Lession04.Models
{
    public class Product
    {
        [Required(ErrorMessage = "Bạn phải nhập tên Id.")]
        public int Id { get; set; }

        [DisplayName("Tên")]
        [Required(ErrorMessage ="Bạn phải nhập tên sản phẩm")]
        [StringLength(150,MinimumLength =6,ErrorMessage ="Tên sản phẩm phải có ít nhất 6 và không quá 150  ký tự")]
        public string? Name { get; set; }
            
        [DisplayName("Mô tả")]
        [Required(ErrorMessage ="Bạn phải mô tả")]
        [StringLength(1500, ErrorMessage = "Mô tả không quá 1500 ký tự")]
        [RegularExpression(@"^(?!.*\b(die|admin|fuck|shit|cunt)\b).*$", ErrorMessage ="Mô tả không chứa các từ nhạy cảm.")]
        public string Description { get; set; }
  
        [DisplayName("Giá")]
        [Required(ErrorMessage = "Bạn phải nhập giá sản phẩm")]
        [Range(100000,double.MaxValue,ErrorMessage ="giá sản phẩm phải lớn hơn hoặc bằng 100.000")]
        [DataType(DataType.Currency)]
        public float? Price { get; set; }
        [Display(Name ="giảm giá")]     
        
        [Required(ErrorMessage = "Bạn phải nhập giá khuyến mãi")]
        [Range(0, 0.1, ErrorMessage = "giá khuyến mãi không âm và nhỏ hơn 10% giá chuẩn")]
        public float? SalePrice { get; set; }

        [DisplayName("Hình ảnh")]
        [Required(ErrorMessage = "Bạn phải chọn hình ảnh")]
        public string? Image { get; set; }

        [DisplayName("CategoryId")]
        [Required(ErrorMessage = "Bạn phải chọn một danh mục")]
        [Range(1, int.MaxValue,ErrorMessage = "CategoryId không hợp lệ")]
        public int CategoryId { get; set; }
   
        [Required(ErrorMessage = "Bạn phải nhập ngày tháng")]
        public DateTime CreateDate { get; set; }

        public string? CreateBy { get; set; }


        [Required(ErrorMessage = "Bạn phải nhập trạng thái")]
        public bool? Status { get; set; }
        
        //tạo quan hệ ràng buộc với Category
        public virtual Category? Category { get; set; }

    }
}
