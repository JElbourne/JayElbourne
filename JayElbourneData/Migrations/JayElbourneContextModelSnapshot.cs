﻿// <auto-generated />
using System;
using JayElbourneData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JayElbourneData.Migrations
{
    [DbContext(typeof(JayElbourneContext))]
    partial class JayElbourneContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JayElbourneData.Models.Credit", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<long?>("ProjectId");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Credits");
                });

            modelBuilder.Entity("JayElbourneData.Models.Image", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("ImageUrl")
                        .IsRequired();

                    b.Property<long?>("ProjectId");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("JayElbourneData.Models.Project", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<bool>("Featured");

                    b.Property<string>("ImageUrl");

                    b.Property<DateTime>("PostedOn");

                    b.Property<long?>("ProjectStatusId");

                    b.Property<bool>("Published");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<DateTime?>("UpdatedOn");

                    b.Property<string>("UrlSlug");

                    b.HasKey("Id");

                    b.HasIndex("ProjectStatusId");

                    b.ToTable("Projects");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Project");
                });

            modelBuilder.Entity("JayElbourneData.Models.Reference", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<long?>("ProjectId");

                    b.Property<string>("Url")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("References");
                });

            modelBuilder.Entity("JayElbourneData.Models.Status", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("JayElbourneData.Models.Tag", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(140);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<long?>("ProjectId");

                    b.Property<string>("UrlSlug");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("JayElbourneData.Models.Video", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("AnimationId");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<long?>("FilmId");

                    b.Property<string>("VideoUrl")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("AnimationId");

                    b.HasIndex("FilmId");

                    b.ToTable("Videos");
                });

            modelBuilder.Entity("JayElbourneData.Models.Animation", b =>
                {
                    b.HasBaseType("JayElbourneData.Models.Project");


                    b.ToTable("Animation");

                    b.HasDiscriminator().HasValue("Animation");
                });

            modelBuilder.Entity("JayElbourneData.Models.Architecture", b =>
                {
                    b.HasBaseType("JayElbourneData.Models.Project");

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("Area")
                        .IsRequired();

                    b.Property<string>("Classification")
                        .IsRequired();

                    b.Property<string>("Floors")
                        .IsRequired();

                    b.ToTable("Architecture");

                    b.HasDiscriminator().HasValue("Architecture");
                });

            modelBuilder.Entity("JayElbourneData.Models.Film", b =>
                {
                    b.HasBaseType("JayElbourneData.Models.Project");


                    b.ToTable("Film");

                    b.HasDiscriminator().HasValue("Film");
                });

            modelBuilder.Entity("JayElbourneData.Models.Gaming", b =>
                {
                    b.HasBaseType("JayElbourneData.Models.Project");

                    b.Property<string>("PlayableUrl")
                        .IsRequired();

                    b.Property<string>("RepositoryUrl")
                        .IsRequired();

                    b.Property<long?>("TrailerId");

                    b.HasIndex("TrailerId");

                    b.ToTable("Gaming");

                    b.HasDiscriminator().HasValue("Gaming");
                });

            modelBuilder.Entity("JayElbourneData.Models.Programming", b =>
                {
                    b.HasBaseType("JayElbourneData.Models.Project");

                    b.Property<long?>("DemoVideoId");

                    b.Property<string>("RepositoryUrl")
                        .IsRequired()
                        .HasColumnName("Programming_RepositoryUrl");

                    b.HasIndex("DemoVideoId");

                    b.ToTable("Programming");

                    b.HasDiscriminator().HasValue("Programming");
                });

            modelBuilder.Entity("JayElbourneData.Models.Writing", b =>
                {
                    b.HasBaseType("JayElbourneData.Models.Project");

                    b.Property<string>("Body")
                        .IsRequired();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.ToTable("Writing");

                    b.HasDiscriminator().HasValue("Writing");
                });

            modelBuilder.Entity("JayElbourneData.Models.Credit", b =>
                {
                    b.HasOne("JayElbourneData.Models.Project")
                        .WithMany("Credits")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("JayElbourneData.Models.Image", b =>
                {
                    b.HasOne("JayElbourneData.Models.Project")
                        .WithMany("Images")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("JayElbourneData.Models.Project", b =>
                {
                    b.HasOne("JayElbourneData.Models.Status", "ProjectStatus")
                        .WithMany()
                        .HasForeignKey("ProjectStatusId");
                });

            modelBuilder.Entity("JayElbourneData.Models.Reference", b =>
                {
                    b.HasOne("JayElbourneData.Models.Project")
                        .WithMany("References")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("JayElbourneData.Models.Tag", b =>
                {
                    b.HasOne("JayElbourneData.Models.Project")
                        .WithMany("Tags")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("JayElbourneData.Models.Video", b =>
                {
                    b.HasOne("JayElbourneData.Models.Animation")
                        .WithMany("Videos")
                        .HasForeignKey("AnimationId");

                    b.HasOne("JayElbourneData.Models.Film")
                        .WithMany("Videos")
                        .HasForeignKey("FilmId");
                });

            modelBuilder.Entity("JayElbourneData.Models.Gaming", b =>
                {
                    b.HasOne("JayElbourneData.Models.Video", "Trailer")
                        .WithMany()
                        .HasForeignKey("TrailerId");
                });

            modelBuilder.Entity("JayElbourneData.Models.Programming", b =>
                {
                    b.HasOne("JayElbourneData.Models.Video", "DemoVideo")
                        .WithMany()
                        .HasForeignKey("DemoVideoId");
                });
#pragma warning restore 612, 618
        }
    }
}
