using System;

namespace DebitCredit
{
    public class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(50000.00);

            bool finished = false;

            do
            {
                int option;

                Console.WriteLine("App for a Debit/Credit operation\n");
                Console.WriteLine("Account balance: " + account.Balance());
                Console.WriteLine("1 - Debit");
                Console.WriteLine("2 - Credit");
                Console.WriteLine("3 - Exit");
                Console.Write("Choose your action: ");
                option = Int32.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        {
                            double debitAmount;
                            bool debited = false;
                            do
                            {
                                Console.Write("Enter the amount to debit: ");
                                debitAmount = Double.Parse(Console.ReadLine());

                                if(account.debitBalance(debitAmount) == 1)
                                    debited = true;
                            } while (!debited);
                            break;
                        }
                    case 2:
                        {
                            double creditAmount;
                            bool credited = false;
                            do
                            {
                                Console.Write("Enter the amount to credit: ");
                                creditAmount = Double.Parse(Console.ReadLine());
                                if(account.creditBalance(creditAmount) == 1)
                                    credited = true;
                            } while (!credited);
                            break;
                        }
                    case 3:
                        {
                            finished = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid character! Choose another option");
                            break;
                        }
                }

            } while (!finished);
        }
    }
}
