using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebComponent.Models
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Component> Component { get; set; }
        public virtual DbSet<ComponentFile> ComponentFile { get; set; }
        public virtual DbSet<DownloadRecord> DownloadRecord { get; set; }
        public virtual DbSet<Member> Member { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=LAPTOP-CVML7B2H\\SQLEXPRESS;Database=BIMComponentDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Component>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Create)
                    .HasColumnName("_Create")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("_Description");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("_LastUpdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasColumnName("_Owner")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<ComponentFile>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("PK_File");

                entity.Property(e => e.FileId)
                    .HasColumnName("_FileID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationTime)
                    .HasColumnName("_CreationTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasColumnName("_FileType")
                    .HasMaxLength(50);

                entity.Property(e => e.LastAccessTime)
                    .HasColumnName("_LastAccessTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("_Name");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnName("_Path");
            });

            modelBuilder.Entity<DownloadRecord>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.Property(e => e.RecordId)
                    .HasColumnName("_RecordID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Downloader)
                    .IsRequired()
                    .HasColumnName("_Downloader")
                    .HasMaxLength(15);

                entity.Property(e => e.FileId).HasColumnName("_FileID");

                entity.Property(e => e.Time)
                    .HasColumnName("_Time")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.DownloaderNavigation)
                    .WithMany(p => p.DownloadRecord)
                    .HasForeignKey(d => d.Downloader)
                    .HasConstraintName("FK_DownloadRecord_Member");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.DownloadRecord)
                    .HasForeignKey(d => d.FileId)
                    .HasConstraintName("FK_DownloadRecord_File");
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.HasKey(e => e.Account);

                entity.Property(e => e.Account)
                    .HasColumnName("_Account")
                    .HasMaxLength(15)
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("_Email")
                    .HasMaxLength(100);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("_FirstName")
                    .HasMaxLength(50);

                entity.Property(e => e.LastLogIn)
                    .HasColumnName("_LastLogIn")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("_LastName")
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("_Password")
                    .HasMaxLength(20);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("_Phone")
                    .HasMaxLength(20);

                entity.Property(e => e.RelComponent).HasColumnName("_RelComponent");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("_Type")
                    .HasMaxLength(10);

                entity.HasOne(d => d.RelComponentNavigation)
                    .WithMany(p => p.Member)
                    .HasForeignKey(d => d.RelComponent)
                    .HasConstraintName("FK_Member_Component");
            });
        }
    }
}
