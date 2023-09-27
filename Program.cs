using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      // initial variables (requirements)
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "0123456789";
      string specialChar = "*";
      int score = 0;

      // asking a password
      Console.WriteLine("Please enter a password: ");
      string pw = Console.ReadLine();

      // adding 1 point to the score if a requirement is met
      if (pw != "0") {
        if (pw.Length >= minLength) {
        score += 1;
        }
        if (Tools.Contains(pw, uppercase)) {
          score += 1;
        }
        if (Tools.Contains(pw, lowercase)) {
          score += 1;
        }
        if (Tools.Contains(pw, digits)) {
          score += 1;
        }
        if (Tools.Contains(pw, specialChar)) {
          score += 1;
        }
      } 
      else 
      {
        score = 0;
      }
      
      // telling the user the password's strength
      switch (score) {
        case 5:
          Console.WriteLine($"Your password's score is {score}, which means your password's rating is extremely strong.");
          break;
        case 4:
          Console.WriteLine($"Your password's score is {score}, which means your password's rating is extremely strong.");
          break;
        case 3:
          Console.WriteLine($"Your password's score is {score}, which means your password's rating is strong.");
          break;
        case 2:
          Console.WriteLine($"Your password's score is {score}, which means your password's rating is medium.");
          break;
        case 1:
          Console.WriteLine($"Your password's score is {score}, which means your password's rating is weak.");
          break;
        default:
          Console.WriteLine($"Your password's score is {score}, which means your password's rating is invalid.");
          break;
      }
    }
  }
}
