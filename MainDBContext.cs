using Microsoft.EntityFrameworkCore;
using StudentApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApp
{
    public class MainDBContext : DbContext
    {

        public MainDBContext() {


        }

        public MainDBContext(DbContextOptions options) : base(options)
        {


        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Study> Studies { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("###");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>(opt =>
            {
                opt.HasKey(e => e.IdStudent);
                opt.Property(e => e.IdStudent).ValueGeneratedOnAdd();
                opt.Property(e => e.FirstName).IsRequired().HasMaxLength(200);
                opt.Property(e => e.LastName).IsRequired().HasMaxLength(200);
                opt.Property(e => e.IndexNumber).IsRequired().HasMaxLength(100);
                opt.Property(e => e.StudyYear).IsRequired();

                opt.HasData(
                    new Student { IdStudent = 1, FirstName = "A", LastName = "AA", IndexNumber = "S11", StudyYear = 1, StudyId = 1},
                    new Student { IdStudent = 2, FirstName = "B", LastName = "BB", IndexNumber = "S12", StudyYear = 2, StudyId = 1},
                    new Student { IdStudent = 3, FirstName = "C", LastName = "CC", IndexNumber = "S13", StudyYear = 3, StudyId = 2 }

                   );

                //must be sth wrong with the definition - no objects returned
                opt.HasOne(e => e.Study)
                    .WithMany(s => s.Students)
                    .HasForeignKey(s => s.StudyId);

           
            });


            modelBuilder.Entity<Study>(opt =>
            {
                opt.HasKey(e => e.IdStudy);
                opt.Property(e => e.IdStudy).ValueGeneratedOnAdd();
                opt.Property(e => e.Name).IsRequired().HasMaxLength(200);
                opt.Property(e => e.Type).IsRequired().HasMaxLength(200);

                opt.HasData(
                   new Study { IdStudy = 1, Name="S1", Type="S" },
                   new Study { IdStudy = 2, Name = "S2", Type = "Z" }

                  );


            });
        }
    }
}
