﻿// <auto-generated />
using Ecf.Vgames.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ecf.Vgames.Migrations
{
    [DbContext(typeof(ContexteGizmondo))]
    [Migration("20240910082851_bugfixName")]
    partial class bugfixName
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ecf.Vgames.Models.Gizmondos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Developper")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("dev");

                    b.Property<string>("Game")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("game");

                    b.Property<int>("PublisherId")
                        .HasColumnType("int")
                        .HasColumnName("publisherId");

                    b.Property<int>("Year")
                        .HasColumnType("int")
                        .HasColumnName("year");

                    b.HasKey("Id");

                    b.HasIndex("PublisherId");

                    b.ToTable("Gizmondos");
                });

            modelBuilder.Entity("Ecf.Vgames.Models.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("Ecf.Vgames.Models.Gizmondos", b =>
                {
                    b.HasOne("Ecf.Vgames.Models.Publisher", "Publisher")
                        .WithMany()
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Publisher");
                });
#pragma warning restore 612, 618
        }
    }
}
