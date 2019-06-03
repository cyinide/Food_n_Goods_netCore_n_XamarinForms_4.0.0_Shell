using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FoodsNGoods.WebAPI.Model
{
    public partial class FoodsNGoodsContext : DbContext
    {
        public FoodsNGoodsContext()
        {
        }

        public FoodsNGoodsContext(DbContextOptions<FoodsNGoodsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AuthTokeni> AuthTokeni { get; set; }
        public virtual DbSet<Badgevi> Badgevi { get; set; }
        public virtual DbSet<Blokovi> Blokovi { get; set; }
        public virtual DbSet<Gradovi> Gradovi { get; set; }
        public virtual DbSet<HranaPrilog> HranaPrilog { get; set; }
        public virtual DbSet<Jelovnici> Jelovnici { get; set; }
        public virtual DbSet<Kuponi> Kuponi { get; set; }
        public virtual DbSet<Lajkovi> Lajkovi { get; set; }
        public virtual DbSet<Moderatori> Moderatori { get; set; }
        public virtual DbSet<Narucioci> Narucioci { get; set; }
        public virtual DbSet<Narudzbe> Narudzbe { get; set; }
        public virtual DbSet<Obavjestenja> Obavjestenja { get; set; }
        public virtual DbSet<Proizvodi> Proizvodi { get; set; }
        public virtual DbSet<Recenzije> Recenzije { get; set; }
        public virtual DbSet<Restorani> Restorani { get; set; }
        public virtual DbSet<RestoraniOmiljeni> RestoraniOmiljeni { get; set; }
        public virtual DbSet<StavkeNarudzbe> StavkeNarudzbe { get; set; }
        public virtual DbSet<TipoviKuhinje> TipoviKuhinje { get; set; }
        public virtual DbSet<Vlasnici> Vlasnici { get; set; }
        public virtual DbSet<VrijemeRada> VrijemeRada { get; set; }
        public virtual DbSet<Zalbe> Zalbe { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\;Database=FoodsNGoods;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<AuthTokeni>(entity =>
            {
                entity.HasIndex(e => e.ModeratorId);

                entity.HasIndex(e => e.NarucilacId);

                entity.HasIndex(e => e.VlasnikId);

                entity.HasOne(d => d.Moderator)
                    .WithMany(p => p.AuthTokeni)
                    .HasForeignKey(d => d.ModeratorId);

                entity.HasOne(d => d.Narucilac)
                    .WithMany(p => p.AuthTokeni)
                    .HasForeignKey(d => d.NarucilacId);

                entity.HasOne(d => d.Vlasnik)
                    .WithMany(p => p.AuthTokeni)
                    .HasForeignKey(d => d.VlasnikId);
            });

            modelBuilder.Entity<Badgevi>(entity =>
            {
                entity.HasKey(e => e.BadgeId);

                entity.Property(e => e.BadgeId).HasColumnName("BadgeID");
            });

            modelBuilder.Entity<Blokovi>(entity =>
            {
                entity.HasKey(e => e.BlokId);

                entity.HasIndex(e => e.GradId);

                entity.Property(e => e.BlokId).HasColumnName("BlokID");

                entity.Property(e => e.GradId).HasColumnName("GradID");

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Blokovi)
                    .HasForeignKey(d => d.GradId);
            });

            modelBuilder.Entity<Gradovi>(entity =>
            {
                entity.HasKey(e => e.GradId);

                entity.Property(e => e.GradId).HasColumnName("GradID");
            });

            modelBuilder.Entity<HranaPrilog>(entity =>
            {
                entity.HasKey(e => new { e.HranaId, e.PrilogId });

                entity.HasIndex(e => e.PrilogId);

                entity.Property(e => e.HranaId).HasColumnName("HranaID");

                entity.Property(e => e.PrilogId).HasColumnName("PrilogID");

                entity.HasOne(d => d.Hrana)
                    .WithMany(p => p.HranaPrilogHrana)
                    .HasForeignKey(d => d.HranaId);

                entity.HasOne(d => d.Prilog)
                    .WithMany(p => p.HranaPrilogPrilog)
                    .HasForeignKey(d => d.PrilogId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Jelovnici>(entity =>
            {
                entity.HasKey(e => e.JelovnikId);

                entity.HasIndex(e => e.RestoranId);

                entity.Property(e => e.JelovnikId).HasColumnName("JelovnikID");

                entity.Property(e => e.RestoranId).HasColumnName("RestoranID");

                entity.HasOne(d => d.Restoran)
                    .WithMany(p => p.Jelovnici)
                    .HasForeignKey(d => d.RestoranId);
            });

            modelBuilder.Entity<Kuponi>(entity =>
            {
                entity.HasKey(e => e.KuponId);

                entity.Property(e => e.KuponId).HasColumnName("KuponID");
            });

            modelBuilder.Entity<Lajkovi>(entity =>
            {
                entity.HasKey(e => e.RestoranLikeId);

                entity.HasIndex(e => e.NarucilacId);

                entity.HasIndex(e => e.RestoranId);

                entity.Property(e => e.RestoranLikeId).HasColumnName("RestoranLikeID");

                entity.Property(e => e.NarucilacId).HasColumnName("NarucilacID");

                entity.Property(e => e.RestoranId).HasColumnName("RestoranID");

                entity.HasOne(d => d.Narucilac)
                    .WithMany(p => p.Lajkovi)
                    .HasForeignKey(d => d.NarucilacId);

                entity.HasOne(d => d.Restoran)
                    .WithMany(p => p.Lajkovi)
                    .HasForeignKey(d => d.RestoranId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Moderatori>(entity =>
            {
                entity.HasKey(e => e.KorisnikId);

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");
            });

            modelBuilder.Entity<Narucioci>(entity =>
            {
                entity.HasKey(e => e.KorisnikId);

                entity.HasIndex(e => e.BadgeId);

                entity.HasIndex(e => e.BlokId);

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.BadgeId).HasColumnName("BadgeID");

                entity.Property(e => e.BlokId).HasColumnName("BlokID");

                entity.HasOne(d => d.Badge)
                    .WithMany(p => p.Narucioci)
                    .HasForeignKey(d => d.BadgeId);

                entity.HasOne(d => d.Blok)
                    .WithMany(p => p.Narucioci)
                    .HasForeignKey(d => d.BlokId);
            });

            modelBuilder.Entity<Narudzbe>(entity =>
            {
                entity.HasKey(e => e.NarudzbaId);

                entity.HasIndex(e => e.KuponId);

                entity.Property(e => e.NarudzbaId).HasColumnName("NarudzbaID");

                entity.Property(e => e.KuponId).HasColumnName("KuponID");

                entity.Property(e => e.NarucilacId).HasColumnName("NarucilacID");

                entity.HasOne(d => d.Kupon)
                    .WithMany(p => p.Narudzbe)
                    .HasForeignKey(d => d.KuponId);
            });

            modelBuilder.Entity<Obavjestenja>(entity =>
            {
                entity.HasKey(e => e.ObavjestenjeId);

                entity.Property(e => e.ObavjestenjeId).HasColumnName("ObavjestenjeID");
            });

            modelBuilder.Entity<Proizvodi>(entity =>
            {
                entity.HasKey(e => e.HranaId);

                entity.HasIndex(e => e.JelovnikId);

                entity.HasIndex(e => e.TipKuhinjeId);

                entity.Property(e => e.HranaId).HasColumnName("HranaID");

                entity.Property(e => e.JelovnikId).HasColumnName("JelovnikID");

                entity.Property(e => e.TipKuhinjeId).HasColumnName("TipKuhinjeID");

                entity.HasOne(d => d.Jelovnik)
                    .WithMany(p => p.Proizvodi)
                    .HasForeignKey(d => d.JelovnikId);

                entity.HasOne(d => d.TipKuhinje)
                    .WithMany(p => p.Proizvodi)
                    .HasForeignKey(d => d.TipKuhinjeId);
            });

            modelBuilder.Entity<Recenzije>(entity =>
            {
                entity.HasKey(e => e.RestoranRecenzijaId);

                entity.HasIndex(e => e.NarucilacId);

                entity.HasIndex(e => e.RestoranId);

                entity.Property(e => e.RestoranRecenzijaId).HasColumnName("RestoranRecenzijaID");

                entity.Property(e => e.NarucilacId).HasColumnName("NarucilacID");

                entity.Property(e => e.RestoranId).HasColumnName("RestoranID");

                entity.HasOne(d => d.Narucilac)
                    .WithMany(p => p.Recenzije)
                    .HasForeignKey(d => d.NarucilacId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Restoran)
                    .WithMany(p => p.Recenzije)
                    .HasForeignKey(d => d.RestoranId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Restorani>(entity =>
            {
                entity.HasKey(e => e.RestoranId);

                entity.HasIndex(e => e.BlokId);

                entity.HasIndex(e => e.VlasnikId);

                entity.Property(e => e.RestoranId).HasColumnName("RestoranID");

                entity.Property(e => e.BlokId).HasColumnName("BlokID");

                entity.Property(e => e.VlasnikId).HasColumnName("VlasnikID");

                entity.HasOne(d => d.Blok)
                    .WithMany(p => p.Restorani)
                    .HasForeignKey(d => d.BlokId);

                entity.HasOne(d => d.Vlasnik)
                    .WithMany(p => p.Restorani)
                    .HasForeignKey(d => d.VlasnikId);
            });

            modelBuilder.Entity<RestoraniOmiljeni>(entity =>
            {
                entity.HasKey(e => e.RestoranOmiljeniId)
                    .HasName("PK__Restoran__8F94C627B00F7003");

                entity.Property(e => e.RestoranOmiljeniId).HasColumnName("RestoranOmiljeniID");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.RestoranId).HasColumnName("RestoranID");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.RestoraniOmiljeni)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Restorani__Koris__43D61337");

                entity.HasOne(d => d.Restoran)
                    .WithMany(p => p.RestoraniOmiljeni)
                    .HasForeignKey(d => d.RestoranId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Restorani__Resto__44CA3770");
            });

            modelBuilder.Entity<StavkeNarudzbe>(entity =>
            {
                entity.HasIndex(e => e.HranaId);

                entity.HasIndex(e => e.NarudzbaId);

                entity.Property(e => e.StavkeNarudzbeId).HasColumnName("StavkeNarudzbeID");

                entity.Property(e => e.HranaId).HasColumnName("HranaID");

                entity.Property(e => e.NarudzbaId).HasColumnName("NarudzbaID");

                entity.HasOne(d => d.Hrana)
                    .WithMany(p => p.StavkeNarudzbe)
                    .HasForeignKey(d => d.HranaId);

                entity.HasOne(d => d.Narudzba)
                    .WithMany(p => p.StavkeNarudzbe)
                    .HasForeignKey(d => d.NarudzbaId);
            });

            modelBuilder.Entity<TipoviKuhinje>(entity =>
            {
                entity.HasKey(e => e.TipKuhinjeId);

                entity.Property(e => e.TipKuhinjeId).HasColumnName("TipKuhinjeID");
            });

            modelBuilder.Entity<Vlasnici>(entity =>
            {
                entity.HasKey(e => e.KorisnikId);

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");
            });

            modelBuilder.Entity<VrijemeRada>(entity =>
            {
                entity.HasKey(e => e.RadnoVrijemeId);

                entity.HasIndex(e => e.RestoranId);

                entity.Property(e => e.RadnoVrijemeId).HasColumnName("RadnoVrijemeID");

                entity.Property(e => e.RestoranId).HasColumnName("RestoranID");

                entity.HasOne(d => d.Restoran)
                    .WithMany(p => p.VrijemeRada)
                    .HasForeignKey(d => d.RestoranId);
            });

            modelBuilder.Entity<Zalbe>(entity =>
            {
                entity.HasKey(e => e.ZalbaId);

                entity.Property(e => e.ZalbaId).HasColumnName("ZalbaID");
            });
        }
    }
}
