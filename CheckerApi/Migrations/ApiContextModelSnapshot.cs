﻿// <auto-generated />
using CheckerApi.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Storage.Internal;
using System;

namespace CheckerApi.Migrations
{
    [DbContext(typeof(ApiContext))]
    partial class ApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026");

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
#pragma warning restore 612, 618
        }
    }
}
