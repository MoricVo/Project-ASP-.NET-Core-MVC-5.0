using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Website_DatPhong_TrucTuyen.Models
{
    public partial class csdl_doan_congnghewebContext : DbContext
    {
        public csdl_doan_congnghewebContext()
        {
        }

        public csdl_doan_congnghewebContext(DbContextOptions<csdl_doan_congnghewebContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CartItem> CartItems { get; set; }
        public virtual DbSet<TabBaiviet> TabBaiviets { get; set; }
        public virtual DbSet<TabChude> TabChudes { get; set; }
        public virtual DbSet<TabDanhgium> TabDanhgia { get; set; }
        public virtual DbSet<TabDiadiem> TabDiadiems { get; set; }
        public virtual DbSet<TabDiemdenThamquan> TabDiemdenThamquans { get; set; }
        public virtual DbSet<TabGioithieu> TabGioithieus { get; set; }
        public virtual DbSet<TabHethong> TabHethongs { get; set; }
        public virtual DbSet<TabHomestay> TabHomestays { get; set; }
        public virtual DbSet<TabKhachhang> TabKhachhangs { get; set; }
        public virtual DbSet<TabNguoidung> TabNguoidungs { get; set; }
        public virtual DbSet<TabNoiquy> TabNoiquies { get; set; }
        public virtual DbSet<TabTienichHomstay> TabTienichHomstays { get; set; }
        public virtual DbSet<TabYeuthich> TabYeuthiches { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Database=csdl_doan_congngheweb; Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<CartItem>(entity =>
            {
                entity.HasKey(e => e.IdHomestays);

                entity.ToTable("CartItem");

                entity.Property(e => e.IdHomestays)
                    .ValueGeneratedNever()
                    .HasColumnName("id_homestays");

                entity.Property(e => e.Slphong).HasColumnName("slphong");

                entity.HasOne(d => d.IdHomestaysNavigation)
                    .WithOne(p => p.CartItem)
                    .HasForeignKey<CartItem>(d => d.IdHomestays)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CartItem_tab_homestay");
            });

            modelBuilder.Entity<TabBaiviet>(entity =>
            {
                entity.HasKey(e => e.IdBaiviet);

                entity.ToTable("tab_baiviet");

                entity.Property(e => e.IdBaiviet)
                    .HasMaxLength(50)
                    .HasColumnName("id_baiviet");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(50)
                    .HasColumnName("ghichu");

                entity.Property(e => e.Hinhanh)
                    .HasMaxLength(250)
                    .HasColumnName("hinhanh");

                entity.Property(e => e.IdChude)
                    .HasMaxLength(50)
                    .HasColumnName("id_chude");

                entity.Property(e => e.IdNguoidung).HasColumnName("id_nguoidung");

                entity.Property(e => e.Kiemduyet).HasColumnName("kiemduyet");

                entity.Property(e => e.Luotxem).HasColumnName("luotxem");

                entity.Property(e => e.Ngaydang)
                    .HasColumnType("date")
                    .HasColumnName("ngaydang");

                entity.Property(e => e.Noidung)
                    .HasColumnType("ntext")
                    .HasColumnName("noidung");

                entity.Property(e => e.Tieude)
                    .HasMaxLength(250)
                    .HasColumnName("tieude");

                entity.HasOne(d => d.IdChudeNavigation)
                    .WithMany(p => p.TabBaiviets)
                    .HasForeignKey(d => d.IdChude)
                    .HasConstraintName("FK_tab_baiviet_tab_chude");

                entity.HasOne(d => d.IdNguoidungNavigation)
                    .WithMany(p => p.TabBaiviets)
                    .HasForeignKey(d => d.IdNguoidung)
                    .HasConstraintName("FK_tab_baiviet_tab_nguoidung");
            });

            modelBuilder.Entity<TabChude>(entity =>
            {
                entity.HasKey(e => e.IdChude);

                entity.ToTable("tab_chude");

                entity.Property(e => e.IdChude)
                    .HasMaxLength(50)
                    .HasColumnName("id_chude");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(50)
                    .HasColumnName("ghichu");

                entity.Property(e => e.Ngaydang)
                    .HasColumnType("date")
                    .HasColumnName("ngaydang");

                entity.Property(e => e.Tenchude)
                    .HasMaxLength(50)
                    .HasColumnName("tenchude");
            });

            modelBuilder.Entity<TabDanhgium>(entity =>
            {
                entity.HasKey(e => e.IdDanhgia);

                entity.ToTable("tab_danhgia");

                entity.Property(e => e.IdDanhgia)
                    .HasMaxLength(50)
                    .HasColumnName("id_danhgia");

                entity.Property(e => e.Diem).HasColumnName("diem");

                entity.Property(e => e.IdHomestay).HasColumnName("id_homestay");

                entity.Property(e => e.IdNguoidung).HasColumnName("id_nguoidung");

                entity.Property(e => e.Ngaydang)
                    .HasColumnType("date")
                    .HasColumnName("ngaydang");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(50)
                    .HasColumnName("noidung");

                entity.HasOne(d => d.IdHomestayNavigation)
                    .WithMany(p => p.TabDanhgia)
                    .HasForeignKey(d => d.IdHomestay)
                    .HasConstraintName("FK_tab_danhgia_tab_homestay");

                entity.HasOne(d => d.IdNguoidungNavigation)
                    .WithMany(p => p.TabDanhgia)
                    .HasForeignKey(d => d.IdNguoidung)
                    .HasConstraintName("FK_tab_danhgia_tab_nguoidung");
            });

            modelBuilder.Entity<TabDiadiem>(entity =>
            {
                entity.HasKey(e => e.IdDiadiem);

                entity.ToTable("tab_diadiem");

                entity.Property(e => e.IdDiadiem)
                    .ValueGeneratedNever()
                    .HasColumnName("id_diadiem");

                entity.Property(e => e.Hinhanh)
                    .HasMaxLength(250)
                    .HasColumnName("hinhanh");

                entity.Property(e => e.IdNguoidung).HasColumnName("id_nguoidung");

                entity.Property(e => e.Ngaydang)
                    .HasColumnType("date")
                    .HasColumnName("ngaydang");

                entity.Property(e => e.SlTours).HasColumnName("sl_tours");

                entity.Property(e => e.Tendiadiem)
                    .HasMaxLength(50)
                    .HasColumnName("tendiadiem");

                entity.HasOne(d => d.IdNguoidungNavigation)
                    .WithMany(p => p.TabDiadiems)
                    .HasForeignKey(d => d.IdNguoidung)
                    .HasConstraintName("FK_tab_diadiem_tab_nguoidung");
            });

            modelBuilder.Entity<TabDiemdenThamquan>(entity =>
            {
                entity.HasKey(e => e.IdDiemdenThamquan);

                entity.ToTable("tab_diemden_thamquan");

                entity.Property(e => e.IdDiemdenThamquan).HasColumnName("id_diemden_thamquan");

                entity.Property(e => e.Diachicuthe)
                    .HasMaxLength(250)
                    .HasColumnName("diachicuthe");

                entity.Property(e => e.Giatien).HasColumnName("giatien");

                entity.Property(e => e.Hinhanh)
                    .HasMaxLength(250)
                    .HasColumnName("hinhanh");

                entity.Property(e => e.Hinhphu1)
                    .HasMaxLength(250)
                    .HasColumnName("hinhphu_1");

                entity.Property(e => e.Hinhphu2)
                    .HasMaxLength(250)
                    .HasColumnName("hinhphu_2");

                entity.Property(e => e.Hinhphu3)
                    .HasMaxLength(250)
                    .HasColumnName("hinhphu_3");

                entity.Property(e => e.Hinhphu4)
                    .HasMaxLength(250)
                    .HasColumnName("hinhphu_4");

                entity.Property(e => e.IdDiemden).HasColumnName("id_diemden");

                entity.Property(e => e.IdNguoidung).HasColumnName("id_nguoidung");

                entity.Property(e => e.Ngaycapnhat)
                    .HasColumnType("date")
                    .HasColumnName("ngaycapnhat");

                entity.Property(e => e.Ngaydang)
                    .HasColumnType("date")
                    .HasColumnName("ngaydang");

                entity.Property(e => e.Ngaydatphong)
                    .HasColumnType("date")
                    .HasColumnName("ngaydatphong");

                entity.Property(e => e.Ngaytraphong)
                    .HasColumnType("date")
                    .HasColumnName("ngaytraphong");

                entity.Property(e => e.Noiquy1)
                    .HasMaxLength(250)
                    .HasColumnName("noiquy1");

                entity.Property(e => e.Noiquy2)
                    .HasMaxLength(250)
                    .HasColumnName("noiquy2");

                entity.Property(e => e.Noiquy3)
                    .HasMaxLength(250)
                    .HasColumnName("noiquy3");

                entity.Property(e => e.Noiquy4)
                    .HasMaxLength(250)
                    .HasColumnName("noiquy4");

                entity.Property(e => e.Noiquy5)
                    .HasMaxLength(250)
                    .HasColumnName("noiquy5");

                entity.Property(e => e.Slngayo).HasColumnName("slngayo");

                entity.Property(e => e.Tendiadiemthamquan)
                    .HasMaxLength(50)
                    .HasColumnName("tendiadiemthamquan");

                entity.Property(e => e.Tienich)
                    .HasMaxLength(50)
                    .HasColumnName("tienich");

                entity.Property(e => e.Tienich1)
                    .HasMaxLength(250)
                    .HasColumnName("tienich1");

                entity.Property(e => e.Tienich2)
                    .HasMaxLength(250)
                    .HasColumnName("tienich2");

                entity.Property(e => e.Tienich3)
                    .HasMaxLength(250)
                    .HasColumnName("tienich3");

                entity.Property(e => e.Tienich4)
                    .HasMaxLength(250)
                    .HasColumnName("tienich4");

                entity.HasOne(d => d.IdDiemdenNavigation)
                    .WithMany(p => p.TabDiemdenThamquans)
                    .HasForeignKey(d => d.IdDiemden)
                    .HasConstraintName("FK_tab_diemden_thamquan_tab_diadiem");

                entity.HasOne(d => d.IdNguoidungNavigation)
                    .WithMany(p => p.TabDiemdenThamquans)
                    .HasForeignKey(d => d.IdNguoidung)
                    .HasConstraintName("FK_tab_diemden_thamquan_tab_nguoidung");
            });

            modelBuilder.Entity<TabGioithieu>(entity =>
            {
                entity.HasKey(e => e.IdGioithieu);

                entity.ToTable("tab_gioithieu");

                entity.Property(e => e.IdGioithieu)
                    .HasMaxLength(50)
                    .HasColumnName("id_gioithieu");

                entity.Property(e => e.Hinhanh)
                    .HasMaxLength(250)
                    .HasColumnName("hinhanh");

                entity.Property(e => e.Icon)
                    .HasMaxLength(250)
                    .HasColumnName("icon");

                entity.Property(e => e.IdNguoidung).HasColumnName("id_nguoidung");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(50)
                    .HasColumnName("noidung");

                entity.Property(e => e.Tieude)
                    .HasMaxLength(50)
                    .HasColumnName("tieude");

                entity.HasOne(d => d.IdNguoidungNavigation)
                    .WithMany(p => p.TabGioithieus)
                    .HasForeignKey(d => d.IdNguoidung)
                    .HasConstraintName("FK_tab_gioithieu_tab_nguoidung");
            });

            modelBuilder.Entity<TabHethong>(entity =>
            {
                entity.HasKey(e => e.IdHethong);

                entity.ToTable("tab_hethong");

                entity.Property(e => e.IdHethong)
                    .HasMaxLength(50)
                    .HasColumnName("id_hethong");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(50)
                    .HasColumnName("ghichu");

                entity.Property(e => e.Hinhanh)
                    .HasMaxLength(250)
                    .HasColumnName("hinhanh");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(50)
                    .HasColumnName("noidung");

                entity.Property(e => e.Tieude)
                    .HasMaxLength(50)
                    .HasColumnName("tieude");
            });

            modelBuilder.Entity<TabHomestay>(entity =>
            {
                entity.HasKey(e => e.IdHomstay);

                entity.ToTable("tab_homestay");

                entity.Property(e => e.IdHomstay).HasColumnName("id_homstay");

                entity.Property(e => e.Diachicuthe)
                    .HasMaxLength(255)
                    .HasColumnName("diachicuthe");

                entity.Property(e => e.Giatien).HasColumnName("giatien");

                entity.Property(e => e.Hinh1)
                    .HasMaxLength(250)
                    .HasColumnName("hinh1");

                entity.Property(e => e.Hinh2)
                    .HasMaxLength(250)
                    .HasColumnName("hinh2");

                entity.Property(e => e.Hinh3)
                    .HasMaxLength(250)
                    .HasColumnName("hinh3");

                entity.Property(e => e.Hinh4)
                    .HasMaxLength(250)
                    .HasColumnName("hinh4");

                entity.Property(e => e.Hinhanh)
                    .HasMaxLength(250)
                    .HasColumnName("hinhanh");

                entity.Property(e => e.IdDiadiem).HasColumnName("id_diadiem");

                entity.Property(e => e.IdNguoidung).HasColumnName("id_nguoidung");

                entity.Property(e => e.Ngaydang)
                    .HasColumnType("date")
                    .HasColumnName("ngaydang");

                entity.Property(e => e.Ngayden)
                    .HasColumnType("date")
                    .HasColumnName("ngayden");

                entity.Property(e => e.Ngaydi)
                    .HasColumnType("date")
                    .HasColumnName("ngaydi");

                entity.Property(e => e.Noidung)
                    .HasMaxLength(255)
                    .HasColumnName("noidung");

                entity.Property(e => e.Noiquy)
                    .HasMaxLength(255)
                    .HasColumnName("noiquy");

                entity.Property(e => e.Noiquy1)
                    .HasMaxLength(250)
                    .HasColumnName("noiquy1");

                entity.Property(e => e.Noiquy2)
                    .HasMaxLength(250)
                    .HasColumnName("noiquy2");

                entity.Property(e => e.Noiquy3)
                    .HasMaxLength(250)
                    .HasColumnName("noiquy3");

                entity.Property(e => e.Noiquy4)
                    .HasMaxLength(250)
                    .HasColumnName("noiquy4");

                entity.Property(e => e.Noiquy5)
                    .HasMaxLength(250)
                    .HasColumnName("noiquy5");

                entity.Property(e => e.Slngayo).HasColumnName("slngayo");

                entity.Property(e => e.Tenhomestay)
                    .HasMaxLength(50)
                    .HasColumnName("tenhomestay");

                entity.Property(e => e.Tienich1)
                    .HasMaxLength(250)
                    .HasColumnName("tienich1");

                entity.Property(e => e.Tienich2)
                    .HasMaxLength(250)
                    .HasColumnName("tienich2");

                entity.Property(e => e.Tienich3)
                    .HasMaxLength(250)
                    .HasColumnName("tienich3");

                entity.Property(e => e.Tienich4)
                    .HasMaxLength(250)
                    .HasColumnName("tienich4");

                entity.Property(e => e.Tienich5)
                    .HasMaxLength(250)
                    .HasColumnName("tienich5");

                entity.Property(e => e.Tieude)
                    .HasMaxLength(255)
                    .HasColumnName("tieude");

                entity.HasOne(d => d.IdDiadiemNavigation)
                    .WithMany(p => p.TabHomestays)
                    .HasForeignKey(d => d.IdDiadiem)
                    .HasConstraintName("FK_tab_homestay_tab_diadiem");

                entity.HasOne(d => d.IdNguoidungNavigation)
                    .WithMany(p => p.TabHomestays)
                    .HasForeignKey(d => d.IdNguoidung)
                    .HasConstraintName("FK_tab_homestay_tab_nguoidung");
            });

            modelBuilder.Entity<TabKhachhang>(entity =>
            {
                entity.HasKey(e => e.IdKhachhang);

                entity.ToTable("tab_khachhang");

                entity.Property(e => e.IdKhachhang).HasColumnName("id_khachhang");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(50)
                    .HasColumnName("diachi");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(50)
                    .HasColumnName("ghichu");

                entity.Property(e => e.Sdt).HasColumnName("sdt");

                entity.Property(e => e.Slnguoio).HasColumnName("slnguoio");

                entity.Property(e => e.Tenkhachhang)
                    .HasMaxLength(50)
                    .HasColumnName("tenkhachhang");
            });

            modelBuilder.Entity<TabNguoidung>(entity =>
            {
                entity.HasKey(e => e.IdNguoidung);

                entity.ToTable("tab_nguoidung");

                entity.Property(e => e.IdNguoidung).HasColumnName("id_nguoidung");

                entity.Property(e => e.Anhdaidien)
                    .HasMaxLength(250)
                    .HasColumnName("anhdaidien");

                entity.Property(e => e.Cmnd).HasColumnName("cmnd");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(50)
                    .HasColumnName("diachi");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.Kichhoat).HasColumnName("kichhoat");

                entity.Property(e => e.Loainguoidung)
                    .HasMaxLength(50)
                    .HasColumnName("loainguoidung");

                entity.Property(e => e.Matkhau)
                    .HasMaxLength(50)
                    .HasColumnName("matkhau");

                entity.Property(e => e.Ngaylap)
                    .HasColumnType("date")
                    .HasColumnName("ngaylap");

                entity.Property(e => e.Ngaysinh)
                    .HasColumnType("date")
                    .HasColumnName("ngaysinh");

                entity.Property(e => e.Salt).HasMaxLength(50);

                entity.Property(e => e.Sdt)
                    .HasMaxLength(50)
                    .HasColumnName("sdt");

                entity.Property(e => e.Taikhoan)
                    .HasMaxLength(50)
                    .HasColumnName("taikhoan");

                entity.Property(e => e.Tennguoidung)
                    .HasMaxLength(50)
                    .HasColumnName("tennguoidung");
            });

            modelBuilder.Entity<TabNoiquy>(entity =>
            {
                entity.HasKey(e => e.IdNoiquy);

                entity.ToTable("tab_noiquy");

                entity.Property(e => e.IdNoiquy)
                    .HasMaxLength(50)
                    .HasColumnName("id_noiquy");

                entity.Property(e => e.Noiquy1)
                    .HasMaxLength(50)
                    .HasColumnName("noiquy_1");

                entity.Property(e => e.Noiquy11)
                    .HasMaxLength(50)
                    .HasColumnName("noiquy_11");

                entity.Property(e => e.Noiquy2)
                    .HasMaxLength(50)
                    .HasColumnName("noiquy_2");

                entity.Property(e => e.Noiquy3)
                    .HasMaxLength(50)
                    .HasColumnName("noiquy_3");

                entity.Property(e => e.Noiquy4)
                    .HasMaxLength(50)
                    .HasColumnName("noiquy_4");

                entity.Property(e => e.Noiquy5)
                    .HasMaxLength(50)
                    .HasColumnName("noiquy_5");

                entity.Property(e => e.Noiquy6)
                    .HasMaxLength(50)
                    .HasColumnName("noiquy_6");

                entity.Property(e => e.Noiquy7)
                    .HasMaxLength(50)
                    .HasColumnName("noiquy_7");

                entity.Property(e => e.Noiquy9)
                    .HasMaxLength(50)
                    .HasColumnName("noiquy_9");
            });

            modelBuilder.Entity<TabTienichHomstay>(entity =>
            {
                entity.HasKey(e => e.IdTienich);

                entity.ToTable("tab_tienich_homstay");

                entity.Property(e => e.IdTienich)
                    .HasMaxLength(50)
                    .HasColumnName("id_tienich");

                entity.Property(e => e.Giatien).HasColumnName("giatien");

                entity.Property(e => e.Icon)
                    .HasMaxLength(250)
                    .HasColumnName("icon");

                entity.Property(e => e.Tentienich)
                    .HasMaxLength(50)
                    .HasColumnName("tentienich");
            });

            modelBuilder.Entity<TabYeuthich>(entity =>
            {
                entity.HasKey(e => e.IdYeuthich);

                entity.ToTable("tab_yeuthich");

                entity.Property(e => e.IdYeuthich)
                    .HasMaxLength(50)
                    .HasColumnName("id_yeuthich");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(50)
                    .HasColumnName("ghichu");

                entity.Property(e => e.IdHomestay)
                    .HasMaxLength(50)
                    .HasColumnName("id_homestay");

                entity.Property(e => e.IdNguoidung).HasColumnName("id_nguoidung");

                entity.HasOne(d => d.IdNguoidungNavigation)
                    .WithMany(p => p.TabYeuthiches)
                    .HasForeignKey(d => d.IdNguoidung)
                    .HasConstraintName("FK_tab_yeuthich_tab_nguoidung");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
