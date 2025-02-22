using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ReviewSession_3
{
        //Q-3
        //3.1).Banking System
        //Create a custom exception called InsufficientFundsException.
        //Write a banking application where :A user can withdraw money.
        //Throw InsufficientFundsException if the balance is less than the withdrawal amount.

    public class BankSystem
    {
        static Double Balance = 50000;

        public void Withdraw(double amount)
        {
            try
            {
                if (amount > Balance)
                {
                    throw new InsufficientFundsException("Insufficient balance!");
                }
                Balance -= amount;
                Console.WriteLine($"Withdrawal successful! New balance: {Balance}");

            }
            catch (InsufficientFundsException ex)
            {

                Console.WriteLine($"Error Message : {ex.Message}");
            }

        }
    }
}
