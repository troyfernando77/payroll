﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Version2.Framework;

namespace Version2.Migrations
{
    [DbContext(typeof(Version2Dbcontext))]
    [Migration("20221025052312_summary")]
    partial class summary
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Version2.Models.DTR", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("DTRHeadId")
                        .HasColumnType("int");

                    b.Property<decimal>("Deduction")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("NetPay")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("OTAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Reghoursperday")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("RegularHours")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("TimeIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeOut")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalHours")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalOT")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("DTRHeadId");

                    b.ToTable("DTR");
                });

            modelBuilder.Entity("Version2.Models.DTRHead", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cutoff")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Cutoffdate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Startdate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("DTRHead");
                });

            modelBuilder.Entity("Version2.Models.DTRSummary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("DTRHeadId")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DTRSummaries");
                });

            modelBuilder.Entity("Version2.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Version2.Models.Messages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Version2.Models.Rule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ItemNo")
                        .HasColumnType("int");

                    b.Property<int?>("Priority")
                        .HasColumnType("int");

                    b.Property<string>("RuleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RuleTarget")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rules");
                });

            modelBuilder.Entity("Version2.Models.DTR", b =>
                {
                    b.HasOne("Version2.Models.DTRHead", "DTRHead")
                        .WithMany("Dtrs")
                        .HasForeignKey("DTRHeadId");

                    b.OwnsOne("ValueObjects.ValueObject.RateVO", "Rate", b1 =>
                        {
                            b1.Property<int>("DTRId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("Category")
                                .HasColumnType("int");

                            b1.Property<DateTime>("OccassionDate")
                                .HasColumnType("datetime2");

                            b1.Property<string>("OccassionName")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<decimal>("Rate")
                                .HasColumnType("decimal(18,2)");

                            b1.Property<decimal>("RateHr")
                                .HasColumnType("decimal(18,2)");

                            b1.Property<decimal>("RateOTPct")
                                .HasColumnType("decimal(18,2)");

                            b1.Property<decimal>("RatePct")
                                .HasColumnType("decimal(18,2)");

                            b1.HasKey("DTRId");

                            b1.ToTable("DTR");

                            b1.WithOwner()
                                .HasForeignKey("DTRId");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
