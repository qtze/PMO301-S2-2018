﻿// <auto-generated />
using IdentityMatchingWebsite.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IdentityMatchingWebsite.Migrations
{
    [DbContext(typeof(IdentityMatchingWebsiteContext))]
    [Migration("20180823155636_Initial2")]
    partial class Initial2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IdentityMatchingWebsite.Models.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DateOfBirth");

                    b.Property<string>("FirstName");

                    b.Property<string>("LegalSurname");

                    b.Property<string>("Surname");

                    b.HasKey("ID");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("IdentityMatchingWebsite.Models.PersonTwo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DateOfBirth");

                    b.Property<string>("FirstName");

                    b.Property<string>("LegalSurname");

                    b.Property<string>("Surname");

                    b.HasKey("ID");

                    b.ToTable("PersonTwo");
                });

            modelBuilder.Entity("IdentityMatchingWebsite.Models.Results", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DateOfBirth");

                    b.Property<string>("FirstName");

                    b.Property<string>("LegalSurname");

                    b.Property<string>("Surname");

                    b.HasKey("ID");

                    b.ToTable("Results");
                });
#pragma warning restore 612, 618
        }
    }
}
