﻿// <auto-generated />
using System;
using Fragment.NetSlum.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Fragment.NetSlum.Persistence.Migrations
{
    [DbContext(typeof(FragmentContext))]
    [Migration("20230602203751_Guilds")]
    partial class Guilds
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Fragment.NetSlum.Persistence.Entities.AreaServerCategory", b =>
                {
                    b.Property<ushort>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint unsigned")
                        .HasColumnName("id");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("category_name");

                    b.HasKey("Id")
                        .HasName("pk_area_server_categories");

                    b.ToTable("area_server_categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = (ushort)1,
                            CategoryName = "Main"
                        },
                        new
                        {
                            Id = (ushort)2,
                            CategoryName = "Test"
                        });
                });

            modelBuilder.Entity("Fragment.NetSlum.Persistence.Entities.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("CharacterName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("character_name")
                        .UseCollation("sjis_japanese_ci");

                    MySqlPropertyBuilderExtensions.HasCharSet(b.Property<string>("CharacterName"), "sjis");

                    b.Property<byte>("Class")
                        .HasColumnType("tinyint unsigned")
                        .HasColumnName("class");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<int>("CurrentLevel")
                        .HasColumnType("int")
                        .HasColumnName("current_level");

                    b.Property<uint>("FullModelId")
                        .HasColumnType("int unsigned")
                        .HasColumnName("full_model_id");

                    b.Property<string>("GreetingMessage")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("greeting_message")
                        .UseCollation("sjis_japanese_ci");

                    MySqlPropertyBuilderExtensions.HasCharSet(b.Property<string>("GreetingMessage"), "sjis");

                    b.Property<ushort?>("GuildId")
                        .HasColumnType("smallint unsigned")
                        .HasColumnName("guild_id");

                    b.Property<DateTime?>("LastLoginAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("last_login_at");

                    b.Property<int>("PlayerAccountId")
                        .HasColumnType("int")
                        .HasColumnName("player_account_id");

                    b.Property<byte>("SaveSlotId")
                        .HasColumnType("tinyint unsigned")
                        .HasColumnName("save_slot_id");

                    b.HasKey("Id")
                        .HasName("pk_characters");

                    b.HasIndex("GuildId")
                        .HasDatabaseName("ix_characters_guild_id");

                    b.HasIndex("PlayerAccountId")
                        .HasDatabaseName("ix_characters_player_account_id");

                    b.ToTable("characters", (string)null);
                });

            modelBuilder.Entity("Fragment.NetSlum.Persistence.Entities.CharacterStatHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("AverageFieldLevel")
                        .HasColumnType("int")
                        .HasColumnName("average_field_level");

                    b.Property<int>("BronzeAmount")
                        .HasColumnType("int")
                        .HasColumnName("bronze_amount");

                    b.Property<int>("CharacterId")
                        .HasColumnType("int")
                        .HasColumnName("character_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<uint>("CurrentGp")
                        .HasColumnType("int unsigned")
                        .HasColumnName("current_gp");

                    b.Property<int>("CurrentHp")
                        .HasColumnType("int")
                        .HasColumnName("current_hp");

                    b.Property<int>("CurrentSp")
                        .HasColumnType("int")
                        .HasColumnName("current_sp");

                    b.Property<int>("GoldAmount")
                        .HasColumnType("int")
                        .HasColumnName("gold_amount");

                    b.Property<int>("OnlineTreasures")
                        .HasColumnType("int")
                        .HasColumnName("online_treasures");

                    b.Property<int>("SilverAmount")
                        .HasColumnType("int")
                        .HasColumnName("silver_amount");

                    b.HasKey("Id")
                        .HasName("pk_character_stat_history");

                    b.HasIndex("CharacterId")
                        .HasDatabaseName("ix_character_stat_history_character_id");

                    b.HasIndex("CreatedAt")
                        .HasDatabaseName("ix_character_stat_history_created_at");

                    b.ToTable("character_stat_history", (string)null);
                });

            modelBuilder.Entity("Fragment.NetSlum.Persistence.Entities.CharacterStats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("AverageFieldLevel")
                        .HasColumnType("int")
                        .HasColumnName("average_field_level");

                    b.Property<int>("BronzeAmount")
                        .HasColumnType("int")
                        .HasColumnName("bronze_amount");

                    b.Property<int>("CharacterId")
                        .HasColumnType("int")
                        .HasColumnName("character_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<uint>("CurrentGp")
                        .HasColumnType("int unsigned")
                        .HasColumnName("current_gp");

                    b.Property<int>("CurrentHp")
                        .HasColumnType("int")
                        .HasColumnName("current_hp");

                    b.Property<int>("CurrentSp")
                        .HasColumnType("int")
                        .HasColumnName("current_sp");

                    b.Property<int>("GoldAmount")
                        .HasColumnType("int")
                        .HasColumnName("gold_amount");

                    b.Property<int>("OnlineTreasures")
                        .HasColumnType("int")
                        .HasColumnName("online_treasures");

                    b.Property<int>("SilverAmount")
                        .HasColumnType("int")
                        .HasColumnName("silver_amount");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_character_stats");

                    b.HasIndex("CharacterId")
                        .IsUnique()
                        .HasDatabaseName("ix_character_stats_character_id");

                    b.HasIndex("UpdatedAt")
                        .HasDatabaseName("ix_character_stats_updated_at");

                    b.ToTable("character_stats", (string)null);
                });

            modelBuilder.Entity("Fragment.NetSlum.Persistence.Entities.ChatLobby", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("ChatLobbyName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("chat_lobby_name")
                        .UseCollation("sjis_japanese_ci");

                    MySqlPropertyBuilderExtensions.HasCharSet(b.Property<string>("ChatLobbyName"), "sjis");

                    b.Property<bool>("DefaultChannel")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("default_channel");

                    b.Property<bool>("GuildLobby")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("guild_lobby");

                    b.Property<bool>("PlayerLobby")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("player_lobby");

                    b.HasKey("Id")
                        .HasName("pk_chat_lobbies");

                    b.ToTable("chat_lobbies", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ChatLobbyName = "Main",
                            DefaultChannel = true,
                            GuildLobby = false,
                            PlayerLobby = false
                        },
                        new
                        {
                            Id = 2,
                            ChatLobbyName = "Main 2",
                            DefaultChannel = true,
                            GuildLobby = false,
                            PlayerLobby = false
                        });
                });

            modelBuilder.Entity("Fragment.NetSlum.Persistence.Entities.Guild", b =>
                {
                    b.Property<ushort>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint unsigned")
                        .HasColumnName("id");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("comment")
                        .UseCollation("sjis_japanese_ci");

                    MySqlPropertyBuilderExtensions.HasCharSet(b.Property<string>("Comment"), "sjis");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<byte[]>("Emblem")
                        .IsRequired()
                        .HasColumnType("longblob")
                        .HasColumnName("emblem");

                    b.Property<int?>("LeaderId")
                        .HasColumnType("int")
                        .HasColumnName("leader_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("name")
                        .UseCollation("sjis_japanese_ci");

                    MySqlPropertyBuilderExtensions.HasCharSet(b.Property<string>("Name"), "sjis");

                    b.HasKey("Id")
                        .HasName("pk_guilds");

                    b.HasIndex("LeaderId")
                        .HasDatabaseName("ix_guilds_leader_id");

                    b.ToTable("guilds", (string)null);
                });

            modelBuilder.Entity("Fragment.NetSlum.Persistence.Entities.GuildStats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("BronzeAmount")
                        .HasColumnType("int")
                        .HasColumnName("bronze_amount");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<int>("CurrentGp")
                        .HasColumnType("int")
                        .HasColumnName("current_gp");

                    b.Property<int>("GoldAmount")
                        .HasColumnType("int")
                        .HasColumnName("gold_amount");

                    b.Property<ushort>("GuildId")
                        .HasColumnType("smallint unsigned")
                        .HasColumnName("guild_id");

                    b.Property<int>("SilverAmount")
                        .HasColumnType("int")
                        .HasColumnName("silver_amount");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_guild_stats");

                    b.HasIndex("GuildId")
                        .IsUnique()
                        .HasDatabaseName("ix_guild_stats_guild_id");

                    b.ToTable("guild_stats", (string)null);
                });

            modelBuilder.Entity("Fragment.NetSlum.Persistence.Entities.PlayerAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("SaveId")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)")
                        .HasColumnName("save_id");

                    b.HasKey("Id")
                        .HasName("pk_player_accounts");

                    b.HasIndex("SaveId")
                        .IsUnique()
                        .HasDatabaseName("ix_player_accounts_save_id");

                    b.ToTable("player_accounts", (string)null);
                });

            modelBuilder.Entity("Fragment.NetSlum.Persistence.Entities.ServerNews", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("content")
                        .UseCollation("sjis_japanese_ci");

                    MySqlPropertyBuilderExtensions.HasCharSet(b.Property<string>("Content"), "sjis");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.HasKey("Id")
                        .HasName("pk_server_news");

                    b.ToTable("server_news", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Welcome to Netslum-Redux!\nCurrent Status:\n- Lobby #GOnline#W!\n- BBS #GOnline#W!\n- Mail #GOnline#W!\n- Guilds #GOnline#W!\n- Ranking #GOnline#W!\n- News #GOnline#W!",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Fragment.NetSlum.Persistence.Entities.WebNewsArticle", b =>
                {
                    b.Property<ushort>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint unsigned")
                        .HasColumnName("id");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(412)
                        .HasColumnType("varchar(412)")
                        .HasColumnName("content")
                        .UseCollation("sjis_japanese_ci");

                    MySqlPropertyBuilderExtensions.HasCharSet(b.Property<string>("Content"), "sjis");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<byte[]>("Image")
                        .HasColumnType("longblob")
                        .HasColumnName("image");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(33)
                        .HasColumnType("varchar(33)")
                        .HasColumnName("title")
                        .UseCollation("sjis_japanese_ci");

                    MySqlPropertyBuilderExtensions.HasCharSet(b.Property<string>("Title"), "sjis");

                    b.Property<ushort?>("WebNewsCategoryId")
                        .HasColumnType("smallint unsigned")
                        .HasColumnName("web_news_category_id");

                    b.HasKey("Id")
                        .HasName("pk_web_news_articles");

                    b.HasIndex("WebNewsCategoryId")
                        .HasDatabaseName("ix_web_news_articles_web_news_category_id");

                    b.ToTable("web_news_articles", (string)null);
                });

            modelBuilder.Entity("Fragment.NetSlum.Persistence.Entities.WebNewsCategory", b =>
                {
                    b.Property<ushort>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint unsigned")
                        .HasColumnName("id");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)")
                        .HasColumnName("category_name")
                        .UseCollation("sjis_japanese_ci");

                    MySqlPropertyBuilderExtensions.HasCharSet(b.Property<string>("CategoryName"), "sjis");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.HasKey("Id")
                        .HasName("pk_web_news_categories");

                    b.ToTable("web_news_categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = (ushort)1,
                            CategoryName = "Netslum News",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Fragment.NetSlum.Persistence.Entities.WebNewsReadLog", b =>
                {
                    b.Property<ushort>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint unsigned")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<int>("PlayerAccountId")
                        .HasColumnType("int")
                        .HasColumnName("player_account_id");

                    b.Property<ushort>("WebNewsArticleId")
                        .HasColumnType("smallint unsigned")
                        .HasColumnName("web_news_article_id");

                    b.HasKey("Id")
                        .HasName("pk_web_news_read_logs");

                    b.HasIndex("PlayerAccountId")
                        .HasDatabaseName("ix_web_news_read_logs_player_account_id");

                    b.HasIndex("WebNewsArticleId")
                        .HasDatabaseName("ix_web_news_read_logs_web_news_article_id");

                    b.ToTable("web_news_read_logs", (string)null);
                });

            modelBuilder.Entity("Fragment.NetSlum.Persistence.Entities.Character", b =>
                {
                    b.HasOne("Fragment.NetSlum.Persistence.Entities.Guild", null)
                        .WithMany("Members")
                        .HasForeignKey("GuildId")
                        .HasConstraintName("fk_characters_guilds_guild_id");

                    b.HasOne("Fragment.NetSlum.Persistence.Entities.PlayerAccount", "PlayerAccount")
                        .WithMany()
                        .HasForeignKey("PlayerAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_characters_player_accounts_player_account_id");

                    b.Navigation("PlayerAccount");
                });

            modelBuilder.Entity("Fragment.NetSlum.Persistence.Entities.CharacterStatHistory", b =>
                {
                    b.HasOne("Fragment.NetSlum.Persistence.Entities.Character", "Character")
                        .WithMany()
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_character_stat_history_characters_character_id");

                    b.Navigation("Character");
                });

            modelBuilder.Entity("Fragment.NetSlum.Persistence.Entities.CharacterStats", b =>
                {
                    b.HasOne("Fragment.NetSlum.Persistence.Entities.Character", "Character")
                        .WithOne("CharacterStats")
                        .HasForeignKey("Fragment.NetSlum.Persistence.Entities.CharacterStats", "CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_character_stats_characters_character_id");

                    b.Navigation("Character");
                });

            modelBuilder.Entity("Fragment.NetSlum.Persistence.Entities.Guild", b =>
                {
                    b.HasOne("Fragment.NetSlum.Persistence.Entities.Character", "Leader")
                        .WithMany()
                        .HasForeignKey("LeaderId")
                        .HasConstraintName("fk_guilds_characters_leader_id");

                    b.Navigation("Leader");
                });

            modelBuilder.Entity("Fragment.NetSlum.Persistence.Entities.GuildStats", b =>
                {
                    b.HasOne("Fragment.NetSlum.Persistence.Entities.Guild", "Guild")
                        .WithOne("Stats")
                        .HasForeignKey("Fragment.NetSlum.Persistence.Entities.GuildStats", "GuildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_guild_stats_guilds_guild_id");

                    b.Navigation("Guild");
                });

            modelBuilder.Entity("Fragment.NetSlum.Persistence.Entities.WebNewsArticle", b =>
                {
                    b.HasOne("Fragment.NetSlum.Persistence.Entities.WebNewsCategory", "WebNewsCategory")
                        .WithMany()
                        .HasForeignKey("WebNewsCategoryId")
                        .HasConstraintName("fk_web_news_articles_web_news_categories_web_news_category_id");

                    b.Navigation("WebNewsCategory");
                });

            modelBuilder.Entity("Fragment.NetSlum.Persistence.Entities.WebNewsReadLog", b =>
                {
                    b.HasOne("Fragment.NetSlum.Persistence.Entities.PlayerAccount", "PlayerAccount")
                        .WithMany()
                        .HasForeignKey("PlayerAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_web_news_read_logs_player_accounts_player_account_id");

                    b.HasOne("Fragment.NetSlum.Persistence.Entities.WebNewsArticle", "WebNewsArticle")
                        .WithMany()
                        .HasForeignKey("WebNewsArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_web_news_read_logs_web_news_articles_web_news_article_id");

                    b.Navigation("PlayerAccount");

                    b.Navigation("WebNewsArticle");
                });

            modelBuilder.Entity("Fragment.NetSlum.Persistence.Entities.Character", b =>
                {
                    b.Navigation("CharacterStats")
                        .IsRequired();
                });

            modelBuilder.Entity("Fragment.NetSlum.Persistence.Entities.Guild", b =>
                {
                    b.Navigation("Members");

                    b.Navigation("Stats")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
