﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201019074520_UserPasswordadded")]
    partial class UserPasswordadded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-rc.2.20475.6");

            modelBuilder.Entity("API.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("passwordSalt")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("passwrodHash")
                        .HasColumnType("BLOB");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
