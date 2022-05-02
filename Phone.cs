using System;
using System.Collections.Generic;

class PhoneBook
{
  public static Dictionary<string, string> PhoneNumbers = new Dictionary<string, string>();

  static void Main()
  {
    Console.WriteLine("MAIN MENU");
    Console.WriteLine("WOuld you like to add a person to your phone book? ['Y' for yes, ;Enter' for No]");
    string answer = Console.ReadLine();
    if (answer == "Y" || answer == "y")
    {
      AddContacts();
    }
    else
    {
      Console.WriteLine("Would you like to look up a number ['Y' for yes, 'Enter' for no]");
      string LookUpAnswer = Console.ReadLine();
      if (LookUpAnswer == "Y" || LookUpAnswer == "y")
      {
        LookUpContact();
      }
      else
      {
        Console.WriteLine("Are you finished with this program? ['Y' for yes 'Enter' for no]");
        string lookUpAnswer = Console.ReadLine();
        if (lookUpAnswer == "Y" || lookUpAnswer == "y")
        {
          Console.WriteLine("Goodbye");
        }
        else
        {
          Main();
        }
      }
    }
  }

  static void AddContacts()
  {
    Console.WriteLine("NEW CONTACT");
    Console.WriteLine("Enter a new contact name");
    string name = Console.ReadLine();
    Console.WriteLine("Enter a new contact phone number");
    string number = Console.ReadLine();
    if (PhoneNumbers.ContainsKey(name))
    {
      Console.WriteLine("That person is already in your phonebook. Their number is" + PhoneNumbers[name]);
    }
    else
    {
      PhoneNumbers.Add(name, number);
    }
    Main();
  }

  static void LookUpContact()
  {
    Console.WriteLine("CONTACT LOOKUP");
    Console.WriteLine("Whose number would you like to look up?");
    string friend = Console.ReadLine();
    if (PhoneNumbers.ContainsKey(friend))
    {
      string value = PhoneNumbers[friend];
      Console.WriteLine(friend + "\'s phone number is" + value);
    }
    else
    {
      Console.WriteLine("That person is not in your phone book.");
    }
    Main();
  }

}