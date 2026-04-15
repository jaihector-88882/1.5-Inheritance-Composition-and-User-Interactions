//Name : Jaiden Heath
//Date : 4/15/2026
//Assignment : 1.5 - Inheritance, Composition, and User Interactions

namespace RolodexApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            PrintDivider('=', 60);
            Console.WriteLine("  PROJECT PHASE 1  |  Rolodex / Contacts Application");
            Console.WriteLine("  Author : [Jaiden Heath]");
            Console.WriteLine("  Course : [SDC320 C# OOP]");
            PrintDivider('=', 60);
            Console.WriteLine();
 
            Console.WriteLine("Welcome to the Rolodex App!");
            Console.WriteLine("  This application lets you manage contacts across three");
            Console.WriteLine("  categories: Business, Family, and Friend.");
            Console.WriteLine("    - Inheritance  : Base Contact class with derived types");
            Console.WriteLine("    - Composition  : Address object embedded in each Contact");
            Console.WriteLine("    - Polymorphism : Each contact type displays its own fields");
            Console.WriteLine();
            PrintDivider('-', 60);
            Console.WriteLine("  Press ENTER to continue...");
            Console.ReadLine();
 
            var bContact = new BusinessContact(
                "Margaret", "Chen",
                "757-555-0142", "m.chen@techcorp.com",
                new Address("101 Innovation Drive", "Norfolk", "VA", "23510"),
                "TechCorp Solutions", "Senior Software Engineer"
            );
 
            var fContact = new FamilyContact(
                "Carlos", "Rivera",
                "757-555-0287", "carlos.r@email.com",
                new Address("88 Maple Street", "Virginia Beach", "VA", "23451"),
                "Brother", "March 14"
            );
 
            var frContact = new FriendContact(
                "Samantha", "Patel",
                "757-555-0391", "sam.patel@email.com",
                new Address("45 Ocean View Blvd", "Chesapeake", "VA", "23320"),
                "Sam", "College"
            );
 
            var contacts = new List<Contact> { bContact, fContact, frContact };
 
            
            Console.Clear();
            PrintDivider('=', 60);
            Console.WriteLine("  ALL CONTACTS  ({0} total)", contacts.Count);
            PrintDivider('=', 60);
 
            foreach (var contact in contacts)
            {
                Console.WriteLine();
                
                Console.WriteLine("  [ {0} CONTACT ]", contact.GetContactType().ToUpper());
                PrintDivider('-', 40);
                contact.Display();   
            }
 
            Console.WriteLine();
            PrintDivider('=', 60);
            Console.WriteLine("  End of Phase 1 Demo.  Press ENTER to exit.");
            PrintDivider('=', 60);
            Console.ReadLine();
        }
 
        
        static void PrintDivider(char ch, int length)
        {
            Console.WriteLine(new string(ch, length));
        }
    }
}