
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroceryApp.Core.Entities;
using GroceryApp.Data;


namespace GroceryApp.Data
    {
        public class DBInitialiser : IDBInitialiser
        {
            public void SeedDB(GroceryAppContext ctx)
            {
                Stores netto1 = ctx.Add(new Stores
                {
                    Name = "Netto",
                    Address = "Tarphagevej 23, 6710 Esbjerg",
                    Latitude = 55.494710,
                    Longitude = 8.410030,
                    WebUrl = "https://netto.dk",
                }).Entity;

                Stores netto2 = ctx.Add(new Stores
                {
                    Name = "Netto",
                    Address = "Stengårdsvej 2, 6705 Esbjerg",
                    Latitude = 55.479680,
                    Longitude = 8.493270,
                    WebUrl = "https://netto.dk",
                }).Entity;

                Stores netto3 = ctx.Add(new Stores
                {
                    Name = "Netto",
                    Address = "Storegade 31, 6700 Esbjerg",
                    Latitude = 55.47107582615591,
                    Longitude = 8.465465026649694,
                    WebUrl = "https://netto.dk",

                }).Entity;

                Stores netto4 = ctx.Add(new Stores
                {
                    Name = "Netto",
                    Address = "Gammelby Ringvej 2, 6700 Esbjerg",
                    Latitude = 55.46388138230241,
                    Longitude = 8.463963082472597,
                    WebUrl = "https://netto.dk",

                }).Entity;

                Stores netto5 = ctx.Add(new Stores
                {
                    Name = "Netto",
                    Address = "Gl Vardevej 13, 6700 Esbjerg",
                    Latitude = 55.475087856625024,
                    Longitude = 8.436729911308461,
                    WebUrl = "https://netto.dk",

                }).Entity;

                Stores Rema1 = ctx.Add(new Stores
                {
                    Name = "Rema1000",
                    Address = "Stormgade 111, 6700 Esbjerg",
                    Latitude = 55.477751426260326,
                    Longitude = 8.447461313156047,
                    WebUrl = "https://rema1000.dk",

                }).Entity;

                Stores Rema2 = ctx.Add(new Stores
                {
                    Name = "Rema1000",
                    Address = "Storegade 196, 6705 Esbjerg",
                    Latitude = 55.47814645334241,
                    Longitude = 8.489104164722479,
                    WebUrl = "https://rema1000.dk",

                }).Entity;

                Stores Rema3 = ctx.Add(new Stores
                {
                    Name = "Rema1000",
                    Address = "Tarp Byvej 30, 6715 Esbjerg",
                    Latitude = 55.527808214618574,
                    Longitude = 8.457632211310877,
                    WebUrl = "https://rema1000.dk",

                }).Entity;

                Stores Rema4 = ctx.Add(new Stores
                {
                    Name = "Rema1000",
                    Address = "Vandmandens Kvarter 3, 6710 Esbjerg",
                    Latitude = 55.51911592066913,
                    Longitude = 8.414766984322496,
                    WebUrl = "https://rema1000.dk",

                }).Entity;

                Stores Rema5 = ctx.Add(new Stores
                {
                    Name = "Rema1000",
                    Address = " Exnersgade, 6700 Esbjerg",
                    Latitude = 55.464884863115664,
                    Longitude = 8.458458906807788,
                    WebUrl = "https://rema1000.dk",

                }).Entity;

                Stores Rema6 = ctx.Add(new Stores
                {
                    Name = "Rema1000",
                    Address = "Parkvej 123, 6710 Esbjerg",
                    Latitude = 55.495305067036576,
                    Longitude = 8.421238015004244,
                    WebUrl = "https://rema1000.dk",

                }).Entity;

                Stores Bilka = ctx.Add(new Stores
                {
                    Name = "Bilka",
                    Address = "Stormgade 157, 6715 Esbjerg N",
                    Latitude = 55.510305135848576,
                    Longitude = 8.456177440145442,
                    WebUrl = "https://www.bilka.dk/",

                }).Entity;

                Stores Føtex = ctx.Add(new Stores
                {
                    Name = "Føtex",
                    Address = "Kronprinsensgade 1, 3, 6700 Esbjerg",
                    Latitude = 55.466314975921314,
                    Longitude = 8.44560060207095,
                    WebUrl = "https://www.foetex.dk",

                }).Entity;

                Stores Aldi1 = ctx.Add(new Stores
                {
                    Name = "Aldi",
                    Address = "Tarphagevej 11, 6710 Esbjerg V",
                    Latitude = 55.496271046664354,
                    Longitude = 8.410473874712379,
                    WebUrl = "https://www.aldi.dk",

                }).Entity;

                Stores Aldi2 = ctx.Add(new Stores
                {
                    Name = "Aldi",
                    Address = "Strandby Kirkevej 88, 6705 Esbjerg",
                    Latitude = 55.48041785442925,
                    Longitude = 8.478451775467443,
                    WebUrl = "https://www.aldi.dk",

                }).Entity;

                Stores Aldi3 = ctx.Add(new Stores
                {
                    Name = "Aldi",
                    Address = "Østervangsvej 1B, 6715 Esbjerg N",
                    Latitude = 55.48041785442925,
                    Longitude = 8.478623436832986,
                    WebUrl = "https://www.aldi.dk",

                }).Entity;

                Stores Fakta1 = ctx.Add(new Stores
                {
                    Name = "Fakta",
                    Address = "Fyrvej 34, 6710 Esbjerg",
                    Latitude = 55.497039108593476,
                    Longitude = 8.404865572675003,
                    WebUrl = "https://fakta.coop.dk",

                }).Entity;

                Stores Fakta2 = ctx.Add(new Stores
                {
                    Name = "Fakta",
                    Address = "Tordenskjoldsgade 22, 6700 Esbjerg",
                    Latitude = 55.46896591402578,
                    Longitude = 8.439333384320298,
                    WebUrl = "https://fakta.coop.dk",

                }).Entity;

                Stores Fakta3 = ctx.Add(new Stores
                {
                    Name = "Fakta",
                    Address = "Spangsbjerg Møllevej 5, 6715 Esbjerg",
                    Latitude = 55.49775787493107,
                    Longitude = 8.444908188016456,
                    WebUrl = "https://fakta.coop.dk",

                }).Entity;

                Stores Fakta4 = ctx.Add(new Stores
                {
                    Name = "Fakta",
                    Address = "Vandmandens Kvarter 4, 6710 Esbjerg",
                    Latitude = 55.51963874412705,
                    Longitude = 8.413696928499311,
                    WebUrl = "https://fakta.coop.dk",

                }).Entity;

                Stores Fakta5 = ctx.Add(new Stores
                {
                    Name = "Fakta",
                    Address = "Jernbanegade 48, 6700 Esbjerg",
                    Latitude = 55.46955082265992,
                    Longitude = 8.457962045685843,
                    WebUrl = "https://fakta.coop.dk",

                }).Entity;

                Stores Fakta6 = ctx.Add(new Stores
                {
                    Name = "Fakta",
                    Address = "Storegade 125, 6700 Esbjerg",
                    Latitude = 55.47365503802995,
                    Longitude = 8.476076197814427,
                    WebUrl = "https://fakta.coop.dk",

                }).Entity;

                Stores Fakta7 = ctx.Add(new Stores
                {
                    Name = "Fakta",
                    Address = "Gl Vardevej 230, Lej 31, 6715 Esbjerg",
                    Latitude = 55.50789501551358,
                    Longitude = 8.450132026651362,
                    WebUrl = "https://fakta.coop.dk",

                }).Entity;

                Stores Fakta8 = ctx.Add(new Stores
                {
                    Name = "Fakta",
                    Address = "Hjertingvej 70, 6700 Esbjerg",
                    Latitude = 55.47990206039678,
                    Longitude = 8.428220089863057,
                    WebUrl = "https://fakta.coop.dk",

                }).Entity;

                Stores Fakta9 = ctx.Add(new Stores
                {
                    Name = "Fakta",
                    Address = "Kvaglundparken 6, 8, 6705 Esbjerg",
                    Latitude = 55.49507153703046,
                    Longitude = 8.484844426650772,
                    WebUrl = "https://fakta.coop.dk",

                }).Entity;

                Stores Fakta10 = ctx.Add(new Stores
                {
                    Name = "Fakta",
                    Address = "Niels Lambertsens Vej 6, 6705 Esbjerg",
                    Latitude = 55.48033153662097,
                    Longitude = 8.46574395363801,
                    WebUrl = "https://fakta.coop.dk",

                }).Entity;

                Stores Lidl1 = ctx.Add(new Stores
                {
                    Name = "Lidl",
                    Address = "Storegade 227, 6705 Esbjerg Ø",
                    Latitude = 55.47922026819488,
                    Longitude = 8.495211890424994,
                    WebUrl = "https://www.lidl.dk/",

                }).Entity;

                Stores Lidl2 = ctx.Add(new Stores
                {
                    Name = "Lidl",
                    Address = "Østervangsvej 2, 6715 Esbjerg",
                    Latitude = 55.50204052111886,
                    Longitude = 8.454125668980392,
                    WebUrl = "https://www.lidl.dk/",

                }).Entity;

                Stores Meny = ctx.Add(new Stores
                {
                    Name = "Meny",
                    Address = "Bytoften 20, 6710 Esbjerg",
                    Latitude = 55.526107100488666,
                    Longitude = 8.358059240146163,
                    WebUrl = "https://meny.dk",

                }).Entity;

                Stores MiniBazar = ctx.Add(new Stores
                {
                    Name = "MiniBazar",
                    Address = "Langelandsvej 4, 6705 Esbjerg",
                    Latitude = 55.47969384099292,
                    Longitude = 8.468531153637988,
                    WebUrl = "https://google.dk",

                }).Entity;

                ctx.SaveChanges();
            }
        }
    }


