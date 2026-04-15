//Name : Jaiden Heath
//Date : 4/15/2026
//Assignment : 1.5 - Inheritance, Composition, and User Interactions
using System;

namespace RolodexApp;

        public class Address
    {
        public string Street { get; set; }
        public string City   { get; set; }
        public string State  { get; set; }
        public string Zip    { get; set; }
 
        public Address(string street, string city, string state, string zip)
        {
            Street = street;
            City   = city;
            State  = state;
            Zip    = zip;
        }
 
        public override string ToString()
        {
            return $"{Street}, {City}, {State} {Zip}";
        }
    }
 
    
    public interface IDisplayable
    {
        void Display();
    }
     public abstract class Contact : IDisplayable
    {
               public string FirstName { get; set; }
        public string LastName  { get; set; }
        public string Phone     { get; set; }
        public string Email     { get; set; }
 
                public Address HomeAddress { get; set; }
 
        
        public Contact(string firstName, string lastName, string phone,
                       string email, Address address)
        {
            FirstName   = firstName;
            LastName    = lastName;
            Phone       = phone;
            Email       = email;
            HomeAddress = address;  
        }
 
        
        public abstract string GetContactType();
 
        public virtual void Display()
        {
            Console.WriteLine($"  Name    : {FirstName} {LastName}");
            Console.WriteLine($"  Phone   : {Phone}");
            Console.WriteLine($"  Email   : {Email}");
            Console.WriteLine($"  Address : {HomeAddress}");
        }
    }

    public class BusinessContact : Contact
    {
        public string Company    { get; set; }
        public string JobTitle   { get; set; }
 
        public BusinessContact(string firstName, string lastName, string phone,
                               string email, Address address,
                               string company, string jobTitle)
            : base(firstName, lastName, phone, email, address)
        {
            Company  = company;
            JobTitle = jobTitle;
        }
 
        public override string GetContactType() => "Business";
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"  Company : {Company}");
            Console.WriteLine($"  Title   : {JobTitle}");
        }
    }
    public class FamilyContact : Contact
    {
        public string Relationship { get; set; }   
        public string Birthday     { get; set; }
 
        public FamilyContact(string firstName, string lastName, string phone,
                             string email, Address address,
                             string relationship, string birthday)
            : base(firstName, lastName, phone, email, address)
        {
            Relationship = relationship;
            Birthday     = birthday;
        }
 
        public override string GetContactType() => "Family";
 
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"  Relation: {Relationship}");
            Console.WriteLine($"  Birthday: {Birthday}");
        }
    }
 
    public class FriendContact : Contact
    {
        public string Nickname   { get; set; }
        public string MetThrough { get; set; }   
 
        public FriendContact(string firstName, string lastName, string phone,
                             string email, Address address,
                             string nickname, string metThrough)
            : base(firstName, lastName, phone, email, address)
        {
            Nickname   = nickname;
            MetThrough = metThrough;
        }
 
        public override string GetContactType() => "Friend";
 
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"  Nickname: {Nickname}");
            Console.WriteLine($"  Met Via : {MetThrough}");
        }
    }
