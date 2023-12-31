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
    [Migration("20230906025854_removeColumn")]
    partial class removeColumn
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
                            DateCreated = new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(1844),
                            EmployeeId = 1L,
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 1L,
                            RowId = new Guid("417a0654-ca9c-4080-aa23-e33455c30e34")
                        },
                        new
                        {
                            Id = 2L,
                            DateCreated = new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(1846),
                            EmployeeId = 1L,
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 2L,
                            RowId = new Guid("c16db90f-b957-4779-9fa8-f2060b265ecd")
                        },
                        new
                        {
                            Id = 3L,
                            DateCreated = new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(1847),
                            EmployeeId = 1L,
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 3L,
                            RowId = new Guid("2ce61276-04aa-47fd-8237-004ec42b9115")
                        },
                        new
                        {
                            Id = 4L,
                            DateCreated = new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(1848),
                            EmployeeId = 2L,
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 1L,
                            RowId = new Guid("fb7c5a46-9def-4520-bc16-2e0c42b29f63")
                        },
                        new
                        {
                            Id = 5L,
                            DateCreated = new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(1850),
                            EmployeeId = 2L,
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 2L,
                            RowId = new Guid("745f0080-4630-4fba-a959-4ab7b4d61f64")
                        },
                        new
                        {
                            Id = 6L,
                            DateCreated = new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(1851),
                            EmployeeId = 2L,
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 3L,
                            RowId = new Guid("84850a6d-74d8-4766-89b8-47bbd7ec9c64")
                        },
                        new
                        {
                            Id = 7L,
                            DateCreated = new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(1854),
                            EmployeeId = 2L,
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 4L,
                            RowId = new Guid("37c33866-a754-4c35-b3e7-1a40fb8105ec")
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
                            DateCreated = new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(632),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Travel",
                            RowId = new Guid("fc95c8db-48b7-498e-9f7a-d7af02e7e9f8")
                        },
                        new
                        {
                            Id = 2L,
                            DateCreated = new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(647),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Local",
                            RowId = new Guid("5a94b925-6627-4dc4-b78b-bab76270cc83")
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
                            DateCreated = new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(1753),
                            DateRequested = new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(1757),
                            EmployeeId = 1L,
                            EndDate = new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 1L,
                            RequestComments = "Vacation leave",
                            RowId = new Guid("ec33e875-5b22-4214-a7bf-b9d57f8df666"),
                            StartDate = new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2L,
                            Approved = false,
                            Cancelled = true,
                            DateCreated = new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(1759),
                            DateRequested = new DateTime(2023, 9, 1, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(1761),
                            EmployeeId = 1L,
                            EndDate = new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 2L,
                            RequestComments = "Sick leave",
                            RowId = new Guid("22b267d2-3243-437e-bf58-5bd197064aa0"),
                            StartDate = new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3L,
                            Approved = true,
                            Cancelled = false,
                            DateCreated = new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(1771),
                            DateRequested = new DateTime(2023, 8, 27, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(1772),
                            EmployeeId = 1L,
                            EndDate = new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 3L,
                            RequestComments = "Study leave",
                            RowId = new Guid("39630f6e-708f-4f0f-83a3-50a51eed54c6"),
                            StartDate = new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10L,
                            Approved = true,
                            Cancelled = false,
                            DateCreated = new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(1774),
                            DateRequested = new DateTime(2023, 8, 22, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(1775),
                            EmployeeId = 1L,
                            EndDate = new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 1L,
                            RequestComments = "Holiday leave",
                            RowId = new Guid("78fb96ed-e90b-4307-9e68-2ee0e0334e0e"),
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
                            DateCreated = new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(776),
                            DefaultDays = 10,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Sick Leave",
                            RowId = new Guid("0d3bbfeb-9fa0-4672-ad48-a5258bc71d93")
                        },
                        new
                        {
                            Id = 2L,
                            DateCreated = new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(778),
                            DefaultDays = 20,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Annual Leave",
                            RowId = new Guid("98b517cf-004c-4118-97cc-bc66e5558ef9")
                        },
                        new
                        {
                            Id = 3L,
                            DateCreated = new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(793),
                            DefaultDays = 15,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Study Leave",
                            RowId = new Guid("33339f97-a6c7-4989-9e6d-543c61fd1fbf")
                        },
                        new
                        {
                            Id = 4L,
                            DateCreated = new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(794),
                            DefaultDays = 90,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Maternal Leave",
                            RowId = new Guid("79adbfc9-b0b6-4f2b-b5fa-8d77f4c1678c")
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
                            DateCreated = new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(854),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "admin",
                            RowId = new Guid("1d3d7bec-d2c3-44a2-ad04-d9d7556addd9")
                        },
                        new
                        {
                            Id = 2L,
                            DateCreated = new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(856),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "employee",
                            RowId = new Guid("fc282608-5093-4266-ad89-a20e5a340bb2")
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
                            DateCreated = new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(1661),
                            Email = "ali.mushtaq@example.com",
                            FirstName = "Ali",
                            IsActive = true,
                            IsDeleted = false,
                            IsEmailConfirmed = true,
                            LastName = "Mushtaq",
                            Password = "sTqk3XRhvv9XejHhEKV0NGdW6ZrkDfls4x+9AwrB6TE=",
                            RoleId = 1L,
                            RowId = new Guid("e5d3ad91-7d3d-4ee4-a63e-5dbabff3df02"),
                            UserName = "alimushtaq"
                        },
                        new
                        {
                            Id = 2L,
                            DateCreated = new DateTime(2023, 9, 6, 6, 58, 54, 694, DateTimeKind.Local).AddTicks(1664),
                            Email = "junaid.mushtaq@example.com",
                            FirstName = "Junaid",
                            IsActive = true,
                            IsDeleted = false,
                            IsEmailConfirmed = true,
                            LastName = "Mushtaq",
                            Password = "sTqk3XRhvv9XejHhEKV0NGdW6ZrkDfls4x+9AwrB6TE=",
                            RoleId = 2L,
                            RowId = new Guid("21c931dc-392e-4e24-a4df-ac0e69999bc0"),
                            UserName = "junaidmushtaq"
                        });
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
