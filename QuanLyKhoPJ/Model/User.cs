using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoPJ.Model
{
    
    [Table("User")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        [Required]
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public int age { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public string sex { get; set; }
        public string image { get; set; }

        [ForeignKey("RoleID")]
        public  Role Role { get; set; }

        public  List<EntryBill> EntryBills { get; set; }
        public  List<ExportBill> ExportBills { get; set; }


    }
}
