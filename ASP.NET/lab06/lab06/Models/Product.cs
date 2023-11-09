using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel;

namespace lab06.Models
{
    [Table("Product")]

    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Tên sản phẩm không được để trống ")]
        [StringLength(150,ErrorMessage = "tên sản phẩm giớ hạn 150 ký tự")]
        [Column(TypeName = "nvarchar(150)")]
        public string Name { get; set; }


        [Column(TypeName = "nvarchar(150)")]
        public string Image { get; set; }

        [Required(ErrorMessage = "giá sản phẩm không được để trống")]
        public float Price { get; set; }

        public float SalePrice { get; set; }
        public byte Status { get; set; }

        [StringLength(1000, ErrorMessage = "nội dung giới hạn 1000 ký tự")]
        [Column(TypeName = "ntext")]
        public string Descriptions { get; set; }

        [Required(ErrorMessage = "danh mục sản phẩm không được để trống")]
        public string CategoryId { get; set; }
        public DateTime CreateFate { get; set; }

        //khóa ngoại tới bảng Category
        public Category Category { get; set; }
    }
}
