using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JK651914_MIS4200SD.Models
{
    public class Owner
    {

        public int ownerID { get; set; }
        public string fistName { get; set; }
        public string lastName { get; set; }
        public DateTime birthDate { get; set; }
        // add any other fields as appropriate
        //Order is on the "one" side of a one-to-many relationship with OrderDetail
        //and we indicate that with an ICollection

        public int carId { get; set; }
        public ICollection<Car> Cars { get; set; }
      

    }
}