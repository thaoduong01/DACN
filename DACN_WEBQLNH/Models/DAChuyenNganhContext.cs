using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DACN_WEBQLNH.Models
{
    public partial class DAChuyenNganhContext : DbContext
    {
        public DAChuyenNganhContext()
        {
        }

        public DAChuyenNganhContext(DbContextOptions<DAChuyenNganhContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BienLaiThuLai> BienLaiThuLais { get; set; } = null!;
        public virtual DbSet<ChucVu> ChucVus { get; set; } = null!;
        public virtual DbSet<CongTyThamDinh> CongTyThamDinhs { get; set; } = null!;
        public virtual DbSet<CtbienLaiThuLai> CtbienLaiThuLais { get; set; } = null!;
        public virtual DbSet<DoanhNghiep> DoanhNghieps { get; set; } = null!;
        public virtual DbSet<HoSoBaoCaoTc> HoSoBaoCaoTcs { get; set; } = null!;
        public virtual DbSet<HoSoPhapLy> HoSoPhapLies { get; set; } = null!;
        public virtual DbSet<HoSoPhuongAnVay> HoSoPhuongAnVays { get; set; } = null!;
        public virtual DbSet<HoSoTaiSanDb> HoSoTaiSanDbs { get; set; } = null!;
        public virtual DbSet<HoSoThamDinh> HoSoThamDinhs { get; set; } = null!;
        public virtual DbSet<HoSoTinDung> HoSoTinDungs { get; set; } = null!;
        public virtual DbSet<HoSoVayDoanhNghiep> HoSoVayDoanhNghieps { get; set; } = null!;
        public virtual DbSet<KhachHang> KhachHangs { get; set; } = null!;
        public virtual DbSet<KhachHangCaNhan> KhachHangCaNhans { get; set; } = null!;
        public virtual DbSet<LoaiHoSoTsdb> LoaiHoSoTsdbs { get; set; } = null!;
        public virtual DbSet<NhanVien> NhanViens { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; } = null!;
        public virtual DbSet<TheTinDung> TheTinDungs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=THAODUONG\\LOCAL;Database=DAChuyenNganh;User Id=sa;password=123;Trusted_Connection=False;MultipleActiveResultSets=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BienLaiThuLai>(entity =>
            {
                entity.HasKey(e => e.IdBienLai)
                    .HasName("PK__BienLaiT__A6C6A9ABDB00FF94");

                entity.ToTable("BienLaiThuLai");

                entity.Property(e => e.IdBienLai).ValueGeneratedNever();

                entity.Property(e => e.IdHsvay)
                    .HasMaxLength(10)
                    .HasColumnName("IdHSVay")
                    .IsFixedLength();

                entity.Property(e => e.IdNhanVien)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.NgayNhanLai).HasColumnType("datetime");

                entity.HasOne(d => d.IdHsvayNavigation)
                    .WithMany(p => p.BienLaiThuLais)
                    .HasForeignKey(d => d.IdHsvay)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BienLaiTh__IdHSV__5441852A");

                entity.HasOne(d => d.IdNhanVienNavigation)
                    .WithMany(p => p.BienLaiThuLais)
                    .HasForeignKey(d => d.IdNhanVien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BienLaiTh__IdNha__48CFD27E");
            });

            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.HasKey(e => e.IdChucVu)
                    .HasName("PK__ChucVu__81D916DFDB4C8363");

                entity.ToTable("ChucVu");

                entity.Property(e => e.IdChucVu)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.TenChucVu).HasMaxLength(100);
            });

            modelBuilder.Entity<CongTyThamDinh>(entity =>
            {
                entity.HasKey(e => e.IdCongTy)
                    .HasName("PK__CongTyTh__7FB1391AB3FF3791");

                entity.ToTable("CongTyThamDinh");

                entity.Property(e => e.IdCongTy)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DiaChi).HasMaxLength(100);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Sdt)
                    .HasMaxLength(10)
                    .HasColumnName("SDT")
                    .IsFixedLength();

                entity.Property(e => e.TenCty).HasMaxLength(100);
            });

            modelBuilder.Entity<CtbienLaiThuLai>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CTBienLaiThuLai");
            });

            modelBuilder.Entity<DoanhNghiep>(entity =>
            {
                entity.HasKey(e => e.IdKhachHang)
                    .HasName("PK__DoanhNgh__7CF5D836A50EF7A1");

                entity.ToTable("DoanhNghiep");

                entity.Property(e => e.IdKhachHang)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.CmndCccd)
                    .HasMaxLength(12)
                    .HasColumnName("CMND_CCCD");

                entity.Property(e => e.DiaChi).HasMaxLength(100);

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Sdt)
                    .HasMaxLength(10)
                    .HasColumnName("SDT")
                    .IsFixedLength();

                entity.Property(e => e.TenDoanhNghiep).HasMaxLength(100);

                entity.Property(e => e.TenNguoiDaiDien).HasMaxLength(50);

                entity.HasOne(d => d.IdKhachHangNavigation)
                    .WithOne(p => p.DoanhNghiep)
                    .HasForeignKey<DoanhNghiep>(d => d.IdKhachHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DoanhNghi__IdKha__4CA06362");
            });

            modelBuilder.Entity<HoSoBaoCaoTc>(entity =>
            {
                entity.HasKey(e => e.IdBctc)
                    .HasName("PK__HoSoBaoC__38AB7D3A73C75EE6");

                entity.ToTable("HoSoBaoCaoTC");

                entity.Property(e => e.IdBctc)
                    .HasMaxLength(10)
                    .HasColumnName("IdBCTC")
                    .IsFixedLength();

                entity.Property(e => e.BctaiChinh)
                    .HasMaxLength(100)
                    .HasColumnName("BCTaiChinh")
                    .IsFixedLength();

                entity.Property(e => e.HopDongMuaBan)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.HopDongSdld)
                    .HasMaxLength(100)
                    .HasColumnName("HopDongSDLD")
                    .IsFixedLength();

                entity.Property(e => e.IdHsvay)
                    .HasMaxLength(10)
                    .HasColumnName("IdHSVay")
                    .IsFixedLength();

                entity.Property(e => e.NgayNhanHs)
                    .HasColumnType("datetime")
                    .HasColumnName("NgayNhanHS");

                entity.Property(e => e.SaoKeTknh)
                    .HasMaxLength(100)
                    .HasColumnName("SaoKeTKNH")
                    .IsFixedLength();

                entity.Property(e => e.ToVat)
                    .HasMaxLength(100)
                    .HasColumnName("ToVAT")
                    .IsFixedLength();

                entity.HasOne(d => d.IdHsvayNavigation)
                    .WithMany(p => p.HoSoBaoCaoTcs)
                    .HasForeignKey(d => d.IdHsvay)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoSoBaoCa__IdHSV__52593CB8");
            });

            modelBuilder.Entity<HoSoPhapLy>(entity =>
            {
                entity.HasKey(e => e.IdPhapLy)
                    .HasName("PK__HoSoPhap__6727369E07295E35");

                entity.ToTable("HoSoPhapLy");

                entity.Property(e => e.IdPhapLy)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.BbhopHd)
                    .HasMaxLength(100)
                    .HasColumnName("BBHopHD")
                    .IsFixedLength();

                entity.Property(e => e.CmndCccdKtt)
                    .HasMaxLength(10)
                    .HasColumnName("CMND_CCCD_KTT")
                    .IsFixedLength();

                entity.Property(e => e.DieuLeCty)
                    .HasMaxLength(100)
                    .HasColumnName("DieuLeCTy")
                    .IsFixedLength();

                entity.Property(e => e.Gcndkthue)
                    .HasMaxLength(100)
                    .HasColumnName("GCNDKThue")
                    .IsFixedLength();

                entity.Property(e => e.Gdkkd)
                    .HasMaxLength(100)
                    .HasColumnName("GDKKD")
                    .IsFixedLength();

                entity.Property(e => e.IdHsvay)
                    .HasMaxLength(10)
                    .HasColumnName("IdHSVay")
                    .IsFixedLength();

                entity.Property(e => e.NgayNhanHs)
                    .HasColumnType("datetime")
                    .HasColumnName("NgayNhanHS");

                entity.Property(e => e.TenKttruong)
                    .HasMaxLength(30)
                    .HasColumnName("TenKTTruong");

                entity.HasOne(d => d.IdHsvayNavigation)
                    .WithMany(p => p.HoSoPhapLies)
                    .HasForeignKey(d => d.IdHsvay)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoSoPhapL__IdHSV__5165187F");
            });

            modelBuilder.Entity<HoSoPhuongAnVay>(entity =>
            {
                entity.HasKey(e => e.IdHspavay)
                    .HasName("PK__HoSoPhuo__B8DB0DCFF1487D24");

                entity.ToTable("HoSoPhuongAnVay");

                entity.Property(e => e.IdHspavay)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IdHSPAVay")
                    .IsFixedLength();

                entity.Property(e => e.KeHoachTraNo)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.NgayNhanHs)
                    .HasColumnType("datetime")
                    .HasColumnName("NgayNhanHS");

                entity.Property(e => e.PhuongAnKd)
                    .HasMaxLength(100)
                    .HasColumnName("PhuongAnKD")
                    .IsFixedLength();
            });

            modelBuilder.Entity<HoSoTaiSanDb>(entity =>
            {
                entity.HasKey(e => e.IdHsdb)
                    .HasName("PK__HoSoTaiS__5509385EB390C32B");

                entity.ToTable("HoSoTaiSanDB");

                entity.Property(e => e.IdHsdb)
                    .HasMaxLength(10)
                    .HasColumnName("IdHSDB")
                    .IsFixedLength();

                entity.Property(e => e.ChungNhanBaoHiem)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.DcnsoHuuDat)
                    .HasMaxLength(100)
                    .HasColumnName("DCNSoHuuDat")
                    .IsFixedLength();

                entity.Property(e => e.HdtaiSan)
                    .HasMaxLength(100)
                    .HasColumnName("HDTaiSan")
                    .IsFixedLength();

                entity.Property(e => e.IdHsvay)
                    .HasMaxLength(10)
                    .HasColumnName("IdHSVay")
                    .IsFixedLength();

                entity.Property(e => e.IdLoaiHs).HasColumnName("IdLoaiHS");

                entity.Property(e => e.NgayNhanHs)
                    .HasColumnType("datetime")
                    .HasColumnName("NgayNhanHS");

                entity.Property(e => e.SoDangKiem)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.SoNhaDat)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.TbnopPhiNd)
                    .HasMaxLength(100)
                    .HasColumnName("TBNopPhiND")
                    .IsFixedLength();

                entity.HasOne(d => d.IdHsvayNavigation)
                    .WithMany(p => p.HoSoTaiSanDbs)
                    .HasForeignKey(d => d.IdHsvay)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoSoTaiSa__IdHSV__534D60F1");

                entity.HasOne(d => d.IdLoaiHsNavigation)
                    .WithMany(p => p.HoSoTaiSanDbs)
                    .HasForeignKey(d => d.IdLoaiHs)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoSoTaiSa__IdLoa__5070F446");
            });

            modelBuilder.Entity<HoSoThamDinh>(entity =>
            {
                entity.HasKey(e => e.IdHsthamDinh)
                    .HasName("PK__HoSoTham__3950FE5517BC7DED");

                entity.ToTable("HoSoThamDinh");

                entity.Property(e => e.IdHsthamDinh)
                    .HasMaxLength(10)
                    .HasColumnName("IdHSThamDinh")
                    .IsFixedLength();

                entity.Property(e => e.BaoCaoThamDinh)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.CmndCccd)
                    .HasMaxLength(12)
                    .HasColumnName("CMND_CCCD")
                    .IsFixedLength();

                entity.Property(e => e.IdCongTy)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.IdHsdb)
                    .HasMaxLength(10)
                    .HasColumnName("IdHSDB")
                    .IsFixedLength();

                entity.Property(e => e.NgayNhanHoSo).HasColumnType("datetime");

                entity.Property(e => e.NgayThamDinh).HasColumnType("datetime");

                entity.Property(e => e.TenNguoiThamDinh).HasMaxLength(50);

                entity.HasOne(d => d.IdCongTyNavigation)
                    .WithMany(p => p.HoSoThamDinhs)
                    .HasForeignKey(d => d.IdCongTy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoSoThamD__IdCon__4F7CD00D");

                entity.HasOne(d => d.IdHsdbNavigation)
                    .WithMany(p => p.HoSoThamDinhs)
                    .HasForeignKey(d => d.IdHsdb)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoSoThamD__IdHSD__4E88ABD4");
            });

            modelBuilder.Entity<HoSoTinDung>(entity =>
            {
                entity.HasKey(e => e.IdHstinDung)
                    .HasName("PK__HoSoTinD__F86CE6E4F502E0EF");

                entity.ToTable("HoSoTinDung");

                entity.Property(e => e.IdHstinDung)
                    .ValueGeneratedNever()
                    .HasColumnName("IdHSTinDung");

                entity.Property(e => e.ChuKy)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.IdKhachHang)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.IdNhanVien)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.NgayNhanHs)
                    .HasColumnType("datetime")
                    .HasColumnName("NgayNhanHS");

                entity.HasOne(d => d.IdKhachHangNavigation)
                    .WithMany(p => p.HoSoTinDungs)
                    .HasForeignKey(d => d.IdKhachHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoSoTinDu__IdKha__4AB81AF0");

                entity.HasOne(d => d.IdNhanVienNavigation)
                    .WithMany(p => p.HoSoTinDungs)
                    .HasForeignKey(d => d.IdNhanVien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoSoTinDu__IdNha__46E78A0C");
            });

            modelBuilder.Entity<HoSoVayDoanhNghiep>(entity =>
            {
                entity.HasKey(e => e.IdHsvay)
                    .HasName("PK__HoSoVayD__460D0D48A21B39DF");

                entity.ToTable("HoSoVayDoanhNghiep");

                entity.Property(e => e.IdHsvay)
                    .HasMaxLength(10)
                    .HasColumnName("IdHSVay")
                    .IsFixedLength();

                entity.Property(e => e.IdKhachHang)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.IdNhanVien)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.NgayBdvay)
                    .HasColumnType("datetime")
                    .HasColumnName("NgayBDVay");

                entity.Property(e => e.NgayKt)
                    .HasColumnType("datetime")
                    .HasColumnName("NgayKT");

                entity.HasOne(d => d.IdKhachHangNavigation)
                    .WithMany(p => p.HoSoVayDoanhNghieps)
                    .HasForeignKey(d => d.IdKhachHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoSoVayDo__IdKha__4D94879B");

                entity.HasOne(d => d.IdNhanVienNavigation)
                    .WithMany(p => p.HoSoVayDoanhNghieps)
                    .HasForeignKey(d => d.IdNhanVien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoSoVayDo__IdNha__47DBAE45");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.IdKhachHang)
                    .HasName("PK__KhachHan__7CF5D83657894DA3");

                entity.ToTable("KhachHang");

                entity.Property(e => e.IdKhachHang)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.MaSoThue)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<KhachHangCaNhan>(entity =>
            {
                entity.HasKey(e => e.IdKhachHang)
                    .HasName("PK__KhachHan__7CF5D836093DC67A");

                entity.ToTable("KhachHangCaNhan");

                entity.Property(e => e.IdKhachHang)
                    .HasMaxLength(12)
                    .IsFixedLength();

                entity.Property(e => e.CmndCccd)
                    .HasMaxLength(12)
                    .HasColumnName("CMND_CCCD")
                    .IsFixedLength();

                entity.Property(e => e.DiaChi).HasMaxLength(100);

                entity.Property(e => e.NgaySinh).HasColumnType("datetime");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(10)
                    .HasColumnName("SDT")
                    .IsFixedLength();

                entity.HasOne(d => d.IdKhachHangNavigation)
                    .WithOne(p => p.KhachHangCaNhan)
                    .HasForeignKey<KhachHangCaNhan>(d => d.IdKhachHang)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__KhachHang__IdKha__4BAC3F29");
            });

            modelBuilder.Entity<LoaiHoSoTsdb>(entity =>
            {
                entity.HasKey(e => e.IdLoaiHs)
                    .HasName("PK__LoaiHoSo__B41B73F0CC504441");

                entity.ToTable("LoaiHoSoTSDB");

                entity.Property(e => e.IdLoaiHs)
                    .ValueGeneratedNever()
                    .HasColumnName("IdLoaiHS");

                entity.Property(e => e.TenLoai).HasMaxLength(100);
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.IdNhanVien)
                    .HasName("PK__NhanVien__B8294845A6A9174D");

                entity.ToTable("NhanVien");

                entity.Property(e => e.IdNhanVien)
                    .HasMaxLength(11)
                    .IsFixedLength();

                entity.Property(e => e.CmndCccd).HasColumnName("CMND_CCCD");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.GioiTinh)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.IdChucVu)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.NgaySinh).HasColumnType("datetime");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(10)
                    .HasColumnName("SDT")
                    .IsFixedLength();

                entity.Property(e => e.TenDangNhap)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.TenNhanVien).HasMaxLength(50);

                entity.HasOne(d => d.IdChucVuNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.IdChucVu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__NhanVien__IdChuc__45F365D3");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.MoTa).HasMaxLength(100);

                entity.Property(e => e.RoleName).HasMaxLength(50);
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.ToTable("TaiKhoan");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.HoTen).HasMaxLength(200);

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Salt)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Sdt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SDT");
            });

            modelBuilder.Entity<TheTinDung>(entity =>
            {
                entity.HasKey(e => e.Stk)
                    .HasName("PK__TheTinDu__CA1EB69B75B56EF0");

                entity.ToTable("TheTinDung");

                entity.Property(e => e.Stk)
                    .HasMaxLength(13)
                    .HasColumnName("STK")
                    .IsFixedLength();

                entity.Property(e => e.IdHstinDung).HasColumnName("IdHSTinDung");

                entity.Property(e => e.NgayMoThe).HasColumnType("datetime");

                entity.Property(e => e.NgayNhanThe).HasColumnType("datetime");

                entity.Property(e => e.SoTrenThe)
                    .HasMaxLength(16)
                    .IsFixedLength();

                entity.Property(e => e.TenTk)
                    .HasMaxLength(50)
                    .HasColumnName("TenTK");

                entity.HasOne(d => d.IdHstinDungNavigation)
                    .WithMany(p => p.TheTinDungs)
                    .HasForeignKey(d => d.IdHstinDung)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TheTinDun__IdHST__49C3F6B7");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
