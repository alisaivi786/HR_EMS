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
    [Migration("20230904060517_addGenderIdColumn")]
    partial class addGenderIdColumn
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

                    b.Property<string>("ResponseHeaders")
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
                            DateCreated = new DateTime(2023, 9, 4, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(2834),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Travel",
                            RowId = new Guid("9a82969e-f7c1-4463-bc04-533e7d116cf2")
                        },
                        new
                        {
                            Id = 2L,
                            DateCreated = new DateTime(2023, 9, 4, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(2868),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Local",
                            RowId = new Guid("e1949670-9e8d-4713-88cd-5e85f431682a")
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
                            DateCreated = new DateTime(2023, 9, 4, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(4434),
                            DateRequested = new DateTime(2023, 9, 4, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(4443),
                            EmployeeId = 1L,
                            EndDate = new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 1L,
                            RequestComments = "Vacation leave",
                            RowId = new Guid("8fdb9530-a87d-4f20-886d-740c52a17f65"),
                            StartDate = new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2L,
                            Approved = false,
                            Cancelled = true,
                            DateCreated = new DateTime(2023, 9, 4, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(4447),
                            DateRequested = new DateTime(2023, 8, 30, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(4449),
                            EmployeeId = 1L,
                            EndDate = new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 2L,
                            RequestComments = "Sick leave",
                            RowId = new Guid("76a6c16e-5835-4f3e-b7ac-2f240849fd9f"),
                            StartDate = new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3L,
                            Approved = true,
                            Cancelled = false,
                            DateCreated = new DateTime(2023, 9, 4, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(4456),
                            DateRequested = new DateTime(2023, 8, 25, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(4458),
                            EmployeeId = 1L,
                            EndDate = new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 3L,
                            RequestComments = "Study leave",
                            RowId = new Guid("5fe7f10b-5254-4f2e-b8fe-146daa9b1106"),
                            StartDate = new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10L,
                            Approved = true,
                            Cancelled = false,
                            DateCreated = new DateTime(2023, 9, 4, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(4461),
                            DateRequested = new DateTime(2023, 8, 20, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(4462),
                            EmployeeId = 1L,
                            EndDate = new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsActive = true,
                            IsDeleted = false,
                            LeaveTypeId = 1L,
                            RequestComments = "Holiday leave",
                            RowId = new Guid("0233e006-7f7b-460a-9b68-fb259f85a6fb"),
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
                            DateCreated = new DateTime(2023, 9, 4, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(3111),
                            DefaultDays = 10,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Sick Leave",
                            RowId = new Guid("91f3bbb4-7dd0-4b30-9be7-ed7035c508a6")
                        },
                        new
                        {
                            Id = 2L,
                            DateCreated = new DateTime(2023, 9, 4, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(3115),
                            DefaultDays = 20,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Annual Leave",
                            RowId = new Guid("a925af0e-7117-40de-abb2-637ca988636b")
                        },
                        new
                        {
                            Id = 3L,
                            DateCreated = new DateTime(2023, 9, 4, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(3117),
                            DefaultDays = 15,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Study Leave",
                            RowId = new Guid("5438a93f-715a-49ce-83d2-31dbada059e6")
                        },
                        new
                        {
                            Id = 4L,
                            DateCreated = new DateTime(2023, 9, 4, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(3119),
                            DefaultDays = 90,
                            IsActive = true,
                            IsDeleted = false,
                            Name = "Maternal Leave",
                            RowId = new Guid("bb9e9030-107b-4c45-b470-4e6d23c42138")
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
                            DateCreated = new DateTime(2023, 9, 4, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(3208),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "admin",
                            RowId = new Guid("e309e97c-ee26-484e-aeae-0468aeb9d7f1")
                        },
                        new
                        {
                            Id = 2L,
                            DateCreated = new DateTime(2023, 9, 4, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(3210),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "employee",
                            RowId = new Guid("a6d2b94c-7fe8-4fed-ae82-0a494d08b3db")
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
                            DateCreated = new DateTime(2023, 9, 4, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(4312),
                            Email = "ali.mushtaq@example.com",
                            FirstName = "Ali",
                            IsActive = true,
                            IsDeleted = false,
                            IsEmailConfirmed = true,
                            LastName = "Mushtaq",
                            Password = "sTqk3XRhvv9XejHhEKV0NGdW6ZrkDfls4x+9AwrB6TE=",
                            RoleId = 1L,
                            RowId = new Guid("986317c5-075b-4ff1-858a-5ce55d19ab4b"),
                            UserName = "alimushtaq"
                        },
                        new
                        {
                            Id = 2L,
                            DateCreated = new DateTime(2023, 9, 4, 10, 5, 17, 406, DateTimeKind.Local).AddTicks(4322),
                            Email = "junaid.mushtaq@example.com",
                            FirstName = "Junaid",
                            IsActive = true,
                            IsDeleted = false,
                            IsEmailConfirmed = true,
                            LastName = "Mushtaq",
                            Password = "sTqk3XRhvv9XejHhEKV0NGdW6ZrkDfls4x+9AwrB6TE=",
                            RoleId = 2L,
                            RowId = new Guid("c91bc449-fa03-474e-8276-23de441c3b86"),
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