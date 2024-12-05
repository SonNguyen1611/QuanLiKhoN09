using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoPJ.Model
{
    [Table("ExportBillProduct")]
    public class ExportBillProduct
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("ExportBillId")]
        public ExportBill ExportBill { get; set; }


        [ForeignKey("ProductId")]
        public Product Product { get; set; }


        public int QuantityOutLast { get; set; }

    }
}
