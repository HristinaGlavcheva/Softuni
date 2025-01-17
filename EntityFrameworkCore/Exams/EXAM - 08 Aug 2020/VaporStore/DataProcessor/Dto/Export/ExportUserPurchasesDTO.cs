﻿using System.Xml.Serialization;
using VaporStore.Data.Models;

namespace VaporStore.DataProcessor.Dto.Export
{
    [XmlType("User")]
    public class ExportUserPurchasesDTO
    {
        [XmlAttribute("username")]
        public string Username { get; set; }

        [XmlArray("Purchases")]
        public ExportPurchasesDTO[] Purchases { get; set; }
    }

    [XmlType("Purchase")]
    public class ExportPurchasesDTO
    {
        [XmlElement("Card")]
        public string Card { get; set; }

        [XmlElement("Cvc")]
        public string Cvc { get; set; }

        [XmlElement("Date")]
        public string Date { get; set; }

        [XmlAttribute("Game title")]
        public ExportGamePurchasesDTO Game { get; set; }
    }

    [XmlType("Game")]
    public class ExportGamePurchasesDTO
    {
        [XmlAttribute("title")]
        public int GameTitle { get; set; }

        [XmlElement("Genre")]
        public string Genre { get; set; }

        [XmlElement("Price")]
        public decimal Price { get; set; }
    }
}

//<User username = "mgraveson" >
//    < Purchases >
//      < Purchase >
//        < Card > 7991 7779 5123 9211</Card>
//        <Cvc>340</Cvc>
//        <Date>2017-08-31 17:09</Date>
//        <Game title = "Counter-Strike: Global Offensive" >
//          < Genre > Action </ Genre >
//          < Price > 12.49 </ Price >
//        </ Game >
//      </ Purchase >
//      < Purchase >
//        < Card > 7790 7962 4262 5606</Card>
//        <Cvc>966</Cvc>
//        <Date>2018-02-28 08:38</Date>
//        <Game title = "Tom Clancy's Ghost Recon Wildlands" >
//          < Genre > Action </ Genre >
//          < Price > 59.99 </ Price >
//        </ Game >
//      </ Purchase >
//    </ Purchases >
//    < TotalSpent > 72.48 </ TotalSpent >
//  </ User >
