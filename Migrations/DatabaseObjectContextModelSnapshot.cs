﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VarnishMixApp;

namespace VarnishMixApp.Migrations
{
    [DbContext(typeof(DatabaseObjectContext))]
    partial class DatabaseObjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<decimal>("DryOffTime")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Layer")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("LayerThickness")
                        .HasColumnType("TEXT");

                    b.Property<int>("additionalProductType")
                        .HasColumnType("INTEGER");

                    b.HasKey("AdditionalProductId");

                    b.ToTable("AdditionalProducts");
                });

            modelBuilder.Entity("VarnishMixApp.BaseProduct", b =>
                {
                    b.Property<int>("BaseProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BaseProductName")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("DryOffTime")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Layer")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("LayerThickness")
                        .HasColumnType("TEXT");

                    b.Property<int>("baseProductType")
                        .HasColumnType("INTEGER");

                    b.HasKey("BaseProductId");

                    b.ToTable("BaseProducts");
                });

            modelBuilder.Entity("VarnishMixApp.ProductProportion", b =>
                {
                    b.Property<int>("ProductProportionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AdditionalProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BaseProductId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("DivisionProportion")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PercentProportion")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("WeightProportion")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductProportionId");

                    b.HasIndex("AdditionalProductId");

                    b.HasIndex("BaseProductId");

                    b.ToTable("ProductPropotions");
                });

            modelBuilder.Entity("VarnishMixApp.ProductProportion", b =>
                {
                    b.HasOne("VarnishMixApp.AdditionalProduct", "AdditionalProduct")
                        .WithMany("ProductProportions")
                        .HasForeignKey("AdditionalProductId");

                    b.HasOne("VarnishMixApp.BaseProduct", "BaseProduct")
                        .WithMany("ProductProportions")
                        .HasForeignKey("BaseProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
