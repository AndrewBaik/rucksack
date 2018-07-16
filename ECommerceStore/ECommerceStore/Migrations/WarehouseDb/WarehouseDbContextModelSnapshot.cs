﻿// <auto-generated />
using ECommerceStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ECommerceStore.Migrations.WarehouseDb
{
    [DbContext(typeof(WarehouseDbContext))]
    partial class WarehouseDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ECommerceStore.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<int>("ProductCategory");

                    b.Property<int>("Quantity");

                    b.Property<string>("SKU");

                    b.HasKey("ID");

                    b.ToTable("Products");

                    b.HasData(
                        new { ID = 1, Description = "Designed and engineered in the USA, the R-15PM powered speakers are made with a focus on quality and superior sound. Small enough to sit comfortably on a bookshelf or flanking your turntable or television, the R-15PM's are not only designed from a minimalist perspective, but they also allow you to ditch that bulky external receiver. ", Image = "https://uncrate.com/assets_c/2018/06/klipsch-r15-speaker-55-thumb-960xauto-85810.jpg", Name = "KLIPSCH R-15PM BOOKSHELF SPEAKERS", Price = 499.99m, ProductCategory = 1, Quantity = 50, SKU = "speaker01slipsch" },
                        new { ID = 2, Description = "The soft vinyl exterior and the fret grille cloth with signature script logo give it a stage equipment look. Marshall's Woburn Speaker sounds concert-worthy, too, with powerful built-in amps, two dome tweeters, and two sizable woofers.", Image = "https://uncrate.com/assets_c/2018/05/marshall-woburn-speaker-13-thumb-960xauto-84761.jpg", Name = "MARSHALL WOBURN SPEAKER", Price = 500.00m, ProductCategory = 1, Quantity = 50, SKU = "speaker02marshall" },
                        new { ID = 3, Description = "To embrace the vinyl resurgence, you need a pair of speakers designed for the task. Inspired by the warmth of early 70's hi-fi, when vinyl was at its peak, these Wesley & Kemp Full Range Speakers are handmade in Detroit with the analog format in mind. ", Image = "https://uncrate.com/assets_c/2018/06/wasley-kemp-speakers-58-thumb-960xauto-85886.jpg", Name = "WESLEY & KEMP X UNCRATE CS112 SPEAKERS", Price = 1400.00m, ProductCategory = 1, Quantity = 50, SKU = "speaker03wesley" },
                        new { ID = 4, Description = "Born from an art-school design concept that went viral, the Transparent Speaker from Stockholm-based People People proves great sounding speakers don't have to come in oversized black boxes. ", Image = "https://uncrate.com/assets_c/2017/06/transparent-speaker-1-thumb-960xauto-73340.jpg", Name = "PEOPLE PEOPLE TRANSPARENT SPEAKER", Price = 600m, ProductCategory = 1, Quantity = 50, SKU = "speaker04peoplepeople" },
                        new { ID = 5, Description = "Now in its fourth generation, Fujifilm's beloved digital rangefinder gets even better with the X100F. Like its film-based predecessors, it's ideal for street photography thanks to a combination of compact size, discreet looks, and a speedy AF system.", Image = "https://uncrate.com/assets_c/2018/06/fujifilm-x100-25-thumb-960xauto-85784.jpg", Name = "FUJIFILM X100F CAMERA", Price = 1200m, ProductCategory = 0, Quantity = 50, SKU = "gadget01fujifilm" },
                        new { ID = 6, Description = "Something magical happens when a sensor and lens are paired so perfectly that even the best DSLRs can't match it. By marrying Wetzlar's legendary optics with a big, bright sensor in an unbelievably compact body, the Leica Q becomes more than the sum of its parts. ", Image = "https://uncrate.com/assets_c/2018/06/leica-q-25-thumb-960xauto-85787.jpg", Name = "LEICA Q CAMERA ", Price = 4500m, ProductCategory = 0, Quantity = 50, SKU = "gadget02leica" },
                        new { ID = 7, Description = "Cut from an Ash tree, with the rings and bark left intact, each Barky turntable is beautiful and unique. ", Image = "https://uncrate.com/assets_c/2018/02/audiowood-uncrate-turntable-1-thumb-960xauto-80828.jpg", Name = "AUDIOWOOD X UNCRATE BARKY TURNTABLE ", Price = 2500m, ProductCategory = 0, Quantity = 50, SKU = "gadget03audiowood" },
                        new { ID = 8, Description = "We're all guilty of mindlessly staring at our smartphones instead of taking the time to view the real world in front of us. The Light Phone, now off of pre-order and available for immediate shipment, acts as a temporary replacement to your existing phone, giving you a break from social media feeds and news notifications, while still keeping a sleek device in your pocket for those old-fashioned 'phone calls'.", Image = "https://uncrate.com/assets_c/2017/06/light-phone-1-thumb-960xauto-72481.jpg", Name = "LIGHT PHONE ", Price = 150m, ProductCategory = 0, Quantity = 50, SKU = "gadget04lightphone" },
                        new { ID = 9, Description = "Constructed using lightweight and durable aluminum, the Tumi International Carry-On will make an impression no matter where your travels take you. Designed for short, overnight trips and travel within Europe and other international destinations, the suitcase boasts a rippled appearance and is as functional as it is good-looking.", Image = "https://uncrate.com/assets_c/2018/06/tumi-luggage-1-thumb-960xauto-85771.jpg", Name = "TUMI 19 DEGREE INTERNATIONAL CARRY-ON", Price = 1000.00m, ProductCategory = 2, Quantity = 50, SKU = "bag01tumi" },
                        new { ID = 10, Description = "Seamlessly transition from the office to the gym with the Stuart & Lau Regimen Bag. The outer compartments are dedicated to work, with a tasteful blue nylon twill lining, padded laptop pouch, and various organizer pockets. ", Image = "https://uncrate.com/assets_c/2018/07/stuart-lau-regimen-3-thumb-960xauto-87087.jpg", Name = "STUART & LAU REGIMEN GYM BAG ", Price = 400m, ProductCategory = 2, Quantity = 50, SKU = "bag02stuartnlau" },
                        new { ID = 11, Description = "Crafted from a waterproof technical weave, this adjustable bag has a versatile roll-top design. A padded compartment holds laptops up to 15\", three external pockets provide quick access to essentials, and bridle leather straps work with polished D - rings rings on the front to give it a smart look and functional purpose.", Image = "https://uncrate.com/assets_c/2018/05/mismo-backpack-2-thumb-960xauto-85173.jpg", Name = "MISMO M/S BACKPACK", Price = 500m, ProductCategory = 2, Quantity = 50, SKU = "bag03mismo" },
                        new { ID = 12, Description = "When it comes to small-but-important items like your phone, charger, passport, and pens, you don't just want them stored — you want them sorted, as well. This Is Ground's Venture 2 Backpack was designed with this in mind. ", Image = "https://uncrate.com/assets_c/2018/03/thisisground-venture-backpack-5-thumb-960xauto-82491.jpg", Name = "GROUND VENTURE 2 BACKPACK", Price = 950m, ProductCategory = 2, Quantity = 50, SKU = "bag04groundventure" },
                        new { ID = 13, Description = "Latest series of limited edition collaborations, the Topo Designs x Uncrate Rover Pack uses signature American bison leather as a base for Topo's nearly indestructible Ballistic Cordura fabric construction. ", Image = "https://uncrate.com/assets_c/2016/03/topo-1-thumb-960xauto-61610.jpg", Name = "TOPO DESIGNS X UNCRATE ROVER PACK", Price = 300m, ProductCategory = 2, Quantity = 50, SKU = "bag05topo" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
