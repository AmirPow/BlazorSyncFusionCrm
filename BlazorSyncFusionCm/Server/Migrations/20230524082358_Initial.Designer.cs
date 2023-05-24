﻿// <auto-generated />
using System;
using BlazorSyncFusionCm.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorSyncFusionCm.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230524082358_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorSyncFusionCm.Shared.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("contacts");

                    b.HasData(
                        new
                        {
                            Id = 11,
                            DateCreated = new DateTime(2023, 5, 24, 11, 53, 58, 63, DateTimeKind.Local).AddTicks(4433),
                            DateOfBirth = new DateTime(2022, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Amir",
                            IsDeleted = false,
                            LastName = "Ahmadi",
                            NickName = "Joe",
                            Place = "Tab"
                        },
                        new
                        {
                            Id = 12,
                            DateCreated = new DateTime(2023, 5, 24, 11, 53, 58, 63, DateTimeKind.Local).AddTicks(4436),
                            DateOfBirth = new DateTime(2022, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Amir2",
                            IsDeleted = false,
                            LastName = "Ahmadi",
                            NickName = "Joe",
                            Place = "Tab"
                        },
                        new
                        {
                            Id = 13,
                            DateCreated = new DateTime(2023, 5, 24, 11, 53, 58, 63, DateTimeKind.Local).AddTicks(4438),
                            DateOfBirth = new DateTime(2022, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Amir3",
                            IsDeleted = false,
                            LastName = "Ahmadi",
                            NickName = "Joe",
                            Place = "Tab"
                        },
                        new
                        {
                            Id = 14,
                            DateCreated = new DateTime(2023, 5, 24, 11, 53, 58, 63, DateTimeKind.Local).AddTicks(4439),
                            DateOfBirth = new DateTime(2022, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Amir4",
                            IsDeleted = false,
                            LastName = "Ahmadi",
                            NickName = "Joe",
                            Place = "Tab"
                        },
                        new
                        {
                            Id = 15,
                            DateCreated = new DateTime(2023, 5, 24, 11, 53, 58, 63, DateTimeKind.Local).AddTicks(4441),
                            DateOfBirth = new DateTime(2022, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Amir5",
                            IsDeleted = false,
                            LastName = "Ahmadi",
                            NickName = "Joe",
                            Place = "Tab"
                        },
                        new
                        {
                            Id = 16,
                            DateCreated = new DateTime(2023, 5, 24, 11, 53, 58, 63, DateTimeKind.Local).AddTicks(4442),
                            DateOfBirth = new DateTime(2022, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Amir6",
                            IsDeleted = false,
                            LastName = "Ahmadi",
                            NickName = "Joe",
                            Place = "Tab"
                        });
                });

            modelBuilder.Entity("BlazorSyncFusionCm.Shared.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ContactId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.ToTable("Nots");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ContactId = 1,
                            DateCreated = new DateTime(2023, 5, 24, 11, 53, 58, 63, DateTimeKind.Local).AddTicks(4545),
                            Text = "Am"
                        },
                        new
                        {
                            Id = 2,
                            ContactId = 2,
                            DateCreated = new DateTime(2023, 5, 24, 11, 53, 58, 63, DateTimeKind.Local).AddTicks(4547),
                            Text = "Am"
                        },
                        new
                        {
                            Id = 3,
                            ContactId = 3,
                            DateCreated = new DateTime(2023, 5, 24, 11, 53, 58, 63, DateTimeKind.Local).AddTicks(4548),
                            Text = "Am"
                        });
                });

            modelBuilder.Entity("BlazorSyncFusionCm.Shared.Note", b =>
                {
                    b.HasOne("BlazorSyncFusionCm.Shared.Contact", "Contact")
                        .WithMany("Notes")
                        .HasForeignKey("ContactId");

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("BlazorSyncFusionCm.Shared.Contact", b =>
                {
                    b.Navigation("Notes");
                });
#pragma warning restore 612, 618
        }
    }
}