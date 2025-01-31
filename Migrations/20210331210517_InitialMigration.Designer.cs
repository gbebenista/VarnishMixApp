﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VarnishMixApp;

namespace VarnishMixApp.Migrations
{
    [DbContext(typeof(DatabaseObjectContext))]
    [Migration("20210331210517_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12");

            modelBuilder.Entity("VarnishMixApp.AdditionalProduct", b =>
                {
                    b.Property<int>("AdditionalProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AdditionalProductName")
                        .HasColumnType("TEXT");

                    b.Property<int>("additionalProductType")
                        .HasColumnType("INTEGER");

                    b.HasKey("AdditionalProductId");

                    b.ToTable("AdditionalProducts");
                });

            modelBuilder.Entity("VarnishMixApp.AdditionalProductInsertedByUser", b =>
                {
                    b.Property<int>("AdditionalProductInsertedByUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AdditionalProductId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AdditionalProductInsertedByUserId");

                    b.HasIndex("AdditionalProductId");

                    b.ToTable("AdditionalProductInsertedByUser");
                });

            modelBuilder.Entity("VarnishMixApp.BaseProduct", b =>
                {
                    b.Property<int>("BaseProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BaseProductName")
                        .HasColumnType("TEXT");

                    b.Property<int>("BaseProductType")
                        .HasColumnType("INTEGER");

                    b.HasKey("BaseProductId");

                    b.ToTable("BaseProducts");
                });

            modelBuilder.Entity("VarnishMixApp.BaseProductInsertedByUser", b =>
                {
                    b.Property<int>("BaseProductInsertedByUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BaseProductId")
                        .HasColumnType("INTEGER");

                    b.HasKey("BaseProductInsertedByUserId");

                    b.HasIndex("BaseProductId");

                    b.ToTable("BaseProductInsertedByUser");
                });

            modelBuilder.Entity("VarnishMixApp.ProductProportion", b =>
                {
                    b.Property<int>("ProductProportionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AdditionalProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BaseProductId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("DivisionProportion")
                        .HasColumnType("decimal(5, 2)");

                    b.Property<int>("IsConstrainted")
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("PercentProportion")
                        .HasColumnType("decimal(5, 2)");

                    b.Property<decimal?>("WeightProportion")
                        .HasColumnType("decimal(5, 2)");

                    b.HasKey("ProductProportionId");

                    b.HasIndex("AdditionalProductId");

                    b.HasIndex("BaseProductId");

                    b.ToTable("ProductPropotions");
                });

            modelBuilder.Entity("VarnishMixApp.AdditionalProductInsertedByUser", b =>
                {
                    b.HasOne("VarnishMixApp.AdditionalProduct", "AdditionalProduct")
                        .WithMany("AdditionalProductInsertedByUsers")
                        .HasForeignKey("AdditionalProductId");
                });

            modelBuilder.Entity("VarnishMixApp.BaseProductInsertedByUser", b =>
                {
                    b.HasOne("VarnishMixApp.BaseProduct", "BaseProduct")
                        .WithMany("BaseProductInsertedByUsers")
                        .HasForeignKey("BaseProductId");
                });

            modelBuilder.Entity("VarnishMixApp.ProductProportion", b =>
                {
                    b.HasOne("VarnishMixApp.AdditionalProduct", "AdditionalProduct")
                        .WithMany("ProductProportions")
                        .HasForeignKey("AdditionalProductId");

                    b.HasOne("VarnishMixApp.BaseProduct", "BaseProduct")
                        .WithMany("ProductProportions")
                        .HasForeignKey("BaseProductId");
                });
#pragma warning restore 612, 618
        }
    }
}
