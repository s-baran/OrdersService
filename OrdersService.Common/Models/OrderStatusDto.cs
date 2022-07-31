namespace OrdersService.Common.Models
{
    public enum OrderStatusDto
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
