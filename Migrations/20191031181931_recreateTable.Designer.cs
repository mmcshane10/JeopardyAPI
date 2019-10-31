﻿// <auto-generated />
using JeopardyAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JeopardyAPI.Migrations
{
    [DbContext(typeof(JeopardyAPIContext))]
    [Migration("20191031181931_recreateTable")]
    partial class recreateTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("JeopardyAPI.Models.FillInTheBlank", b =>
                {
                    b.Property<int>("FillInTheBlankId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Answer");

                    b.Property<string>("Category");

                    b.Property<string>("Difficulty");

                    b.Property<string>("Prompt");

                    b.HasKey("FillInTheBlankId");

                    b.ToTable("FillInTheBlank");
                });
#pragma warning restore 612, 618
        }
    }
}
