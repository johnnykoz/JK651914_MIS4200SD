using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JK651914_MIS4200SD.Models
{
    public class OrderDetails
    {

        public int orderdetailsId { get; set; }
        public decimal price { get; set; }


        // the next two properties link the orderDetail to the Order
        public int CarId { get; set; }
        public virtual Car Cars { get; set; }
        // the next two properties link the orderDetail to the Product
        public int ownerId { get; set; }
        public virtual Owner Owners { get; set; }

    }
}