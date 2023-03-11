using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StudyBase1.models
{
    public partial class StudyBaseContext : DbContext
    {
        public StudyBaseContext()
        {
        }

        public StudyBaseContext(DbContextOptions<StudyBaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Chacha> Chachas { get; set; } = null!;
        public virtual DbSet<DataSdachi> DataSdachis { get; set; } = null!;
        public virtual DbSet<Discipline> Disciplines { get; set; } = null!;
        public virtual DbSet<Fakultet> Fakultets { get; set; } = null!;
        public virtual DbSet<FakultetNumberGroup> FakultetNumberGroups { get; set; } = null!;
        public virtual DbSet<FormaObychenium> FormaObychenia { get; set; } = null!;
        public virtual DbSet<NumberGroup> NumberGroups { get; set; } = null!;
        public virtual DbSet<Ocenki> Ocenkis { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=StudyBase;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chacha>(entity =>
            {
                entity.ToTable("Chacha");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DataChacha).HasColumnType("date");

                entity.Property(e => e.OcenkaId).HasColumnName("OCenkaId");

                entity.HasOne(d => d.Discipline)
                    .WithMany(p => p.Chachas)
                    .HasForeignKey(d => d.DisciplineId)
                    .HasConstraintName("FK_Chacha_Discipline");

                entity.HasOne(d => d.Ocenka)
                    .WithMany(p => p.Chachas)
                    .HasForeignKey(d => d.OcenkaId)
                    .HasConstraintName("FK_Chacha_Ocenki");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Chachas)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_Chacha_Student");
            });

            modelBuilder.Entity<DataSdachi>(entity =>
            {
                entity.ToTable("data sdachi");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ДатаСдачи)
                    .HasColumnType("date")
                    .HasColumnName("Дата сдачи");
            });

            modelBuilder.Entity<Discipline>(entity =>
            {
                entity.ToTable("Discipline");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Наименование).HasMaxLength(50);
            });

            modelBuilder.Entity<Fakultet>(entity =>
            {
                entity.ToTable("Fakultet");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.НаименованиеФакультета)
                    .HasMaxLength(50)
                    .HasColumnName("Наименование факультета");
            });

            modelBuilder.Entity<FakultetNumberGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Fakultet/NumberGroup");

                entity.Property(e => e.Disciplineid).HasColumnName("disciplineid");

                entity.Property(e => e.Foid).HasColumnName("FOid");

                entity.Property(e => e.Ngid).HasColumnName("NGid");

                entity.Property(e => e.Ocenkiid).HasColumnName("ocenkiid");

                entity.HasOne(d => d.Discipline)
                    .WithMany()
                    .HasForeignKey(d => d.Disciplineid)
                    .HasConstraintName("FK_Fakultet/NumberGroup_Discipline");

                entity.HasOne(d => d.Fakultet)
                    .WithMany()
                    .HasForeignKey(d => d.Fakultetid)
                    .HasConstraintName("FK_Fakultet/NumberGroup_Fakultet");

                entity.HasOne(d => d.Fo)
                    .WithMany()
                    .HasForeignKey(d => d.Foid)
                    .HasConstraintName("FK_Fakultet/NumberGroup_FormaObychenia");

                entity.HasOne(d => d.Ng)
                    .WithMany()
                    .HasForeignKey(d => d.Ngid)
                    .HasConstraintName("FK_Fakultet/NumberGroup_NumberGroup");

                entity.HasOne(d => d.Ocenki)
                    .WithMany()
                    .HasForeignKey(d => d.Ocenkiid)
                    .HasConstraintName("FK_Fakultet/NumberGroup_Ocenki");
            });

            modelBuilder.Entity<FormaObychenium>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ФормаОбучения)
                    .HasMaxLength(50)
                    .HasColumnName("Форма обучения");
            });

            modelBuilder.Entity<NumberGroup>(entity =>
            {
                entity.ToTable("NumberGroup");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.НаименованиеГруппы)
                    .HasMaxLength(50)
                    .HasColumnName("Наименование группы");

                entity.HasOne(d => d.IdFakultetNavigation)
                    .WithMany(p => p.NumberGroups)
                    .HasForeignKey(d => d.IdFakultet)
                    .HasConstraintName("FK_NumberGroup_Fakultet");

                entity.HasOne(d => d.IdFormaObycheniaNavigation)
                    .WithMany(p => p.NumberGroups)
                    .HasForeignKey(d => d.IdFormaObychenia)
                    .HasConstraintName("FK_NumberGroup_FormaObychenia");
            });

            modelBuilder.Entity<Ocenki>(entity =>
            {
                entity.ToTable("Ocenki");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Балл).HasColumnName("балл");

                entity.Property(e => e.Название)
                    .HasMaxLength(50)
                    .HasColumnName("название");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.IdGroupNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.IdGroup)
                    .HasConstraintName("FK_Student_NumberGroup");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
