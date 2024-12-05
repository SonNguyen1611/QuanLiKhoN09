using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoPJ.Model
{
    [Table("EntryBill")]
    public class EntryBill
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EntryBillId { get; set; }
        public DateTime TransactionDate { get; set; }
        public int CountProduct { get; set; }
        public float EntryBillPrice { get; set; }
        // liên kết đến bảng User
        [ForeignKey("UserId")] 
        public  User User { get; set; }

        //Liên kết đến bảng product
        public  List<EntryBillProduct> EntryBillProducts { get; set; }

        


    }
}
