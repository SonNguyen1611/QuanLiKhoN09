using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoPJ.Model
{
    [Table("ExportBill")]
    public class ExportBill
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExportBillId { get; set; }
        public DateTime TransactionDate { get; set; }
        public int CountProduct { get; set; }
        public decimal ExportBillPrice { get; set; }

        // liên kết đến bảng User
        [ForeignKey("UserId")]
        public  User User { get; set; }
       
        public  List<ExportBillProduct> ExportBillProducts { get; set; } 


    }
}
