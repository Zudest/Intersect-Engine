﻿// <auto-generated />
using System;
using Intersect.Server.Database.PlayerData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Intersect.Server.Migrations
{
    [DbContext(typeof(PlayerContext))]
    partial class PlayerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065");

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Api.RefreshToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ClientId");

                    b.Property<DateTime>("Expires");

                    b.Property<DateTime>("Issued");

                    b.Property<string>("Subject")
                        .IsRequired();

                    b.Property<string>("Ticket")
                        .IsRequired();

                    b.Property<Guid>("TicketId");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Ban", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Banner");

                    b.Property<DateTime>("EndTime");

                    b.Property<string>("Ip");

                    b.Property<string>("Reason");

                    b.Property<DateTime>("StartTime");

                    b.Property<Guid>("UserId")
                        .HasColumnName("PlayerId");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Bans");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Mute", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EndTime");

                    b.Property<string>("Ip");

                    b.Property<string>("Muter");

                    b.Property<string>("Reason");

                    b.Property<DateTime>("StartTime");

                    b.Property<Guid>("UserId")
                        .HasColumnName("PlayerId");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Mutes");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.Bag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("SlotCount");

                    b.HasKey("Id");

                    b.ToTable("Bags");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.BagSlot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("BagId");

                    b.Property<Guid>("ItemId");

                    b.Property<string>("ItemPropertiesJson")
                        .HasColumnName("ItemProperties");

                    b.Property<Guid>("ParentBagId");

                    b.Property<int>("Quantity");

                    b.Property<int>("Slot");

                    b.HasKey("Id");

                    b.HasIndex("BagId");

                    b.HasIndex("ParentBagId");

                    b.ToTable("Bag_Items");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.BankSlot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("BagId");

                    b.Property<Guid>("ItemId");

                    b.Property<string>("ItemPropertiesJson")
                        .HasColumnName("ItemProperties");

                    b.Property<Guid>("PlayerId");

                    b.Property<int>("Quantity");

                    b.Property<int>("Slot");

                    b.HasKey("Id");

                    b.HasIndex("BagId");

                    b.HasIndex("PlayerId");

                    b.ToTable("Player_Bank");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.Friend", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("OwnerId");

                    b.Property<Guid?>("TargetId");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("TargetId");

                    b.ToTable("Player_Friends");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.Guild", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BankSlotsCount");

                    b.Property<DateTime>("FoundingDate");

                    b.Property<Guid>("GuildInstanceId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Guilds");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.GuildBankSlot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("BagId");

                    b.Property<Guid>("GuildId");

                    b.Property<Guid>("ItemId");

                    b.Property<string>("ItemPropertiesJson")
                        .HasColumnName("ItemProperties");

                    b.Property<int>("Quantity");

                    b.Property<int>("Slot");

                    b.HasKey("Id");

                    b.HasIndex("BagId");

                    b.HasIndex("GuildId");

                    b.ToTable("Guild_Bank");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.GuildVariable", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("GuildId");

                    b.Property<string>("Json")
                        .HasColumnName("Value");

                    b.Property<Guid>("VariableId");

                    b.HasKey("Id");

                    b.HasIndex("GuildId");

                    b.HasIndex("VariableId", "GuildId")
                        .IsUnique();

                    b.ToTable("Guild_Variables");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.HotbarSlot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("BagId");

                    b.Property<Guid>("ItemOrSpellId");

                    b.Property<Guid>("PlayerId");

                    b.Property<int>("Slot");

                    b.Property<string>("StatBuffsJson")
                        .HasColumnName("PreferredStatBuffs");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("Player_Hotbar");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.InventorySlot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("BagId");

                    b.Property<Guid>("ItemId");

                    b.Property<string>("ItemPropertiesJson")
                        .HasColumnName("ItemProperties");

                    b.Property<Guid>("PlayerId");

                    b.Property<int>("Quantity");

                    b.Property<int>("Slot");

                    b.HasKey("Id");

                    b.HasIndex("BagId");

                    b.HasIndex("PlayerId");

                    b.ToTable("Player_Items");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.PlayerVariable", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Json")
                        .HasColumnName("Value");

                    b.Property<Guid>("PlayerId");

                    b.Property<Guid>("VariableId");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.HasIndex("VariableId", "PlayerId")
                        .IsUnique();

                    b.ToTable("Player_Variables");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.Quest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Completed");

                    b.Property<Guid>("PlayerId");

                    b.Property<Guid>("QuestId");

                    b.Property<Guid>("TaskId");

                    b.Property<int>("TaskProgress");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.HasIndex("QuestId", "PlayerId")
                        .IsUnique();

                    b.ToTable("Player_Quests");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.SkillSlot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("Experience");

                    b.Property<int>("Level");

                    b.Property<Guid>("PlayerId");

                    b.Property<Guid>("SkillId");

                    b.Property<int>("Slot");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("Player_Skills");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.SpellSlot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("PlayerId");

                    b.Property<int>("Slot");

                    b.Property<Guid>("SpellId");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("Player_Spells");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.UserVariable", b =>
                {
                    b.Property<Guid>("VariableId");

                    b.Property<Guid>("UserId");

                    b.Property<string>("Json")
                        .HasColumnName("Value");

                    b.HasKey("VariableId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("User_Variables");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("LastIp");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("PasswordResetCode");

                    b.Property<DateTime?>("PasswordResetTime");

                    b.Property<ulong>("PlayTimeSeconds");

                    b.Property<string>("PowerJson")
                        .HasColumnName("Power");

                    b.Property<DateTime?>("RegistrationDate");

                    b.Property<string>("Salt");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Intersect.Server.Entities.Player", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ClassId");

                    b.Property<DateTime?>("CreationDate");

                    b.Property<Guid?>("DbGuildId");

                    b.Property<int>("Dir");

                    b.Property<string>("EquipmentJson")
                        .HasColumnName("Equipment");

                    b.Property<long>("Exp");

                    b.Property<string>("Face");

                    b.Property<string>("FooterLabelJson")
                        .HasColumnName("FooterLabel");

                    b.Property<int>("Gender");

                    b.Property<DateTime>("GuildJoinDate");

                    b.Property<int>("GuildRank");

                    b.Property<string>("HeaderLabelJson")
                        .HasColumnName("HeaderLabel");

                    b.Property<int>("InstanceType");

                    b.Property<string>("ItemCooldownsJson")
                        .HasColumnName("ItemCooldowns");

                    b.Property<string>("JsonColor")
                        .HasColumnName("Color");

                    b.Property<DateTime?>("LastOnline");

                    b.Property<Guid>("LastOverworldMapId")
                        .HasColumnName("LastOverworldMapId");

                    b.Property<int>("LastOverworldX");

                    b.Property<int>("LastOverworldY");

                    b.Property<int>("Level");

                    b.Property<Guid>("MapId");

                    b.Property<string>("Name");

                    b.Property<string>("NameColorJson")
                        .HasColumnName("NameColor");

                    b.Property<Guid>("PersonalMapInstanceId");

                    b.Property<ulong>("PlayTimeSeconds");

                    b.Property<int>("SharedInstanceRespawnDir");

                    b.Property<Guid>("SharedInstanceRespawnId")
                        .HasColumnName("SharedInstanceRespawnId");

                    b.Property<int>("SharedInstanceRespawnX");

                    b.Property<int>("SharedInstanceRespawnY");

                    b.Property<Guid>("SharedMapInstanceId");

                    b.Property<string>("SpellCooldownsJson")
                        .HasColumnName("SpellCooldowns");

                    b.Property<string>("Sprite");

                    b.Property<int>("StatPoints");

                    b.Property<string>("StatPointsJson")
                        .HasColumnName("StatPointAllocations");

                    b.Property<string>("StatsJson")
                        .HasColumnName("BaseStats");

                    b.Property<Guid>("UserId");

                    b.Property<string>("VitalsJson")
                        .HasColumnName("Vitals");

                    b.Property<int>("X");

                    b.Property<int>("Y");

                    b.Property<int>("Z");

                    b.HasKey("Id");

                    b.HasIndex("DbGuildId");

                    b.HasIndex("UserId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Api.RefreshToken", b =>
                {
                    b.HasOne("Intersect.Server.Database.PlayerData.User", "User")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Ban", b =>
                {
                    b.HasOne("Intersect.Server.Database.PlayerData.User", "User")
                        .WithOne("Ban")
                        .HasForeignKey("Intersect.Server.Database.PlayerData.Ban", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Mute", b =>
                {
                    b.HasOne("Intersect.Server.Database.PlayerData.User", "User")
                        .WithOne("Mute")
                        .HasForeignKey("Intersect.Server.Database.PlayerData.Mute", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.BagSlot", b =>
                {
                    b.HasOne("Intersect.Server.Database.PlayerData.Players.Bag", "Bag")
                        .WithMany()
                        .HasForeignKey("BagId");

                    b.HasOne("Intersect.Server.Database.PlayerData.Players.Bag", "ParentBag")
                        .WithMany("Slots")
                        .HasForeignKey("ParentBagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.BankSlot", b =>
                {
                    b.HasOne("Intersect.Server.Database.PlayerData.Players.Bag", "Bag")
                        .WithMany()
                        .HasForeignKey("BagId");

                    b.HasOne("Intersect.Server.Entities.Player", "Player")
                        .WithMany("Bank")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.Friend", b =>
                {
                    b.HasOne("Intersect.Server.Entities.Player", "Owner")
                        .WithMany("Friends")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Intersect.Server.Entities.Player", "Target")
                        .WithMany()
                        .HasForeignKey("TargetId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.GuildBankSlot", b =>
                {
                    b.HasOne("Intersect.Server.Database.PlayerData.Players.Bag", "Bag")
                        .WithMany()
                        .HasForeignKey("BagId");

                    b.HasOne("Intersect.Server.Database.PlayerData.Players.Guild", "Guild")
                        .WithMany("Bank")
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.GuildVariable", b =>
                {
                    b.HasOne("Intersect.Server.Database.PlayerData.Players.Guild", "Guild")
                        .WithMany("Variables")
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.HotbarSlot", b =>
                {
                    b.HasOne("Intersect.Server.Entities.Player", "Player")
                        .WithMany("Hotbar")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.InventorySlot", b =>
                {
                    b.HasOne("Intersect.Server.Database.PlayerData.Players.Bag", "Bag")
                        .WithMany()
                        .HasForeignKey("BagId");

                    b.HasOne("Intersect.Server.Entities.Player", "Player")
                        .WithMany("Items")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.PlayerVariable", b =>
                {
                    b.HasOne("Intersect.Server.Entities.Player", "Player")
                        .WithMany("Variables")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.Quest", b =>
                {
                    b.HasOne("Intersect.Server.Entities.Player", "Player")
                        .WithMany("Quests")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.SkillSlot", b =>
                {
                    b.HasOne("Intersect.Server.Entities.Player", "Player")
                        .WithMany("Skills")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.SpellSlot", b =>
                {
                    b.HasOne("Intersect.Server.Entities.Player", "Player")
                        .WithMany("Spells")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Intersect.Server.Database.PlayerData.Players.UserVariable", b =>
                {
                    b.HasOne("Intersect.Server.Database.PlayerData.User", "User")
                        .WithMany("Variables")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Intersect.Server.Entities.Player", b =>
                {
                    b.HasOne("Intersect.Server.Database.PlayerData.Players.Guild", "DbGuild")
                        .WithMany()
                        .HasForeignKey("DbGuildId");

                    b.HasOne("Intersect.Server.Database.PlayerData.User", "User")
                        .WithMany("Players")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
