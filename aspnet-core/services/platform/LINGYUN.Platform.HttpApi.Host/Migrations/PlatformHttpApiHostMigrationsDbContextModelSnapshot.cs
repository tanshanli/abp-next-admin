﻿// <auto-generated />
using System;
using LINGYUN.Platform.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Volo.Abp.EntityFrameworkCore;

namespace LINGYUN.Platform.Migrations
{
    [DbContext(typeof(PlatformHttpApiHostMigrationsDbContext))]
    partial class PlatformHttpApiHostMigrationsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("_Abp_DatabaseProvider", EfCoreDatabaseProvider.MySql)
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LINGYUN.Platform.Datas.Data", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnName("Code")
                        .HasColumnType("varchar(1024) CHARACTER SET utf8mb4")
                        .HasMaxLength(1024);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("ConcurrencyStamp")
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4")
                        .HasMaxLength(40);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnName("DeleterId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnName("DeletionTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnName("Description")
                        .HasColumnType("varchar(1024) CHARACTER SET utf8mb4")
                        .HasMaxLength(1024);

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnName("DisplayName")
                        .HasColumnType("varchar(128) CHARACTER SET utf8mb4")
                        .HasMaxLength(128);

                    b.Property<string>("ExtraProperties")
                        .HasColumnName("ExtraProperties")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsDeleted")
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnName("TenantId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("AppPlatformDatas");
                });

            modelBuilder.Entity("LINGYUN.Platform.Datas.DataItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("AllowBeNull")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(true);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("ConcurrencyStamp")
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4")
                        .HasMaxLength(40);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("DataId")
                        .HasColumnType("char(36)");

                    b.Property<string>("DefaultValue")
                        .HasColumnName("DefaultValue")
                        .HasColumnType("varchar(128) CHARACTER SET utf8mb4")
                        .HasMaxLength(128);

                    b.Property<Guid?>("DeleterId")
                        .HasColumnName("DeleterId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnName("DeletionTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnName("Description")
                        .HasColumnType("varchar(1024) CHARACTER SET utf8mb4")
                        .HasMaxLength(1024);

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnName("DisplayName")
                        .HasColumnType("varchar(128) CHARACTER SET utf8mb4")
                        .HasMaxLength(128);

                    b.Property<string>("ExtraProperties")
                        .HasColumnName("ExtraProperties")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsDeleted")
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<Guid?>("TenantId")
                        .HasColumnName("TenantId")
                        .HasColumnType("char(36)");

                    b.Property<int>("ValueType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DataId");

                    b.HasIndex("Name");

                    b.ToTable("AppPlatformDataItems");
                });

            modelBuilder.Entity("LINGYUN.Platform.Layouts.Layout", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Code")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("ConcurrencyStamp")
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4")
                        .HasMaxLength(40);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("DataId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnName("DeleterId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnName("DeletionTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnName("DisplayName")
                        .HasColumnType("varchar(128) CHARACTER SET utf8mb4")
                        .HasMaxLength(128);

                    b.Property<string>("ExtraProperties")
                        .HasColumnName("ExtraProperties")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsDeleted")
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasColumnType("varchar(64) CHARACTER SET utf8mb4")
                        .HasMaxLength(64);

                    b.Property<string>("Path")
                        .HasColumnName("Path")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<int>("PlatformType")
                        .HasColumnType("int");

                    b.Property<string>("Redirect")
                        .HasColumnName("Redirect")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<Guid?>("TenantId")
                        .HasColumnName("TenantId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.ToTable("AppPlatformLayouts");
                });

            modelBuilder.Entity("LINGYUN.Platform.Menus.Menu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnName("Code")
                        .HasColumnType("varchar(23) CHARACTER SET utf8mb4")
                        .HasMaxLength(23);

                    b.Property<string>("Component")
                        .IsRequired()
                        .HasColumnName("Component")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("ConcurrencyStamp")
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4")
                        .HasMaxLength(40);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnName("DeleterId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnName("DeletionTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnName("DisplayName")
                        .HasColumnType("varchar(128) CHARACTER SET utf8mb4")
                        .HasMaxLength(128);

                    b.Property<string>("ExtraProperties")
                        .HasColumnName("ExtraProperties")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsDeleted")
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<bool>("IsPublic")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("LayoutId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasColumnType("varchar(64) CHARACTER SET utf8mb4")
                        .HasMaxLength(64);

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Path")
                        .HasColumnName("Path")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<int>("PlatformType")
                        .HasColumnType("int");

                    b.Property<string>("Redirect")
                        .HasColumnName("Redirect")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<Guid?>("TenantId")
                        .HasColumnName("TenantId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.ToTable("AppPlatformMenus");
                });

            modelBuilder.Entity("LINGYUN.Platform.Menus.RoleMenu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("MenuId")
                        .HasColumnType("char(36)");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnName("RoleName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<Guid?>("TenantId")
                        .HasColumnName("TenantId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("RoleName", "MenuId");

                    b.ToTable("AppPlatformRoleMenus");
                });

            modelBuilder.Entity("LINGYUN.Platform.Menus.UserMenu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("MenuId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnName("TenantId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("UserId", "MenuId");

                    b.ToTable("AppPlatformUserMenus");
                });

            modelBuilder.Entity("LINGYUN.Platform.Versions.AppVersion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("ConcurrencyStamp")
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4")
                        .HasMaxLength(40);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnName("DeleterId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnName("DeletionTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnName("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4")
                        .HasMaxLength(2048);

                    b.Property<string>("ExtraProperties")
                        .HasColumnName("ExtraProperties")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsDeleted")
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("PlatformType")
                        .HasColumnType("int");

                    b.Property<Guid?>("TenantId")
                        .HasColumnName("TenantId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnName("Title")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("Version")
                        .IsRequired()
                        .HasColumnName("Version")
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("Version");

                    b.ToTable("AppPlatformVersion");
                });

            modelBuilder.Entity("LINGYUN.Platform.Versions.VersionFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<Guid>("AppVersionId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId")
                        .HasColumnType("char(36)");

                    b.Property<int>("DownloadCount")
                        .HasColumnType("int");

                    b.Property<int>("FileType")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<string>("Path")
                        .HasColumnName("Path")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<string>("SHA256")
                        .IsRequired()
                        .HasColumnName("SHA256")
                        .HasColumnType("varchar(65) CHARACTER SET utf8mb4")
                        .HasMaxLength(65);

                    b.Property<long>("Size")
                        .HasColumnType("bigint");

                    b.Property<Guid?>("TenantId")
                        .HasColumnName("TenantId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Version")
                        .IsRequired()
                        .HasColumnName("Version")
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("AppVersionId");

                    b.HasIndex("Path", "Name", "Version")
                        .IsUnique();

                    b.ToTable("AppPlatformVersionFile");
                });

            modelBuilder.Entity("LINGYUN.Platform.Datas.DataItem", b =>
                {
                    b.HasOne("LINGYUN.Platform.Datas.Data", null)
                        .WithMany("Items")
                        .HasForeignKey("DataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LINGYUN.Platform.Versions.VersionFile", b =>
                {
                    b.HasOne("LINGYUN.Platform.Versions.AppVersion", "AppVersion")
                        .WithMany("Files")
                        .HasForeignKey("AppVersionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
