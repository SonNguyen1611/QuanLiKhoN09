using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace QuanLyKhoPJ.Model
{
    public class QuanLiKhoDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Suplier> Supliers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
       
        public DbSet<EntryBill> EntryBills { get; set; }
        public DbSet<ExportBill> ExportBills { get; set; }

        public DbSet<EntryBillProduct> EntryBillProducts { get; set; }
        public DbSet<ExportBillProduct> ExportBillProducts { get; set; }



        /// <summary>
        /// sửa chỗ này
        /// </summary>
        private const string connectString = "Data Source=localhost;Initial Catalog=QuanLiKho;User ID=sa;Password=son16112003;TrustServerCertificate=True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(connectString);
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Thiết lập quan hệ giữa Product giũa các bảng khi bảng cha bị xóa các bảng con có thuộc tính ràng buộc sẽ được set về null

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Suplier)
                .WithMany(e => e.Products)
                .HasForeignKey("SuplierId")
                .OnDelete(DeleteBehavior.NoAction);


            

        }
    }
}
