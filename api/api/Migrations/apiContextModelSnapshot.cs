﻿// <auto-generated />
using api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace api.Migrations
{
    [DbContext(typeof(apiContext))]
    partial class apiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("api.Models.Party", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Parties");
                });

            modelBuilder.Entity("api.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Admin");

                    b.Property<string>("CurrentPartyId");

                    b.Property<bool>("Owner");

                    b.Property<string>("PendingPartyId");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.HasIndex("CurrentPartyId");

                    b.HasIndex("PendingPartyId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("api.Models.User", b =>
                {
                    b.HasOne("api.Models.Party", "CurrentParty")
                        .WithMany("Members")
                        .HasForeignKey("CurrentPartyId");

                    b.HasOne("api.Models.Party", "PendingParty")
                        .WithMany("PendingMembers")
                        .HasForeignKey("PendingPartyId");
                });
#pragma warning restore 612, 618
        }
    }
}
