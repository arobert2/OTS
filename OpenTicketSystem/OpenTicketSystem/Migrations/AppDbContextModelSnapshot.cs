﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using OpenTicketSystem.Models;
using System;

namespace OpenTicketSystem.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OpenTicketSystem.Models.CommentModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<bool>("EmailSent");

                    b.Property<bool>("PublicFacing");

                    b.Property<int>("PublisherUserId");

                    b.Property<int?>("TicketModelId");

                    b.Property<DateTime>("TimeStamp");

                    b.HasKey("Id");

                    b.HasIndex("TicketModelId");

                    b.ToTable("CommentModel");
                });

            modelBuilder.Entity("OpenTicketSystem.Models.TicketModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<int>("CustomerUserId");

                    b.Property<string>("Subject");

                    b.Property<int>("TechnicianUserId");

                    b.Property<DateTime>("TimeStamp");

                    b.HasKey("Id");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("OpenTicketSystem.Models.CommentModel", b =>
                {
                    b.HasOne("OpenTicketSystem.Models.TicketModel")
                        .WithMany("Comments")
                        .HasForeignKey("TicketModelId");
                });
#pragma warning restore 612, 618
        }
    }
}
