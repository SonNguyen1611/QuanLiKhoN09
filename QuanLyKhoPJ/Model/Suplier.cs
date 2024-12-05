using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoPJ.Model
{
    [Table("Suplier")]
    public class Suplier 

    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SuplierId {  get; set; } 
        [Required]
        public string SuplierName { get; set; }
        public string SuplierAddress { get; set; }
        [Required]
        public int SuplierPhoneNumber { get; set; }
        public string SuplierEmail { get; set; }

        public  List<Product> Products { get; set; }

        




    }
}
