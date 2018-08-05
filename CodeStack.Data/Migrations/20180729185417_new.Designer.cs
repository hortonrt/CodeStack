﻿// <auto-generated />
using CodeStack.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeStack.Data.Migrations {
    [DbContext(typeof(CodeStackContext))]
    [Migration("20180729185417_new")]
    partial class @new {
        protected override void BuildTargetModel(ModelBuilder modelBuilder) {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CodeStack.Data.Models.Navigation.Route", b => {
                b.Property<int>("RouteID")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Details")
                    .HasColumnType("VARCHAR(100)");

                b.Property<string>("Name")
                    .HasColumnType("VARCHAR(25)");

                b.Property<int>("NavOrder");

                b.Property<string>("Routerlink")
                    .HasColumnType("VARCHAR(25)");

                b.HasKey("RouteID");

                b.ToTable("Routes", "Options");
            });
#pragma warning restore 612, 618
        }
    }
}