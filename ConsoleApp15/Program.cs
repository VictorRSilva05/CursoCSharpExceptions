using ConsoleApp15.Exceptions;
using ConsoleApp15.Entities;
namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data:");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double initialBalance = double.Parse(Console.ReadLine());
            Console.Write("Withdrawl limit: ");
            double withdrawlLimit = double.Parse(Console.ReadLine());

            Account account = new Account(number,holder,initialBalance,withdrawlLimit);

            Console.Write("\nEnter amount for withdraw: ");
            account.Withdraw(double.Parse(Console.ReadLine()));

            Console.WriteLine("New balance: " + account.Balance);
        }
    }
}
