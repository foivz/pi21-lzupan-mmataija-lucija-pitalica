using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projekt_faza_1;
using Projekt_faza_1.Klase;
using System;
using System.Collections.Generic;

namespace TestHotelReservation
{
    [TestClass]
    public class UnitTest1
        
    {
        
        [TestMethod]
        public void TestDodavanjeSobe()
        {
            //Arange
            List<SobaKlasa> soba = RepozitorijSoba.DohvatiSobe();
            int broj = soba.Count;
            SobaKlasa sobe = new SobaKlasa();
            sobe.OIB_hotela = "123456789";
            sobe.VelicinaSobe = 60;
            sobe.Kapacitet = 4;
            sobe.Sadrzaj_sobe = "sadrzajsobe";
            sobe.Sadrzaj_kupaonice = "sadrzajkupaonice";
            sobe.Napomene = "napomena";
            sobe.Slobodna = 1;
            sobe.Broj_sobe = "30";
            sobe.Cijena = 250;
            //Act
            RepozitorijSoba.DodajSobu(sobe);
            soba = RepozitorijSoba.DohvatiSobe();

            //Assert
            Assert.IsTrue(broj < soba.Count);
        }
        [TestMethod]
        public void TestDodavanjeHotela()
        {
            //Arange
            List<HotelKlasa> hotel = HotelRepozitorij.DohvatiHotele();
            int broj = hotel.Count;
            HotelKlasa hoteli = new HotelKlasa();
            hoteli.OIB_Hotela = "125521221";
            hoteli.IBAN = "HR1231231231231231231";
            hoteli.Naziv_hotel = "Valamar";
            hoteli.Telefon = "+3859123432";
            hoteli.Adresa = "Petra Svačića 21, 51250 Novi Vinodolski";
            hoteli.Email = "valamar@gmail.com";
            hoteli.Kapacitet = 500;
            hoteli.Korisnik_id = 0;
            hoteli.Lozinka = "lozinka123";
            //Act
            HotelRepozitorij.DodajHotel(hoteli);
            hotel = HotelRepozitorij.DohvatiHotele();
           

            //Assert
            Assert.IsTrue(broj < hotel.Count);
        }
        [TestMethod]
        public void TestBrisanjeSobe()
        {
            List<SobaKlasa> soba = RepozitorijSoba.DohvatiSobe();
            int broj = soba.Count;
            SobaKlasa sobe = new SobaKlasa();
            sobe.ID_soba = 14;
            sobe.OIB_hotela = "123456789";
            sobe.VelicinaSobe = 50;
            sobe.Kapacitet = 4;
            sobe.Sadrzaj_sobe = "sadrzajsobe";
            sobe.Sadrzaj_kupaonice = "sadrzajkupaonice";
            sobe.Napomene = "napomena";
            sobe.Slobodna = 1;
            sobe.Broj_sobe = "30";
            sobe.Cijena = 250;
            //Act
            RepozitorijSoba.ObrisiSobu(sobe);
            soba = RepozitorijSoba.DohvatiSobe();

            //Assert
            Assert.IsTrue(broj > soba.Count);
        }
        [TestMethod]
        public void TestAžuriranjeSobe()
        {
            List<SobaKlasa> soba = RepozitorijSoba.DohvatiSobe();
            SobaKlasa sobe = new SobaKlasa();
            sobe.ID_soba = 18;
            sobe.OIB_hotela = "123456789";
            sobe.VelicinaSobe = 55;
            sobe.Kapacitet = 4;
            sobe.Sadrzaj_sobe = "sadrzajsobe";
            sobe.Sadrzaj_kupaonice = "sadrzajkupaonice";
            sobe.Napomene = "napomena";
            sobe.Slobodna = 1;
            sobe.Broj_sobe = "30";
            sobe.Cijena = 250;
            //Act
            RepozitorijSoba.IzmijeniSobu(sobe);
            soba = RepozitorijSoba.DohvatiSobe();

            //Assert
            Assert.IsTrue(RepozitorijSoba.IzmijeniSobu(sobe)==1);
        }
    }
}
