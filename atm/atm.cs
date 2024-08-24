using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace atm
{
    class atm
    {
        static void Main(string[] args)
        {
            decimal balance = 1000.00m;  // Initial balance of ₱1000.00
            bool run = true;

            while (run)
            {
                Console.Clear();
                Console.WriteLine("ATM Simulation");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":  // Check Balance
                        Console.WriteLine($"Your current balance is: ₱{balance:F2}");
                        break;

                    case "2":  // Deposit Money
                        Console.Write("Enter the amount to deposit: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount) && depositAmount > 0)
                        {
                            balance += depositAmount;
                            Console.WriteLine($"You have successfully deposited ₱{depositAmount:F2}. Your new balance is ₱{balance:F2}.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid deposit amount. Please enter a positive number.");
                        }
                        break;

                    case "3":  // Withdraw Money
                        Console.Write("Enter the amount to withdraw: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount) && withdrawAmount > 0)
                        {
                            if (withdrawAmount <= balance)
                            {
                                balance -= withdrawAmount;
                                Console.WriteLine($"You have successfully withdrawn ₱{withdrawAmount:F2}. Your new balance is ₱{balance:F2}.");
                            }
                            else
                            {
                                Console.WriteLine("Insufficient funds for this withdrawal.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid withdrawal amount. Please enter a positive number.");
                        }
                        break;

                    case "4":  // Exit
                        run = false;
                        Console.WriteLine("Thank you for using the ATM. Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please select a valid option from the menu.");
                        break;
                }

                if (run)
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }
    }
}

