using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Portofolio.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
#nullable disable

namespace Portofolio.Database
{
    public partial class PortofolioDbContext : IdentityDbContext<User, UserRole, int>
    {
        public PortofolioDbContext(DbContextOptions<PortofolioDbContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<ContactStatus> ContactStatuses { get; set; }
        public virtual DbSet<LinkType> LinkTypes { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<ProjectFeedback> ProjectFeedbacks { get; set; }
        public virtual DbSet<ProjectImage> ProjectImages { get; set; }
        public virtual DbSet<ProjectLink> ProjectLinks { get; set; }
        public virtual DbSet<ProjectType> ProjectTypes { get; set; }
        public virtual DbSet<UserLink> UserLinks { get; set; }
        public virtual DbSet<UserRoleInProject> UserProjectRoles { get; set; }
        public virtual DbSet<UsersInProject> UsersInProjects { get; set; }
        public virtual DbSet<Service> Services { get; set; }

        public virtual DbSet<ContactLog> ContactLogs { get; set; }
        public virtual DbSet<ProjectLog> ProjectLogs { get; set; }

        public virtual DbSet<ServicesLog> ServicesLogs { get; set; }

        public virtual DbSet<RequestedService> RequestedServices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_0900_ai_ci");

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("contacts_ibfk_1");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("projects_ibfk_1");
            });

            modelBuilder.Entity<ProjectFeedback>(entity =>
            {
                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectFeedbacks)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("projectfeedbacks_ibfk_1");
            });

            modelBuilder.Entity<ProjectImage>(entity =>
            {
                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectImages)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("projectimages_ibfk_1");
            });

            modelBuilder.Entity<ProjectLink>(entity =>
            {
                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectLinks)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("projectlinks_ibfk_1");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.ProjectLinks)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("projectlinks_ibfk_2");
            });

            modelBuilder.Entity<UserLink>(entity =>
            {
                entity.HasOne(d => d.Type)
                    .WithMany(p => p.UserLinks)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("userlinks_ibfk_2");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserLinks)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("userlinks_ibfk_1");
            });

            modelBuilder.Entity<UsersInProject>(entity =>
            {
                entity.HasOne(d => d.Project)
                    .WithMany(p => p.UsersInProjects)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("usersinprojects_ibfk_2");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UsersInProjects)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("usersinprojects_ibfk_3");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersInProjects)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("usersinprojects_ibfk_1");
            });
            base.OnModelCreating(modelBuilder);
            OnModelCreatingPartial(modelBuilder);
            modelBuilder.Seed();
            modelBuilder.SeedServices();
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
