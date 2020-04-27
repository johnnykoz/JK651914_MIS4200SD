using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JK651914_MIS4200SD.Models
{
    public class Car
    {

        public int carId { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string licensePlate { get; set; }
        public DateTime purchaseDate { get; set; }



        public ICollection<OrderDetails> OrderDetails { get; set; }

    }
}