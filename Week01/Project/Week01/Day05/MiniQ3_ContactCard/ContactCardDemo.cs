namespace Week01.Day05.MiniQ3_ContactCard;

public static class ContactCardDemo
{
    public static void Run()
    {
        ContactCard[] contacts =
        {
            new ContactCard
            {
                Name = "Joshi",
                PhoneNumber = "9876543210"
            },

            new ContactCard
            {
                Name = "Rahul",
                PhoneNumber = "9876500001"
            },

            new ContactCard
            {
                Name = "Anitha",
                PhoneNumber = "9876500002"
            },

            new ContactCard
            {
                Name = "Karthik",
                PhoneNumber = "9876500003"
            },

            new ContactCard
            {
                Name = "Swathi",
                PhoneNumber = "9876500004"
            }
        };

        Console.WriteLine("===== Contact Search =====");

        string searchName = "joshi";

        bool found = false;

        foreach (ContactCard contact in contacts)
        {
            if (contact.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Contact Found");
                Console.WriteLine($"Name  : {contact.Name}");
                Console.WriteLine($"Phone : {contact.PhoneNumber}");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Contact Not Found");
        }

        // Explanation:
        // OrdinalIgnoreCase performs a case-insensitive comparison.
        // "joshi" matches "Joshi".
    }
}