namespace THKiemDinh.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=LibraryDbContext")
        {
        }

        public virtual DbSet<ACCOUNT> ACCOUNTs { get; set; }
        public virtual DbSet<LOAISACH> LOAISACHes { get; set; }
        public virtual DbSet<MUONSACH> MUONSACHes { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHIEUMUONSACH> PHIEUMUONSACHes { get; set; }
        public virtual DbSet<SACH> SACHes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<THETHANHVIEN> THETHANHVIENs { get; set; }
        public virtual DbSet<TINHTRANG> TINHTRANGs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.id)
                .IsFixedLength();

            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.id_nv)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOAISACH>()
                .Property(e => e.id_loaisach)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOAISACH>()
                .HasMany(e => e.SACHes)
                .WithOptional(e => e.LOAISACH)
                .HasForeignKey(e => e.id_loai);

            modelBuilder.Entity<MUONSACH>()
                .Property(e => e.id_muonsach)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MUONSACH>()
                .Property(e => e.id_phieumuon)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MUONSACH>()
                .Property(e => e.id_sach)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.id_nv)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.sdt)
                .IsFixedLength();

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.cmnd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUMUONSACH>()
                .Property(e => e.id_phieumuonsach)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUMUONSACH>()
                .Property(e => e.id_the)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUMUONSACH>()
                .Property(e => e.id_nv)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUMUONSACH>()
                .HasMany(e => e.MUONSACHes)
                .WithOptional(e => e.PHIEUMUONSACH)
                .HasForeignKey(e => e.id_phieumuon);

            modelBuilder.Entity<SACH>()
                .Property(e => e.id_sach)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SACH>()
                .Property(e => e.id_tinhtrangsach)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SACH>()
                .Property(e => e.id_loai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THETHANHVIEN>()
                .Property(e => e.id_thethanhvien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THETHANHVIEN>()
                .Property(e => e.sdt)
                .IsFixedLength();

            modelBuilder.Entity<THETHANHVIEN>()
                .Property(e => e.cmnd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THETHANHVIEN>()
                .HasMany(e => e.PHIEUMUONSACHes)
                .WithOptional(e => e.THETHANHVIEN)
                .HasForeignKey(e => e.id_the);

            modelBuilder.Entity<TINHTRANG>()
                .Property(e => e.id_tinhtrang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TINHTRANG>()
                .HasMany(e => e.SACHes)
                .WithOptional(e => e.TINHTRANG)
                .HasForeignKey(e => e.id_tinhtrangsach);
        }
    }
}
