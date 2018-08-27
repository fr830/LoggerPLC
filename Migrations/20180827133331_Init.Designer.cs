﻿// <auto-generated />
using System;
using LoggerPLC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LoggerPLC.Migrations
{
    [DbContext(typeof(LoggerPLCDbContext))]
    [Migration("20180827133331_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LoggerPLC.Models.Data", b =>
                {
                    b.Property<int>("DataID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<int?>("TaskID");

                    b.Property<int>("Value");

                    b.HasKey("DataID");

                    b.HasIndex("TaskID");

                    b.ToTable("Datas");
                });

            modelBuilder.Entity("LoggerPLC.Models.Error", b =>
                {
                    b.Property<int>("ErrorID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descryption");

                    b.Property<int?>("TaskID");

                    b.HasKey("ErrorID");

                    b.HasIndex("TaskID");

                    b.ToTable("Errors");
                });

            modelBuilder.Entity("LoggerPLC.Models.Task", b =>
                {
                    b.Property<int>("TaskID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("IpPLC")
                        .IsRequired();

                    b.Property<bool>("IsActive");

                    b.Property<string>("TagName")
                        .IsRequired();

                    b.Property<int>("TaskInterval");

                    b.Property<string>("TaskName")
                        .IsRequired();

                    b.HasKey("TaskID");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("LoggerPLC.Models.Data", b =>
                {
                    b.HasOne("LoggerPLC.Models.Task", "Task")
                        .WithMany()
                        .HasForeignKey("TaskID");
                });

            modelBuilder.Entity("LoggerPLC.Models.Error", b =>
                {
                    b.HasOne("LoggerPLC.Models.Task", "Task")
                        .WithMany()
                        .HasForeignKey("TaskID");
                });
#pragma warning restore 612, 618
        }
    }
}
