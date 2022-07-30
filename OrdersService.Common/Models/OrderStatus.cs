namespace OrdersService.Common.Models
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
