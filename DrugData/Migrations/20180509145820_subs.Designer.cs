﻿// <auto-generated />
using System;
using DrugData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DrugData.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180509145820_subs")]
    partial class subs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rc1-32029")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DrugData.Models.Cart", b =>
                {
                    b.Property<Guid>("CartId")
                        .ValueGeneratedOnAdd();

                    b.HasKey("CartId");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("DrugData.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int?>("CountryId");

                    b.Property<int>("PostCode");

                    b.HasKey("CityId");

                    b.HasIndex("CountryId");

                    b.ToTable("City");
                });

            modelBuilder.Entity("DrugData.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<int?>("DrugId");

                    b.Property<string>("UserId");

                    b.HasKey("CommentId");

                    b.HasIndex("DrugId");

                    b.HasIndex("UserId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("DrugData.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("CountryId");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("DrugData.Models.Currency", b =>
                {
                    b.Property<int>("CurrencyId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CurrencyName")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.HasKey("CurrencyId");

                    b.ToTable("Currency");
                });

            modelBuilder.Entity("DrugData.Models.Disease", b =>
                {
                    b.Property<int>("DiseaseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiseaseName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("ICD")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.HasKey("DiseaseId");

                    b.ToTable("Disease");
                });

            modelBuilder.Entity("DrugData.Models.DrugCart", b =>
                {
                    b.Property<int>("DrugCartId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid?>("CartId");

                    b.Property<int?>("DrugId");

                    b.Property<int>("Quantity");

                    b.HasKey("DrugCartId");

                    b.HasIndex("CartId");

                    b.HasIndex("DrugId");

                    b.ToTable("DrugCart");
                });

            modelBuilder.Entity("DrugData.Models.DrugDisease", b =>
                {
                    b.Property<int>("DrugDiseaseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DiseaseId");

                    b.Property<int?>("DrugId");

                    b.HasKey("DrugDiseaseId");

                    b.HasIndex("DiseaseId");

                    b.HasIndex("DrugId");

                    b.ToTable("DrugDisease");
                });

            modelBuilder.Entity("DrugData.Models.DrugSideEffect", b =>
                {
                    b.Property<int>("DrugSideEffectId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DrugId");

                    b.Property<int?>("SideEffectId");

                    b.HasKey("DrugSideEffectId");

                    b.HasIndex("DrugId");

                    b.HasIndex("SideEffectId");

                    b.ToTable("DrugSideEffect");
                });

            modelBuilder.Entity("DrugData.Models.Manufacturer", b =>
                {
                    b.Property<int>("ManufacturerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("About");

                    b.Property<string>("ManufacturerName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("ManufacturerId");

                    b.ToTable("Manufacturer");
                });

            modelBuilder.Entity("DrugData.Models.Medication", b =>
                {
                    b.Property<int>("DrugId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CurrancyCurrencyId");

                    b.Property<DateTime>("DateExpires");

                    b.Property<DateTime>("DateProduced");

                    b.Property<string>("DrugName");

                    b.Property<string>("DrugSize");

                    b.Property<int>("ManufacturerId");

                    b.Property<int?>("MedicationDrugId");

                    b.Property<int?>("PackageId");

                    b.Property<string>("PackageSize");

                    b.Property<decimal>("Price");

                    b.Property<int>("Quantity");

                    b.Property<string>("Usage");

                    b.HasKey("DrugId");

                    b.HasIndex("CurrancyCurrencyId");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("MedicationDrugId");

                    b.HasIndex("PackageId");

                    b.ToTable("Drug");
                });

            modelBuilder.Entity("DrugData.Models.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body");

                    b.Property<DateTime>("MessageDate");

                    b.Property<string>("ReceiverId");

                    b.Property<string>("SenderId");

                    b.HasKey("MessageId");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderId");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("DrugData.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("OrderDate");

                    b.Property<decimal>("PriceSum");

                    b.Property<string>("UserId");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("DrugData.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<int?>("DrugId");

                    b.Property<int?>("OrderId");

                    b.Property<decimal>("Price");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("DrugId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("DrugData.Models.Package", b =>
                {
                    b.Property<int>("PackageId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PackageType")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("PackageId");

                    b.ToTable("Package");
                });

            modelBuilder.Entity("DrugData.Models.SideEffect", b =>
                {
                    b.Property<int>("SideEffectId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SideEffectName");

                    b.HasKey("SideEffectId");

                    b.ToTable("SideEffect");
                });

            modelBuilder.Entity("DrugData.Models.Specialization", b =>
                {
                    b.Property<int>("SpecializationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SpecializationName");

                    b.HasKey("SpecializationId");

                    b.ToTable("Specialization");
                });

            modelBuilder.Entity("DrugData.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<int?>("CityId");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("IsAdmin");

                    b.Property<bool>("IsDoctor");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("Surname");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<DateTime>("UserDate");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("DrugData.Models.Doctor", b =>
                {
                    b.HasBaseType("DrugData.Models.User");

                    b.Property<string>("Biography");

                    b.Property<string>("Education");

                    b.Property<int?>("SpecializationId");

                    b.Property<string>("Title");

                    b.HasIndex("SpecializationId");

                    b.ToTable("Doctor");

                    b.HasDiscriminator().HasValue("Doctor");
                });

            modelBuilder.Entity("DrugData.Models.City", b =>
                {
                    b.HasOne("DrugData.Models.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId");
                });

            modelBuilder.Entity("DrugData.Models.Comment", b =>
                {
                    b.HasOne("DrugData.Models.Medication", "Drug")
                        .WithMany("Comments")
                        .HasForeignKey("DrugId");

                    b.HasOne("DrugData.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("DrugData.Models.DrugCart", b =>
                {
                    b.HasOne("DrugData.Models.Cart", "Cart")
                        .WithMany("DrugCarts")
                        .HasForeignKey("CartId");

                    b.HasOne("DrugData.Models.Medication", "Drug")
                        .WithMany("DrugCarts")
                        .HasForeignKey("DrugId");
                });

            modelBuilder.Entity("DrugData.Models.DrugDisease", b =>
                {
                    b.HasOne("DrugData.Models.Disease", "Disease")
                        .WithMany("DrugDiseases")
                        .HasForeignKey("DiseaseId");

                    b.HasOne("DrugData.Models.Medication", "Drug")
                        .WithMany("DrugDiseases")
                        .HasForeignKey("DrugId");
                });

            modelBuilder.Entity("DrugData.Models.DrugSideEffect", b =>
                {
                    b.HasOne("DrugData.Models.Medication", "Drug")
                        .WithMany("DrugSideEffects")
                        .HasForeignKey("DrugId");

                    b.HasOne("DrugData.Models.SideEffect", "SideEffect")
                        .WithMany("DrugSideEffect")
                        .HasForeignKey("SideEffectId");
                });

            modelBuilder.Entity("DrugData.Models.Medication", b =>
                {
                    b.HasOne("DrugData.Models.Currency", "Currancy")
                        .WithMany()
                        .HasForeignKey("CurrancyCurrencyId");

                    b.HasOne("DrugData.Models.Manufacturer", "Manufacturer")
                        .WithMany("Drugs")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DrugData.Models.Medication")
                        .WithMany("Substitutions")
                        .HasForeignKey("MedicationDrugId");

                    b.HasOne("DrugData.Models.Package", "Package")
                        .WithMany("Drugs")
                        .HasForeignKey("PackageId");
                });

            modelBuilder.Entity("DrugData.Models.Message", b =>
                {
                    b.HasOne("DrugData.Models.User", "Receiver")
                        .WithMany()
                        .HasForeignKey("ReceiverId");

                    b.HasOne("DrugData.Models.User", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId");
                });

            modelBuilder.Entity("DrugData.Models.Order", b =>
                {
                    b.HasOne("DrugData.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("DrugData.Models.OrderDetail", b =>
                {
                    b.HasOne("DrugData.Models.Medication", "Drug")
                        .WithMany()
                        .HasForeignKey("DrugId");

                    b.HasOne("DrugData.Models.Order", "Order")
                        .WithMany("OrderLines")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("DrugData.Models.User", b =>
                {
                    b.HasOne("DrugData.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DrugData.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DrugData.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DrugData.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DrugData.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DrugData.Models.Doctor", b =>
                {
                    b.HasOne("DrugData.Models.Specialization", "Specialization")
                        .WithMany("Doctors")
                        .HasForeignKey("SpecializationId");
                });
#pragma warning restore 612, 618
        }
    }
}
