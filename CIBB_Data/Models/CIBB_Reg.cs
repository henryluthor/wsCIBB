using IBM.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CIBB_Data.Models
{
    public partial class CIBB_Reg : DbContext
    {
        public CIBB_Reg()
        {
        }

        public CIBB_Reg(DbContextOptions<CIBB_Reg> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCibbRegistro> TblCibbRegistros { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseDb2("DATABASE=SAAC;SERVER=192.168.254.53:50000;UID=espol;PWD=espol123;", x => x.SetServerInfo(IBMDBServerType.LUW));
            }
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblCibbRegistro>(entity =>
            {
                entity.Property(e => e.Celular)
                    .HasPrecision(10)
                    .IsUnicode(false);

                entity.Property(e => e.Idcibbregistro).ValueGeneratedOnAdd();

                entity.Property(e => e.Numeroidentificacion)
                    .HasPrecision(14)
                    .IsUnicode(false);

                entity.Property(e => e.UltimoCambio)
                    .HasPrecision(10)
                    .HasDefaultValueSql("CURRENT TIMESTAMP");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
