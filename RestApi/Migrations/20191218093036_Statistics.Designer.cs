﻿//// <auto-generated />
//using System;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Infrastructure;
//using Microsoft.EntityFrameworkCore.Metadata;
//using Microsoft.EntityFrameworkCore.Migrations;
//using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
//using RestApi.Model;

//namespace RestApi.Migrations
//{
//    [DbContext(typeof(SanasorsaContext))]
//    [Migration("20191218093036_Statistics")]
//    partial class Statistics
//    {
//        protected override void BuildTargetModel(ModelBuilder modelBuilder)
//        {
//#pragma warning disable 612, 618
//            modelBuilder
//                .HasAnnotation("ProductVersion", "3.1.0")
//                .HasAnnotation("Relational:MaxIdentifierLength", 128)
//                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

//            modelBuilder.Entity("RestApi.Model.Player", b =>
//                {
//                    b.Property<int>("playerID")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnName("PlayerID")
//                        .HasColumnType("int")
//                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

//                    b.Property<DateTime?>("Timeof")
//                        .HasColumnName("Timeof")
//                        .HasColumnType("datetime");

//                    b.Property<string>("nickname")
//                        .HasColumnType("nvarchar(50)")
//                        .HasMaxLength(50);

//                    b.Property<int>("scores")
//                        .HasColumnName("Scores")
//                        .HasColumnType("int");

//                    b.HasKey("playerID");

//                    b.ToTable("Player");
//                });

//            modelBuilder.Entity("RestApi.Model.Statistics", b =>
//                {
//                    b.Property<int>("statID")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnName("StatID")
//                        .HasColumnType("int")
//                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

//                    b.Property<DateTime?>("Time")
//                        .HasColumnName("Time")
//                        .HasColumnType("datetime");

//                    b.Property<string>("json")
//                        .HasColumnName("Json")
//                        .HasColumnType("nvarchar(max)");

//                    b.HasKey("statID");

//                    b.ToTable("Statistics");
//                });
//#pragma warning restore 612, 618
//        }
//    }
//}