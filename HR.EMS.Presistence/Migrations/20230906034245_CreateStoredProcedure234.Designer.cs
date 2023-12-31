﻿// <auto-generated />
using System;
using HR.EMS.Presistence.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HR.EMS.Presistence.Migrations
{
    [DbContext(typeof(HrDatabaseContext))]
    [Migration("20230906034245_CreateStoredProcedure234")]
    partial class CreateStoredProcedure234
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HR.EMS.Domain.ApiLogs", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<int?>("ElapsedMilliseconds")
                        .HasColumnType("int");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long?>("ModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<string>("RequestBody")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequestHeaders")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequestMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequestPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RequestTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ResponseBody")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ResponseTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("RowId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("StatusCode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ApiLogs");
                });

            modelBuilder.Entity("HR.EMS.Domain.LeaveAllocations", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<long>("EmployeeId")
                        .HasColumnType("bigint");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long>("LeaveTypeId")
                        .HasColumnType("bigint");

                    b.Property<long?>("ModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<Guid?>("RowId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("LeaveTypeId");

                    b.ToTable("LeaveAllocations");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            DateCreated = new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(2928),
                            EmployeeId = 1L,
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 1L,
                            RowId = new Guid("506393b6-0aa2-48c6-84e0-3a282019a61f")
                        },
                        new
                        {
                            Id = 2L,
                            DateCreated = new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(2929),
                            EmployeeId = 1L,
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 2L,
                            RowId = new Guid("e780fdc4-d1cf-4b25-b170-bcb57790a577")
                        },
                        new
                        {
                            Id = 3L,
                            DateCreated = new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(2931),
                            EmployeeId = 1L,
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 3L,
                            RowId = new Guid("757e2e20-2e9b-4105-93c2-0cd3d1317a6d")
                        },
                        new
                        {
                            Id = 4L,
                            DateCreated = new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(2932),
                            EmployeeId = 2L,
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 1L,
                            RowId = new Guid("0b528019-61e6-41a2-a7e3-202ff3ac73b8")
                        },
                        new
                        {
                            Id = 5L,
                            DateCreated = new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(2934),
                            EmployeeId = 2L,
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 2L,
                            RowId = new Guid("71e58778-0a5d-46ee-8c19-3c76cb2927b0")
                        },
                        new
                        {
                            Id = 6L,
                            DateCreated = new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(2935),
                            EmployeeId = 2L,
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 3L,
                            RowId = new Guid("664829c0-0b79-4d04-b455-3be9ca0d3196")
                        },
                        new
                        {
                            Id = 7L,
                            DateCreated = new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(2974),
                            EmployeeId = 2L,
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 4L,
                            RowId = new Guid("a80dd90c-cf10-4c01-a212-a5bd032e9797")
                        });
                });

            modelBuilder.Entity("HR.EMS.Domain.LeaveNatures", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long?>("ModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RowId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("LeaveNatures");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            DateCreated = new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(1649),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Travel",
                            RowId = new Guid("c8173f5e-f0fd-4569-ada7-fe6811fa11b5")
                        },
                        new
                        {
                            Id = 2L,
                            DateCreated = new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(1668),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Local",
                            RowId = new Guid("31852682-baa7-475f-b6a4-cb891dc48e9c")
                        });
                });

            modelBuilder.Entity("HR.EMS.Domain.LeaveRequest", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<bool?>("Approved")
                        .HasColumnType("bit");

                    b.Property<bool>("Cancelled")
                        .HasColumnType("bit");

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateRequested")
                        .HasColumnType("datetime2");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<long>("EmployeeId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long>("LeaveTypeId")
                        .HasColumnType("bigint");

                    b.Property<long?>("ModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<string>("RequestComments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RowId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("LeaveTypeId");

                    b.ToTable("LeaveRequests");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Approved = true,
                            Cancelled = false,
                            DateCreated = new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(2843),
                            DateRequested = new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(2846),
                            EmployeeId = 1L,
                            EndDate = new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 1L,
                            RequestComments = "Vacation leave",
                            RowId = new Guid("b00057c2-cbe8-4e3a-9bdf-3b32e4b1b29b"),
                            StartDate = new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2L,
                            Approved = false,
                            Cancelled = true,
                            DateCreated = new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(2848),
                            DateRequested = new DateTime(2023, 9, 1, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(2849),
                            EmployeeId = 1L,
                            EndDate = new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 2L,
                            RequestComments = "Sick leave",
                            RowId = new Guid("6699f6e4-28f8-4c48-9cb0-f29c124be4a7"),
                            StartDate = new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3L,
                            Approved = true,
                            Cancelled = false,
                            DateCreated = new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(2854),
                            DateRequested = new DateTime(2023, 8, 27, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(2855),
                            EmployeeId = 1L,
                            EndDate = new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 3L,
                            RequestComments = "Study leave",
                            RowId = new Guid("f9f04d1a-f8e7-47ea-96db-6c5a5355c008"),
                            StartDate = new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10L,
                            Approved = true,
                            Cancelled = false,
                            DateCreated = new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(2857),
                            DateRequested = new DateTime(2023, 8, 22, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(2858),
                            EmployeeId = 1L,
                            EndDate = new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 1L,
                            RequestComments = "Holiday leave",
                            RowId = new Guid("4ed5bdb4-7fcd-4406-bf6d-e9ffaa69d30f"),
                            StartDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("HR.EMS.Domain.LeaveTypes", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("DefaultDays")
                        .HasColumnType("int");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long?>("ModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RowId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("LeaveTypes");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            DateCreated = new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(1795),
                            DefaultDays = 10,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Sick Leave",
                            RowId = new Guid("0eb0673d-6ce6-4f1a-9e55-63ab22482373")
                        },
                        new
                        {
                            Id = 2L,
                            DateCreated = new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(1797),
                            DefaultDays = 20,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Annual Leave",
                            RowId = new Guid("9742a75e-3b9e-4d37-a2b2-bb93b6eebb0c")
                        },
                        new
                        {
                            Id = 3L,
                            DateCreated = new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(1798),
                            DefaultDays = 15,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Study Leave",
                            RowId = new Guid("0b8b4a7a-10f9-43d7-9c96-f622d9607ad7")
                        },
                        new
                        {
                            Id = 4L,
                            DateCreated = new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(1799),
                            DefaultDays = 90,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Maternal Leave",
                            RowId = new Guid("8273e7b4-3515-40b2-8c12-aed4f33d099f")
                        });
                });

            modelBuilder.Entity("HR.EMS.Domain.Roles", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long?>("ModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RowId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            DateCreated = new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(1884),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "admin",
                            RowId = new Guid("fa577186-451a-416e-ac22-6a457b5af2b4")
                        },
                        new
                        {
                            Id = 2L,
                            DateCreated = new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(1886),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "employee",
                            RowId = new Guid("104f1ea2-921a-4c1a-8424-2751603c42ed")
                        });
                });

            modelBuilder.Entity("HR.EMS.Domain.Users", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("GenderId")
                        .HasColumnType("bigint");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("ModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.Property<Guid?>("RowId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            DateCreated = new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(2714),
                            Email = "ali.mushtaq@example.com",
                            FirstName = "Ali",
                            IsActive = true,
                            IsDeleted = false,
                            IsEmailConfirmed = true,
                            LastName = "Mushtaq",
                            Password = "sTqk3XRhvv9XejHhEKV0NGdW6ZrkDfls4x+9AwrB6TE=",
                            RoleId = 1L,
                            RowId = new Guid("b4720c3b-275a-49bc-8107-bec4694f1ceb"),
                            UserName = "alimushtaq"
                        },
                        new
                        {
                            Id = 2L,
                            DateCreated = new DateTime(2023, 9, 6, 7, 42, 45, 171, DateTimeKind.Local).AddTicks(2719),
                            Email = "junaid.mushtaq@example.com",
                            FirstName = "Junaid",
                            IsActive = true,
                            IsDeleted = false,
                            IsEmailConfirmed = true,
                            LastName = "Mushtaq",
                            Password = "sTqk3XRhvv9XejHhEKV0NGdW6ZrkDfls4x+9AwrB6TE=",
                            RoleId = 2L,
                            RowId = new Guid("c36280c3-d849-4776-b2b1-3834e3f04035"),
                            UserName = "junaidmushtaq"
                        });
                });

            modelBuilder.Entity("object", b =>
                {
                    b.ToTable((string)null);

                    b.ToSqlQuery("EXEC sp_executesql N'USE [HR_EMS]\r\nGO\r\n/****** Object:  StoredProcedure [dbo].[CalculateLeaveSummaryByEmployee]    Script Date: 06/09/2023 7:17:43 am ******/\r\nSET ANSI_NULLS ON\r\nGO\r\nSET QUOTED_IDENTIFIER ON\r\nGO\r\nALTER PROCEDURE [dbo].[CalculateLeaveSummaryByEmployee]\r\n    @EmployeeId bigint\r\nAS\r\nBEGIN\r\n    SET NOCOUNT ON;\r\n\r\n    DECLARE @TotalAvailedLeave INT;\r\n    DECLARE @TotalRejectLeave INT;\r\n    DECLARE @TotalPendingLeave INT;\r\n	DECLARE @TotalEmployeeLeave INT;\r\n\r\n    -- Calculate Total Availed Leave (Approved = 1)\r\n    SELECT @TotalAvailedLeave = COUNT(*)\r\n    FROM LeaveRequests\r\n    WHERE Approved = 1 AND EmployeeId = @EmployeeId AND IsActive = 1 AND IsDeleted = 0;\r\n\r\n    -- Calculate Total Reject Leave (Cancelled = 1)\r\n    SELECT @TotalRejectLeave = COUNT(*)\r\n    FROM LeaveRequests\r\n    WHERE Cancelled = 1 AND EmployeeId = @EmployeeId AND IsActive = 1 AND IsDeleted = 0;\r\n\r\n    -- Calculate Total Pending Leave (Approved = 0 AND Cancelled = 0)\r\n    SELECT @TotalPendingLeave = COUNT(*)\r\n    FROM LeaveRequests\r\n    WHERE Approved = 0 AND Cancelled = 0 AND EmployeeId = @EmployeeId AND IsActive = 1 AND IsDeleted = 0;\r\n\r\n	-- Calculate Total Employee Leave\r\n	SELECT @TotalEmployeeLeave = SUM(DefaultDays)\r\n	FROM (\r\n		SELECT al.EmployeeId, lt.DefaultDays\r\n		FROM LeaveAllocations al\r\n		INNER JOIN LeaveTypes lt ON al.LeaveTypeId = lt.Id\r\n	) AS tbl\r\n	WHERE EmployeeId = 1 \r\n	GROUP BY EmployeeId;\r\n\r\n    -- Return the results\r\n    SELECT\r\n        TotalAvailedLeave = @TotalAvailedLeave,\r\n        TotalRejectLeave = @TotalRejectLeave,\r\n        TotalPendingLeave = @TotalPendingLeave,\r\n		TotalEmployeeLeave = @TotalEmployeeLeave;\r\n\r\nEND;\r\n'");
                });

            modelBuilder.Entity("HR.EMS.Domain.LeaveAllocations", b =>
                {
                    b.HasOne("HR.EMS.Domain.Users", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HR.EMS.Domain.LeaveTypes", "LeaveType")
                        .WithMany()
                        .HasForeignKey("LeaveTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("LeaveType");
                });

            modelBuilder.Entity("HR.EMS.Domain.LeaveRequest", b =>
                {
                    b.HasOne("HR.EMS.Domain.Users", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HR.EMS.Domain.LeaveTypes", "LeaveType")
                        .WithMany()
                        .HasForeignKey("LeaveTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("LeaveType");
                });

            modelBuilder.Entity("HR.EMS.Domain.Users", b =>
                {
                    b.HasOne("HR.EMS.Domain.Roles", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });
#pragma warning restore 612, 618
        }
    }
}
