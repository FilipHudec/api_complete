﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api_complete.Data;

#nullable disable

namespace api_complete.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240918095416_migrace2")]
    partial class migrace2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("api_complete.Models.Article", b =>
                {
                    b.Property<int>("ArticleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArticleId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArticleId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            ArticleId = 1,
                            Content = "This is the content of the first article",
                            Title = "First Article"
                        },
                        new
                        {
                            ArticleId = 2,
                            Content = "This is the content of the second article",
                            Title = "Second Article"
                        });
                });

            modelBuilder.Entity("api_complete.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentId"));

                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CommentId");

                    b.HasIndex("ArticleId");

                    b.ToTable("Comment");

                    b.HasData(
                        new
                        {
                            CommentId = 1,
                            ArticleId = 1,
                            Text = "This is the first comment",
                            UserId = 0
                        },
                        new
                        {
                            CommentId = 2,
                            ArticleId = 1,
                            Text = "This is the second comment",
                            UserId = 0
                        },
                        new
                        {
                            CommentId = 3,
                            ArticleId = 2,
                            Text = "This is the third comment",
                            UserId = 0
                        });
                });

            modelBuilder.Entity("api_complete.Models.Comment", b =>
                {
                    b.HasOne("api_complete.Models.Article", "Article")
                        .WithMany("Comments")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");
                });

            modelBuilder.Entity("api_complete.Models.Article", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
