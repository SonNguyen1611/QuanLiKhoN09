using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoPJ.Model
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public string ProductId { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductName { get; set; } 
        [Required]
        public string ProductDescription { get; set; }
        public int Quantity { get; set; }     
        // biến tạm hiển thị dữ liệu về số lượng sản phẩm được thêm mỗi entryBill
        public int? QuantityAddInBill { get; set; }
        public decimal EnTryPrice { get; set; }
        public decimal ExportPrice { get; set; }
        public decimal Profit { get; set; }
        public DateTime UpdateDay { get; set; }
        public string image { get; set; }
      


        // trường tham chiếu mối quan hệ 1 nhiều với bảng category
        [ForeignKey("CateId")]
        public  Category? Category { get; set; }


        [ForeignKey("SuplierId")]
        public  Suplier? Suplier { get; set; }
        // liên kết bảng EnrtyBillProduct
        public List<EntryBillProduct> EntryBillProducts { get; set; }

        // thiết lập mối quan hệ nhiêu nhiều với ExportBill
        public  List<ExportBillProduct> ExportBillProducts { get; set; }


        public Product()
        {
           
            UpdateDay = DateTime.Now;
        }


    }
}
