﻿// <auto-generated />
using System;
using MessageBoardApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MessageBoardApi.Migrations
{
    [DbContext(typeof(MessageBoardApiContext))]
    [Migration("20231024203721_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MessageBoardApi.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("GroupId");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            GroupId = 1,
                            Name = "Spider-Man"
                        },
                        new
                        {
                            GroupId = 2,
                            Name = "Witcher"
                        },
                        new
                        {
                            GroupId = 3,
                            Name = "Costumes"
                        });
                });

            modelBuilder.Entity("MessageBoardApi.Models.GroupUser", b =>
                {
                    b.Property<int>("GroupUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("GroupUserId");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("GroupUsers");

                    b.HasData(
                        new
                        {
                            GroupUserId = 1,
                            GroupId = 1,
                            UserId = 2
                        },
                        new
                        {
                            GroupUserId = 2,
                            GroupId = 3,
                            UserId = 1
                        },
                        new
                        {
                            GroupUserId = 3,
                            GroupId = 2,
                            UserId = 3
                        },
                        new
                        {
                            GroupUserId = 4,
                            GroupId = 2,
                            UserId = 2
                        },
                        new
                        {
                            GroupUserId = 5,
                            GroupId = 2,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("MessageBoardApi.Models.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("MessageId");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("Messages");

                    b.HasData(
                        new
                        {
                            MessageId = 1,
                            Date = new DateTime(2022, 12, 8, 8, 15, 0, 0, DateTimeKind.Unspecified),
                            GroupId = 1,
                            Text = "This new Spider-Man game looks awesome!",
                            UserId = 2
                        },
                        new
                        {
                            MessageId = 2,
                            Date = new DateTime(2023, 3, 21, 6, 30, 0, 0, DateTimeKind.Unspecified),
                            GroupId = 3,
                            Text = "What did ya'll get for candy? I got rocks.",
                            UserId = 1
                        },
                        new
                        {
                            MessageId = 3,
                            Date = new DateTime(2020, 5, 13, 8, 11, 0, 0, DateTimeKind.Unspecified),
                            GroupId = 2,
                            Text = "I hate Ciri!",
                            UserId = 3
                        });
                });

            modelBuilder.Entity("MessageBoardApi.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Name = "Joey"
                        },
                        new
                        {
                            UserId = 2,
                            Name = "Richard"
                        },
                        new
                        {
                            UserId = 3,
                            Name = "Onur"
                        });
                });

            modelBuilder.Entity("MessageBoardApi.Models.GroupUser", b =>
                {
                    b.HasOne("MessageBoardApi.Models.Group", "Group")
                        .WithMany("JoinEntities")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MessageBoardApi.Models.User", "User")
                        .WithMany("JoinEntities")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MessageBoardApi.Models.Message", b =>
                {
                    b.HasOne("MessageBoardApi.Models.Group", "Group")
                        .WithMany("Messages")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MessageBoardApi.Models.User", "User")
                        .WithMany("Messages")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MessageBoardApi.Models.Group", b =>
                {
                    b.Navigation("JoinEntities");

                    b.Navigation("Messages");
                });

            modelBuilder.Entity("MessageBoardApi.Models.User", b =>
                {
                    b.Navigation("JoinEntities");

                    b.Navigation("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}
