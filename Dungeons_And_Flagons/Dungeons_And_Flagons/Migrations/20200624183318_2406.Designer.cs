﻿// <auto-generated />
using System;
using Dungeons_And_Flagons.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dungeons_And_Flagons.Migrations
{
    [DbContext(typeof(DafDB))]
    [Migration("20200624183318_2406")]
    partial class _2406
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dungeons_And_Flagons.Models.ClasseSpells", b =>
                {
                    b.Property<int>("ClasseID")
                        .HasColumnType("int");

                    b.Property<int>("SpellID")
                        .HasColumnType("int");

                    b.HasKey("ClasseID", "SpellID");

                    b.HasIndex("SpellID");

                    b.ToTable("ClasseSpells");
                });

            modelBuilder.Entity("Dungeons_And_Flagons.Models.Classes", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Features")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Source")
                        .HasColumnType("int");

                    b.Property<int>("Spellslots")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Source");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("Dungeons_And_Flagons.Models.Sources", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Permission")
                        .HasColumnType("int");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Sources");
                });

            modelBuilder.Entity("Dungeons_And_Flagons.Models.Spells", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CastingTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Components")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Range")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("School")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Source")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Source");

                    b.ToTable("Spells");
                });

            modelBuilder.Entity("Dungeons_And_Flagons.Models.SubclassSpell", b =>
                {
                    b.Property<int>("SubclassID")
                        .HasColumnType("int");

                    b.Property<int>("SpellID")
                        .HasColumnType("int");

                    b.HasKey("SubclassID", "SpellID");

                    b.HasIndex("SpellID");

                    b.ToTable("SubclassSpell");
                });

            modelBuilder.Entity("Dungeons_And_Flagons.Models.Subclasses", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Classe")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Features")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Source")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Classe");

                    b.HasIndex("Source");

                    b.ToTable("Subclasses");
                });

            modelBuilder.Entity("Dungeons_And_Flagons.Models.SubraceSpell", b =>
                {
                    b.Property<int>("SubraceID")
                        .HasColumnType("int");

                    b.Property<int>("SpellID")
                        .HasColumnType("int");

                    b.HasKey("SubraceID", "SpellID");

                    b.HasIndex("SpellID");

                    b.ToTable("SubracesSpell");
                });

            modelBuilder.Entity("Dungeons_And_Flagons.Models.Subraces", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BookID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Features")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainRace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Source")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BookID");

                    b.ToTable("Subraces");
                });

            modelBuilder.Entity("Dungeons_And_Flagons.Models.ClasseSpells", b =>
                {
                    b.HasOne("Dungeons_And_Flagons.Models.Classes", "Classe")
                        .WithMany()
                        .HasForeignKey("ClasseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dungeons_And_Flagons.Models.Spells", "Tome")
                        .WithMany()
                        .HasForeignKey("SpellID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Dungeons_And_Flagons.Models.Classes", b =>
                {
                    b.HasOne("Dungeons_And_Flagons.Models.Sources", "Book")
                        .WithMany("Classes")
                        .HasForeignKey("Source")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Dungeons_And_Flagons.Models.Spells", b =>
                {
                    b.HasOne("Dungeons_And_Flagons.Models.Sources", "Book")
                        .WithMany("Spells")
                        .HasForeignKey("Source")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Dungeons_And_Flagons.Models.SubclassSpell", b =>
                {
                    b.HasOne("Dungeons_And_Flagons.Models.Spells", "Tome")
                        .WithMany()
                        .HasForeignKey("SpellID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dungeons_And_Flagons.Models.Subclasses", "Subclass")
                        .WithMany()
                        .HasForeignKey("SubclassID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Dungeons_And_Flagons.Models.Subclasses", b =>
                {
                    b.HasOne("Dungeons_And_Flagons.Models.Classes", "MainClasse")
                        .WithMany()
                        .HasForeignKey("Classe")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dungeons_And_Flagons.Models.Sources", "Book")
                        .WithMany("Subclasses")
                        .HasForeignKey("Source")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Dungeons_And_Flagons.Models.SubraceSpell", b =>
                {
                    b.HasOne("Dungeons_And_Flagons.Models.Spells", "Tome")
                        .WithMany()
                        .HasForeignKey("SpellID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dungeons_And_Flagons.Models.Subraces", "Race")
                        .WithMany()
                        .HasForeignKey("SubraceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Dungeons_And_Flagons.Models.Subraces", b =>
                {
                    b.HasOne("Dungeons_And_Flagons.Models.Sources", "Book")
                        .WithMany("Subraces")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
