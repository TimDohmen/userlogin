using System;
using System.Collections.Generic;
using login.Models;

namespace login
{
  class Program
  {
    static void Main(string[] args)
    {

      Dictionary<string, User> users = new Dictionary<string, User>();
      User tim = new User("Tim", "Lovecode");
      User jake = new User("Jake", "codew0rks");
      users.Add(jake.Name, jake);
      users.Add(tim.Name, tim);

      System.Console.WriteLine("Username: ");
      string username = Console.ReadLine();
      Console.WriteLine("Password: ");
      string password = Console.ReadLine();

      if (users.ContainsKey(username) && users[username].ValidatePassword(password))
      {
        System.Console.WriteLine("You are logged in");
      }
      else
      {
        System.Console.WriteLine("Invalid Username or Pass");
      }

    }
  }
}
