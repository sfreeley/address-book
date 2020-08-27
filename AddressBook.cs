 using System.Collections.Generic;
 using System;

 namespace address_book
 {
     public class AddressBook
     {
         private Dictionary<string, Contact> _contacts = new Dictionary<string, Contact>();

         public void AddContact(Contact newPerson)
         {
             try
             {
                 _contacts.Add(newPerson.Email, newPerson);
             }
             catch
             {
                 Console.WriteLine("You have already added this person to your AddressBook");
             }

         }

         public Contact GetByEmail(string email)
         {
             {
                 return _contacts[email];
             }
         }
     }

 }