﻿// <auto-generated />
using System;
using LY.MicroService.TaskManagement.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Volo.Abp.EntityFrameworkCore;

#nullable disable

namespace LY.MicroService.TaskManagement.EntityFrameworkCore.Migrations
{
    [DbContext(typeof(TaskManagementMigrationsDbContext))]
    [Migration("20231028084851_Upgrade-Abp-Framework-To-7.4.0")]
    partial class UpgradeAbpFrameworkTo740
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("_Abp_DatabaseProvider", EfCoreDatabaseProvider.MySql)
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LINGYUN.Abp.TaskManagement.BackgroundJobAction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("char(36)")
                        .HasColumnName("CreatorId");

                    b.Property<string>("ExtraProperties")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("JobId")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("JobId");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("char(36)")
                        .HasColumnName("LastModifierId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Name");

                    b.Property<string>("Paramters")
                        .HasColumnType("longtext")
                        .HasColumnName("Paramters");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("TK_BackgroundJobActions", (string)null);
                });

            modelBuilder.Entity("LINGYUN.Abp.TaskManagement.BackgroundJobInfo", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Args")
                        .HasColumnType("longtext")
                        .HasColumnName("Args");

                    b.Property<DateTime>("BeginTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ConcurrencyStamp");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("CreationTime");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("char(36)")
                        .HasColumnName("CreatorId");

                    b.Property<string>("Cron")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Cron");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("Description");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ExtraProperties")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ExtraProperties");

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Group");

                    b.Property<int>("Interval")
                        .HasColumnType("int");

                    b.Property<bool>("IsAbandoned")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("JobType")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("LastModificationTime");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("char(36)")
                        .HasColumnName("LastModifierId");

                    b.Property<DateTime?>("LastRunTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("LockTimeOut")
                        .HasColumnType("int");

                    b.Property<int>("MaxCount")
                        .HasColumnType("int");

                    b.Property<int>("MaxTryCount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Name");

                    b.Property<DateTime?>("NextRunTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NodeName")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)")
                        .HasColumnName("NodeName");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<string>("Result")
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("Result");

                    b.Property<int>("Source")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.Property<int>("TriggerCount")
                        .HasColumnType("int");

                    b.Property<int>("TryCount")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("Type");

                    b.HasKey("Id");

                    b.HasIndex("Name", "Group");

                    b.ToTable("TK_BackgroundJobs", (string)null);
                });

            modelBuilder.Entity("LINGYUN.Abp.TaskManagement.BackgroundJobLog", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Exception")
                        .HasMaxLength(2000)
                        .HasColumnType("varchar(2000)")
                        .HasColumnName("Exception");

                    b.Property<string>("JobGroup")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("JobGroup");

                    b.Property<string>("JobId")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("JobId");

                    b.Property<string>("JobName")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("JobName");

                    b.Property<string>("JobType")
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("JobType");

                    b.Property<string>("Message")
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("Message");

                    b.Property<DateTime>("RunTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)")
                        .HasColumnName("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("JobGroup", "JobName");

                    b.ToTable("TK_BackgroundJobLogs", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
