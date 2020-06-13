﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UwpCommunity.Data;

namespace UwpCommunity.Data.Migrations
{
    [DbContext(typeof(UwpCommunityDbContext))]
    partial class UwpCommunityDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5");

            modelBuilder.Entity("UwpCommunity.Data.Models.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("ClientLastUpdated")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("TEXT");

                    b.Property<int>("Index")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("LastUpdated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.HasIndex("LastUpdated");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("UwpCommunity.Data.Models.Launch", b =>
                {
                    b.Property<Guid>("LaunchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("ClientLastUpdated")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("TEXT");

                    b.Property<int>("Index")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("LastUpdated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Year")
                        .HasColumnType("TEXT");

                    b.HasKey("LaunchId");

                    b.HasIndex("LastUpdated");

                    b.ToTable("Launch");
                });

            modelBuilder.Entity("UwpCommunity.Data.Models.LaunchProject", b =>
                {
                    b.Property<Guid>("LaunchId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ProjectId")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("ClientLastUpdated")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("TEXT");

                    b.Property<int>("Index")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("LastUpdated")
                        .HasColumnType("TEXT");

                    b.HasKey("LaunchId", "ProjectId");

                    b.HasIndex("ProjectId");

                    b.ToTable("LaunchProject");
                });

            modelBuilder.Entity("UwpCommunity.Data.Models.Project", b =>
                {
                    b.Property<Guid>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("AppName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("AwaitingLaunchApproval")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("ClientLastUpdated")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("DownloadLink")
                        .HasColumnType("TEXT");

                    b.Property<string>("ExternalLink")
                        .HasColumnType("TEXT");

                    b.Property<string>("GithubLink")
                        .HasColumnType("TEXT");

                    b.Property<string>("HeroImage")
                        .HasColumnType("TEXT");

                    b.Property<int>("Index")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsPrivate")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("LastUpdated")
                        .HasColumnType("TEXT");

                    b.Property<string>("LookingForRoles")
                        .HasColumnType("TEXT");

                    b.Property<bool>("NeedsManualReview")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProjectId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("LastUpdated");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("UwpCommunity.Data.Models.Role", b =>
                {
                    b.Property<Guid>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("ClientLastUpdated")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("TEXT");

                    b.Property<int>("Index")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("LastUpdated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("RoleId");

                    b.HasIndex("LastUpdated");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("UwpCommunity.Data.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("ClientLastUpdated")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("DiscordId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<int>("Index")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("LastUpdated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.HasIndex("LastUpdated");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("UwpCommunity.Data.Models.UserProject", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ProjectId")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("ClientLastUpdated")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("TEXT");

                    b.Property<int>("Index")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsOwner")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("LastUpdated")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "ProjectId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserProject");
                });

            modelBuilder.Entity("UwpCommunity.Data.Models.LaunchProject", b =>
                {
                    b.HasOne("UwpCommunity.Data.Models.Launch", "Launch")
                        .WithMany("LaunchProjects")
                        .HasForeignKey("LaunchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UwpCommunity.Data.Models.Project", "Project")
                        .WithMany("LaunchProjects")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UwpCommunity.Data.Models.Project", b =>
                {
                    b.HasOne("UwpCommunity.Data.Models.Category", "Category")
                        .WithMany("Projects")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UwpCommunity.Data.Models.UserProject", b =>
                {
                    b.HasOne("UwpCommunity.Data.Models.Project", "Project")
                        .WithMany("UserProjects")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UwpCommunity.Data.Models.Role", "Role")
                        .WithMany("UserProjects")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UwpCommunity.Data.Models.User", "User")
                        .WithMany("UserProjects")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
