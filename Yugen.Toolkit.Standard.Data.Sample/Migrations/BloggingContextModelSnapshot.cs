﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Yugen.Toolkit.Standard.Data.Sample;

namespace Yugen.Toolkit.Standard.Data.Sample.Migrations
{
    [DbContext(typeof(BloggingContext))]
    partial class BloggingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5");

            modelBuilder.Entity("Yugen.Toolkit.Standard.Data.Sample.Models.Blog", b =>
                {
                    b.Property<Guid>("BlogId")
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

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("BlogId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("Yugen.Toolkit.Standard.Data.Sample.Models.Post", b =>
                {
                    b.Property<Guid>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("BlogId")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("BlogId1")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("ClientLastUpdated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("TEXT");

                    b.Property<int>("Index")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("LastUpdated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("PostId");

                    b.HasIndex("BlogId1");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Yugen.Toolkit.Standard.Data.Sample.Models.Post", b =>
                {
                    b.HasOne("Yugen.Toolkit.Standard.Data.Sample.Models.Blog", "Blog")
                        .WithMany("Posts")
                        .HasForeignKey("BlogId1");
                });
#pragma warning restore 612, 618
        }
    }
}
