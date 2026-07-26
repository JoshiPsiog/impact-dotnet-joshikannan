using System;

delegate void NotificationSender(string message);

class NotificationService
{
    public event Action<string>? OnNotificationSent;

    public void Send(NotificationSender sender, string message)
    {
        sender(message);
        OnNotificationSent?.Invoke(message);
    }
}

class Program
{
    static void Email(string msg)
    {
        Console.WriteLine($"Email : {msg}");
    }

    static void Sms(string msg)
    {
        Console.WriteLine($"SMS : {msg}");
    }

    static void Push(string msg)
    {
        Console.WriteLine($"Push : {msg}");
    }

    static void Logger(string msg)
    {
        Console.WriteLine($"Logged : {msg}");
    }

    static void Main()
    {
        NotificationService service = new();

        service.OnNotificationSent += Logger;

        service.Send(Email, "Welcome");
        service.Send(Sms, "OTP Sent");
        service.Send(Push, "Offer Available");
    }
}