using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoPJ.Model
{
    [Table("EntryBillProduct")]
    public class EntryBillProduct
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("EntryBillId")]
        public EntryBill EntryBill { get; set; }


        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public int QuantityAddLast { get; set; }

    }
}
