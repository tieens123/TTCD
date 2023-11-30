using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab08.Models
{
    [Table("Order")]
    public class Orders
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }

        [Display(Name = "họ tên người nhận")]
        public string Name { get; set; }

        [Display(Name = "địa chỉ người nhận")]
        public string Address { get; set; }

        [Display(Name = "ngày đặt")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "trạng thái")]
        public byte Status { get; set; }
        //khóa ngoại tới bảng Customer
        public Customer Customer { get; set; }
    }
}
