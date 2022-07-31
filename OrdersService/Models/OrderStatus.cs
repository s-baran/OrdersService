using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersService.Models
{
    public enum OrderStatus
    {
        Pending,
        AwaitingPayment,
        AwaitingFulfillment,
        AwaitingShipment,
        AwaitingPickup,
        PartiallyShipped,
        Completed,
        Shipped,
        Cancelled,
        Declined,
        Refunded,
        Disputed,
        ManualVerificationRequired,
        PartiallyRefunded
    }
}
