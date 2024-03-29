﻿// <auto-generated />
using JeopardyAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JeopardyAPI.Migrations
{
    [DbContext(typeof(JeopardyAPIContext))]
    [Migration("20191031182346_addSeeding")]
    partial class addSeeding
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

                    b.HasData(
                        new
                        {
                            FillInTheBlankId = 1,
                            Answer = "operators",
                            Category = "JavaScript",
                            Difficulty = "Easy",
                            Prompt = "+, -, *, /, and % are called _________. They are special characters that indicate an action to be performed."
                        },
                        new
                        {
                            FillInTheBlankId = 2,
                            Answer = "modulo",
                            Category = "JavaScript",
                            Difficulty = "Easy",
                            Prompt = "9 % 2; returns the remainder of 9 divided by 2. % is called _________."
                        },
                        new
                        {
                            FillInTheBlankId = 3,
                            Answer = "arguments",
                            Category = "JavaScript",
                            Difficulty = "Easy",
                            Prompt = "Some methods take one or more _________ that provide the method with additional information to help it perform its action."
                        },
                        new
                        {
                            FillInTheBlankId = 4,
                            Answer = "DOM",
                            Category = "JavaScript",
                            Difficulty = "Easy",
                            Prompt = "The _________ is your browser's interpretation of the HTML it reads."
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
