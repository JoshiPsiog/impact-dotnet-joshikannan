namespace Week03.PatternsLab.Reflection;

public class Invoice
{
    public int Id { get; set; }

    public string Customer { get; set; } = "";

    public Invoice()
    {

    }

    public Invoice(int id, string customer)
    {
        Id = id;
        Customer = customer;
    }

    public void PrintInvoice()
    {
        Console.WriteLine($"Invoice : {Id} {Customer}");
    }
}