﻿// <auto-generated />
using System;
using CheckerApi.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CheckerApi.Migrations
{
    [DbContext(typeof(ApiContext))]
    [Migration("20190310150853_PoolHashrate")]
    partial class PoolHashrate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CheckerApi.Models.Entities.ApiConfiguration", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("AcceptedPercentThreshold");

                    b.Property<double>("AcceptedSpeed");

                    b.Property<bool>("EnableAudit");

                    b.Property<DateTime>("LastNotification");

                    b.Property<double>("LimitSpeed");

                    b.Property<double>("MinimalAcceptedSpeed");

                    b.Property<double>("PriceThreshold");

                    b.Property<double>("TotalHashThreshold");

                    b.HasKey("ID");

                    b.ToTable("Configurations");
                });

            modelBuilder.Entity("CheckerApi.Models.Entities.BidAudit", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("AcceptedSpeed");

                    b.Property<string>("Algo");

                    b.Property<bool>("Alive");

                    b.Property<double>("LimitSpeed");

                    b.Property<int>("NiceHashDataCenter");

                    b.Property<string>("NiceHashId");

                    b.Property<double>("Price");

                    b.Property<DateTime>("RecordDate");

                    b.Property<string>("Type");

                    b.Property<string>("Workers");

                    b.HasKey("ID");

                    b.ToTable("OrderAudits");
                });

            modelBuilder.Entity("CheckerApi.Models.Entities.BidEntry", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("AcceptedSpeed");

                    b.Property<string>("Algo");

                    b.Property<bool>("Alive");

                    b.Property<double>("LimitSpeed");

                    b.Property<int>("NiceHashDataCenter");

                    b.Property<string>("NiceHashId");

                    b.Property<double>("Price");

                    b.Property<DateTime>("RecordDate");

                    b.Property<string>("Type");

                    b.Property<string>("Workers");

                    b.HasKey("ID");

                    b.ToTable("Data");
                });

            modelBuilder.Entity("CheckerApi.Models.Entities.ConditionSetting", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ConditionID");

                    b.Property<string>("ConditionName");

                    b.Property<bool>("Enabled");

                    b.HasKey("ID");

                    b.ToTable("ConditionSettings");
                });

            modelBuilder.Entity("CheckerApi.Models.Entities.PoolHashrate", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EntryDate");

                    b.Property<string>("Name");

                    b.Property<double>("Value");

                    b.HasKey("ID");

                    b.ToTable("PoolHashrate");
                });
#pragma warning restore 612, 618
        }
    }
}
