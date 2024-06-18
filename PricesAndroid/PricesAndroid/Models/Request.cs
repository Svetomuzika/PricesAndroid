using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using static PricesAndroid.Models.StatusEnum;

namespace PricesAndroid.Models
{
    public class Request
    {
        public int Id { get; set; }
        public int RequestNumber { get; set; }
        public StatusEnum Status { get; set; }
        public string DepartureCity { get; set; }
        public string ArrivalCity { get; set; }
        public int ContainerSize { get; set; }
        public int CargoWeight { get; set; }
        public double Price { get; set; }
        public string DepartureDate { get; set; }
        public string RequestCreateDate { get; set; }
        public string Comment { get; set; }
        public int ClientId { get; set; }

        public string SearchHelper 
            => $"{RequestNumber} {DepartureCity} {ArrivalCity} {ContainerSize} {CargoWeight} {Price} {DepartureDate} {RequestCreateDate} {Comment}";
    }
}