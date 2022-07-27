﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220727013854_RobotCardDamageStringAttempt")]
    partial class RobotCardDamageStringAttempt
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.4");

            modelBuilder.Entity("API.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("Interests")
                        .HasColumnType("TEXT");

                    b.Property<string>("Introduction")
                        .HasColumnType("TEXT");

                    b.Property<string>("KnownAs")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastActive")
                        .HasColumnType("TEXT");

                    b.Property<string>("LookingFor")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("BLOB");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("API.Entities.Build", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BuildOwnerId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ChosenPilotAbilityId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ChosenPilotId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ChosenRobotId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BuildOwnerId");

                    b.HasIndex("ChosenPilotAbilityId");

                    b.HasIndex("ChosenPilotId");

                    b.HasIndex("ChosenRobotId");

                    b.ToTable("Builds");
                });

            modelBuilder.Entity("API.Entities.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AppUserId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsMain")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PublicId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("API.Entities.Pilot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Heart")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MainImage")
                        .HasColumnType("TEXT");

                    b.Property<int>("MaxFightingSpirit")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Power")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Rage")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Pilot");
                });

            modelBuilder.Entity("API.Entities.PilotAbility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("LogoImage")
                        .HasColumnType("TEXT");

                    b.Property<string>("MainArtImage")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("PilotId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Rules")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("PilotAbility");
                });

            modelBuilder.Entity("API.Entities.PilotCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BuildId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cooldown")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CooldownImage")
                        .HasColumnType("TEXT");

                    b.Property<int>("Cost")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DiceImage")
                        .HasColumnType("TEXT");

                    b.Property<string>("LogoImage")
                        .HasColumnType("TEXT");

                    b.Property<string>("MainArtImage")
                        .HasColumnType("TEXT");

                    b.Property<int>("MaxRange")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MinRange")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("PilotId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Requirements")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rules")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.Property<string>("TypeImage")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BuildId");

                    b.ToTable("PilotCard");
                });

            modelBuilder.Entity("API.Entities.Robot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Defence")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaxArmour")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Speed")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Robot");
                });

            modelBuilder.Entity("API.Entities.RobotAbility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BuildId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LogoImage")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("PowerTokens")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RobotId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Rules")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BuildId");

                    b.ToTable("RobotAbility");
                });

            modelBuilder.Entity("API.Entities.RobotCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AttackDice")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BaseDamage")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BuildId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CardType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ComboImage")
                        .HasColumnType("TEXT");

                    b.Property<int>("Cooldown")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CooldownImage")
                        .HasColumnType("TEXT");

                    b.Property<int>("Cost")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CounterImage")
                        .HasColumnType("TEXT");

                    b.Property<string>("DamageImage")
                        .HasColumnType("TEXT");

                    b.Property<string>("DamageString")
                        .HasColumnType("TEXT");

                    b.Property<string>("DiceImage")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsUltimate")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LogoImage")
                        .HasColumnType("TEXT");

                    b.Property<string>("MainArtImage")
                        .HasColumnType("TEXT");

                    b.Property<int>("MaxRange")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MinRange")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Requirements")
                        .HasColumnType("TEXT");

                    b.Property<int>("RobotId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Rules")
                        .HasColumnType("TEXT");

                    b.Property<string>("SubType")
                        .HasColumnType("TEXT");

                    b.Property<string>("TypeImage")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BuildId");

                    b.ToTable("RobotCard");
                });

            modelBuilder.Entity("API.Entities.Build", b =>
                {
                    b.HasOne("API.Entities.AppUser", "BuildOwner")
                        .WithMany("UserBuilds")
                        .HasForeignKey("BuildOwnerId");

                    b.HasOne("API.Entities.PilotAbility", "ChosenPilotAbility")
                        .WithMany()
                        .HasForeignKey("ChosenPilotAbilityId");

                    b.HasOne("API.Entities.Pilot", "ChosenPilot")
                        .WithMany()
                        .HasForeignKey("ChosenPilotId");

                    b.HasOne("API.Entities.Robot", "ChosenRobot")
                        .WithMany()
                        .HasForeignKey("ChosenRobotId");

                    b.Navigation("BuildOwner");

                    b.Navigation("ChosenPilot");

                    b.Navigation("ChosenPilotAbility");

                    b.Navigation("ChosenRobot");
                });

            modelBuilder.Entity("API.Entities.Photo", b =>
                {
                    b.HasOne("API.Entities.AppUser", "AppUser")
                        .WithMany("Photos")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("API.Entities.PilotCard", b =>
                {
                    b.HasOne("API.Entities.Build", null)
                        .WithMany("PilotCardList")
                        .HasForeignKey("BuildId");
                });

            modelBuilder.Entity("API.Entities.RobotAbility", b =>
                {
                    b.HasOne("API.Entities.Build", null)
                        .WithMany("RobotAbilityList")
                        .HasForeignKey("BuildId");
                });

            modelBuilder.Entity("API.Entities.RobotCard", b =>
                {
                    b.HasOne("API.Entities.Build", null)
                        .WithMany("RobotCardList")
                        .HasForeignKey("BuildId");
                });

            modelBuilder.Entity("API.Entities.AppUser", b =>
                {
                    b.Navigation("Photos");

                    b.Navigation("UserBuilds");
                });

            modelBuilder.Entity("API.Entities.Build", b =>
                {
                    b.Navigation("PilotCardList");

                    b.Navigation("RobotAbilityList");

                    b.Navigation("RobotCardList");
                });
#pragma warning restore 612, 618
        }
    }
}
