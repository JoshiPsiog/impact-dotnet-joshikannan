namespace Week03.PatternsLab.Services;

public class OrderFacade
{
    private readonly InventoryService inventory = new();
    private readonly PaymentService payment = new();
    private readonly ShippingService shipping = new();

    public void PlaceOrder()
    {
        inventory.CheckStock();
        payment.MakePayment();
        shipping.ShipOrder();

        Console.WriteLine("Order Completed Successfully");
    }
}