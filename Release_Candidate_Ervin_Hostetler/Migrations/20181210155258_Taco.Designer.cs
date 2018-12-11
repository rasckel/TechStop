﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Release_Candidate_Ervin_Hostetler.Models;

namespace Release_Candidate_Ervin_Hostetler.Migrations
{
    [DbContext(typeof(Release_Candidate_Ervin_HostetlerContext))]
    [Migration("20181210155258_Taco")]
    partial class Taco
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Release_Candidate_Ervin_Hostetler.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("TicketNumber");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Release_Candidate_Ervin_Hostetler.Models.Labor", b =>
                {
                    b.Property<int>("LaborId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<double>("LaborCost");

                    b.Property<int>("Quantity");

                    b.HasKey("LaborId");

                    b.ToTable("Labor");
                });

            modelBuilder.Entity("Release_Candidate_Ervin_Hostetler.Models.Purchase", b =>
                {
                    b.Property<int>("PurchaseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AmazonPurchase");

                    b.Property<string>("Description");

                    b.Property<double>("PurchasePrice");

                    b.Property<int>("Quantity");

                    b.Property<double>("ShippingCost");

                    b.Property<string>("URL");

                    b.HasKey("PurchaseId");

                    b.ToTable("Purchase");
                });

            modelBuilder.Entity("Release_Candidate_Ervin_Hostetler.Models.Quote", b =>
                {
                    b.Property<int>("QuoteID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<double>("LaborCost");

                    b.Property<string>("LaborDescription");

                    b.Property<int>("LaborQuantity");

                    b.Property<string>("Name");

                    b.Property<string>("PurchaseDescription");

                    b.Property<double>("PurchasePrice");

                    b.Property<int>("PurchaseQuantity");

                    b.Property<double>("PurchaseShippingCost");

                    b.Property<string>("PurchaseURL");

                    b.Property<string>("Reason");

                    b.Property<double>("ShippingCost");

                    b.Property<double>("SubTotal");

                    b.Property<double>("Tax");

                    b.Property<int>("TicketNumber");

                    b.Property<double>("Total");

                    b.Property<string>("Type");

                    b.Property<string>("URL");

                    b.HasKey("QuoteID");

                    b.ToTable("Quote");
                });
#pragma warning restore 612, 618
        }
    }
}