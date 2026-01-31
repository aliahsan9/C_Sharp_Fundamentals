using System;
using System.Collections.Generic;

// 1. Base class
public abstract class Notification
{
    public string Message { get; set; }

    public Notification(string message)
    {
        Message = message;
    }

    // Polymorphic method
    public abstract void Send();
}

// 2. Derived classes
public class EmailNotification : Notification
{
    public EmailNotification(string message) : base(message) { }

    public override void Send()
    {
        Console.WriteLine("Sending Email: " + Message);
    }
}

public class SMSNotification : Notification
{
    public SMSNotification(string message) : base(message) { }

    public override void Send()
    {
        Console.WriteLine("Sending SMS: " + Message);
    }
}

public class PushNotification : Notification
{
    public PushNotification(string message) : base(message) { }

    public override void Send()
    {
        Console.WriteLine("Sending Push Notification: " + Message);
    }
}

// 3. Client code
class Program
{
    static void Main()
    {
        List<Notification> notifications = new List<Notification>
        {
            new EmailNotification("Hello via Email!"),
            new SMSNotification("Hello via SMS!"),
            new PushNotification("Hello via Push!")
        };

        // Polymorphism in action
        foreach (var notification in notifications)
        {
            notification.Send();  // No if-else needed
        }
    }
}
