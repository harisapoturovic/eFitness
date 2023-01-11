﻿// <auto-generated />
using System;
using FitVision.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FitVision.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230108215722_m")]
    partial class m
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AkcijaProizvod", b =>
                {
                    b.Property<int>("AkcijeID")
                        .HasColumnType("int");

                    b.Property<int>("ProizvodiID")
                        .HasColumnType("int");

                    b.HasKey("AkcijeID", "ProizvodiID");

                    b.HasIndex("ProizvodiID");

                    b.ToTable("AkcijaProizvod");
                });

            modelBuilder.Entity("FitVision.Modul0_Autentifikacija.Models.AutentifikacijaToken", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("KorisnickiNalogId")
                        .HasColumnType("int");

                    b.Property<string>("ipAdresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vrijednost")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("vrijemeEvidentiranja")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("KorisnickiNalogId");

                    b.ToTable("AutentifikacijaToken");
                });

            modelBuilder.Entity("FitVision.Modul0_Autentifikacija.Models.KorisnickiNalog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lozinka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("KorisnickiNalog");
                });

            modelBuilder.Entity("FitVision.Modul2.Models.Akcija", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("DatumPocetka")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumZavrsetka")
                        .HasColumnType("datetime2");

                    b.Property<int>("Iznos")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Akcija");
                });

            modelBuilder.Entity("FitVision.Modul2.Models.Brend", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brend");
                });

            modelBuilder.Entity("FitVision.Modul2.Models.Drzava", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Skracenica")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Drzava");
                });

            modelBuilder.Entity("FitVision.Modul2.Models.ForumOdgovor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("AutorIme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumKreiranja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Odgovor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("forumTema_id")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("forumTema_id");

                    b.ToTable("ForumOdgovor");
                });

            modelBuilder.Entity("FitVision.Modul2.Models.ForumTema", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("DatumKreiranja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Pitanje")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tema")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("korisnickiNalogID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("korisnickiNalogID");

                    b.ToTable("ForumTema");
                });

            modelBuilder.Entity("FitVision.Modul2.Models.Grad", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostanskiBroj")
                        .HasColumnType("int");

                    b.Property<int>("drzavaID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("drzavaID");

                    b.ToTable("Grad");
                });

            modelBuilder.Entity("FitVision.Modul2.Models.Kategorija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kategorija");
                });

            modelBuilder.Entity("FitVision.Modul2.Models.Korpa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DatumKreiranja")
                        .HasColumnType("datetime2");

                    b.Property<int>("korisnikID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("korisnikID");

                    b.ToTable("Korpa");
                });

            modelBuilder.Entity("FitVision.Modul2.Models.KorpaProizvod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<float>("Cijena")
                        .HasColumnType("real");

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<int>("Popust")
                        .HasColumnType("int");

                    b.Property<int>("korpaID")
                        .HasColumnType("int");

                    b.Property<int>("proizvodID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("korpaID");

                    b.HasIndex("proizvodID");

                    b.ToTable("KorpaProizvod");
                });

            modelBuilder.Entity("FitVision.Modul2.Models.Narudzba", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DatumKreiranja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("korisnikID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("korisnikID");

                    b.ToTable("Narudzba");
                });

            modelBuilder.Entity("FitVision.Modul2.Models.Odgovor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("AdminIme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumKreiranja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Sadrzaj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("poruka_id")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("poruka_id");

                    b.ToTable("Odgovor");
                });

            modelBuilder.Entity("FitVision.Modul2.Models.Oprema", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("Broj")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slika")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tipOpremeID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("tipOpremeID");

                    b.ToTable("Oprema");
                });

            modelBuilder.Entity("FitVision.Modul2.Models.Podkategorija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("KategorijaId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KategorijaId");

                    b.ToTable("Podkategorija");
                });

            modelBuilder.Entity("FitVision.Modul2.Models.Poruka", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("DatumKreiranja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Naslov")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sadrzaj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("korisnickiNalogID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("korisnickiNalogID");

                    b.ToTable("Poruka");
                });

            modelBuilder.Entity("FitVision.Modul2.Models.Proizvod", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<float>("JedinicnaCijena")
                        .HasColumnType("real");

                    b.Property<string>("JedinicnaMjera")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sastav")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slika")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Zaliha")
                        .HasColumnType("int");

                    b.Property<int>("brendid")
                        .HasColumnType("int");

                    b.Property<int>("pod_kategorijaid")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("brendid");

                    b.HasIndex("pod_kategorijaid");

                    b.ToTable("Proizvod");
                });

            modelBuilder.Entity("FitVision.Modul2.Models.TipOpreme", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TipOpreme");
                });

            modelBuilder.Entity("FitVision.Modul2.Models.Admin", b =>
                {
                    b.HasBaseType("FitVision.Modul0_Autentifikacija.Models.KorisnickiNalog");

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumZaposlenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JMBG")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Spol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StrucnaSprema")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("gradid")
                        .HasColumnType("int");

                    b.HasIndex("gradid");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("FitVision.Modul2.Models.Korisnik", b =>
                {
                    b.HasBaseType("FitVision.Modul0_Autentifikacija.Models.KorisnickiNalog");

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumPolasaka")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JMBG")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Spol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tezina")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Visina")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("gradid")
                        .HasColumnType("int");

                    b.HasIndex("gradid");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("AkcijaProizvod", b =>
                {
                    b.HasOne("FitVision.Modul2.Models.Akcija", null)
                        .WithMany()
                        .HasForeignKey("AkcijeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitVision.Modul2.Models.Proizvod", null)
                        .WithMany()
                        .HasForeignKey("ProizvodiID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FitVision.Modul0_Autentifikacija.Models.AutentifikacijaToken", b =>
                {
                    b.HasOne("FitVision.Modul0_Autentifikacija.Models.KorisnickiNalog", "KorisnickiNalog")
                        .WithMany()
                        .HasForeignKey("KorisnickiNalogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KorisnickiNalog");
                });

            modelBuilder.Entity("FitVision.Modul2.Models.ForumOdgovor", b =>
                {
                    b.HasOne("FitVision.Modul2.Models.ForumTema", "forumTema")
                        .WithMany()
                        .HasForeignKey("forumTema_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("forumTema");
                });

            modelBuilder.Entity("FitVision.Modul2.Models.ForumTema", b =>
                {
                    b.HasOne("FitVision.Modul0_Autentifikacija.Models.KorisnickiNalog", "korisnickiNalog")
                        .WithMany()
                        .HasForeignKey("korisnickiNalogID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("korisnickiNalog");
                });

            modelBuilder.Entity("FitVision.Modul2.Models.Grad", b =>
                {
                    b.HasOne("FitVision.Modul2.Models.Drzava", "drzava")
                        .WithMany()
                        .HasForeignKey("drzavaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("drzava");
                });

            modelBuilder.Entity("FitVision.Modul2.Models.Korpa", b =>
                {
                    b.HasOne("FitVision.Modul2.Models.Korisnik", "korisnik")
                        .WithMany()
                        .HasForeignKey("korisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("korisnik");
                });

            modelBuilder.Entity("FitVision.Modul2.Models.KorpaProizvod", b =>
                {
                    b.HasOne("FitVision.Modul2.Models.Korpa", "korpa")
                        .WithMany()
                        .HasForeignKey("korpaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitVision.Modul2.Models.Proizvod", "proizvod")
                        .WithMany()
                        .HasForeignKey("proizvodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("korpa");

                    b.Navigation("proizvod");
                });

            modelBuilder.Entity("FitVision.Modul2.Models.Narudzba", b =>
                {
                    b.HasOne("FitVision.Modul2.Models.Korisnik", "korisnik")
                        .WithMany()
                        .HasForeignKey("korisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("korisnik");
                });

            modelBuilder.Entity("FitVision.Modul2.Models.Odgovor", b =>
                {
                    b.HasOne("FitVision.Modul2.Models.Poruka", "poruka")
                        .WithMany()
                        .HasForeignKey("poruka_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("poruka");
                });

            modelBuilder.Entity("FitVision.Modul2.Models.Oprema", b =>
                {
                    b.HasOne("FitVision.Modul2.Models.TipOpreme", "tipOpreme")
                        .WithMany()
                        .HasForeignKey("tipOpremeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("tipOpreme");
                });

            modelBuilder.Entity("FitVision.Modul2.Models.Podkategorija", b =>
                {
                    b.HasOne("FitVision.Modul2.Models.Kategorija", "kategorija")
                        .WithMany()
                        .HasForeignKey("KategorijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("kategorija");
                });

            modelBuilder.Entity("FitVision.Modul2.Models.Poruka", b =>
                {
                    b.HasOne("FitVision.Modul0_Autentifikacija.Models.KorisnickiNalog", "korisnickiNalog")
                        .WithMany()
                        .HasForeignKey("korisnickiNalogID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("korisnickiNalog");
                });

            modelBuilder.Entity("FitVision.Modul2.Models.Proizvod", b =>
                {
                    b.HasOne("FitVision.Modul2.Models.Brend", "brend")
                        .WithMany()
                        .HasForeignKey("brendid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitVision.Modul2.Models.Podkategorija", "pod_kategorija")
                        .WithMany()
                        .HasForeignKey("pod_kategorijaid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("brend");

                    b.Navigation("pod_kategorija");
                });

            modelBuilder.Entity("FitVision.Modul2.Models.Admin", b =>
                {
                    b.HasOne("FitVision.Modul0_Autentifikacija.Models.KorisnickiNalog", null)
                        .WithOne()
                        .HasForeignKey("FitVision.Modul2.Models.Admin", "ID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("FitVision.Modul2.Models.Grad", "grad")
                        .WithMany()
                        .HasForeignKey("gradid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("grad");
                });

            modelBuilder.Entity("FitVision.Modul2.Models.Korisnik", b =>
                {
                    b.HasOne("FitVision.Modul0_Autentifikacija.Models.KorisnickiNalog", null)
                        .WithOne()
                        .HasForeignKey("FitVision.Modul2.Models.Korisnik", "ID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("FitVision.Modul2.Models.Grad", "grad")
                        .WithMany()
                        .HasForeignKey("gradid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("grad");
                });
#pragma warning restore 612, 618
        }
    }
}
