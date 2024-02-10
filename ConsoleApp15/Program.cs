using ConsoleApp15.Exceptions;
using ConsoleApp15.Entities;
using System.Globalization;
using System.Security.Principal;
namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            try
            {
                Console.WriteLine("Enter account data:");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdrawl limit: ");
                double withdrawlLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account = new Account(number, holder, initialBalance, withdrawlLimit);

                Console.Write("\nEnter amount for withdraw: ");
                account.Withdraw(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

                Console.WriteLine("New balance: " + account.Balance);
            }
            catch (DomainException ex)
            {
                Console.WriteLine("Withdraw error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: " + ex.Message);
            }      
        }
    }
}
