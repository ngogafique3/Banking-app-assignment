using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            string firstname;
            string lastname;
            string gender;
            firstname = Console.ReadLine();
            cust.setFirstName(firstname);
            lastname = Console.ReadLine();
            cust.setLastName(lastname);
            gender = Console.ReadLine();
            cust.setGender(gender);

            int account_number;
            string account_type;
            string currency;

            account_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Account number");
            account_type = Console.ReadLine();
            currency = Console.ReadLine();
            
            Account acc = new Account(account_number, account_type, currency);
                
            Console.WriteLine("Enter amount to deposit");
            double depositAmount;
            depositAmount = Convert.ToDouble(Console.ReadLine());
            acc.deposit(depositAmount);
               
            Console.WriteLine("Enter amount to withdraw");
            double withdrawAmount;
            withdrawAmount = Convert.ToDouble(Console.ReadLine());
            acc.withdraw(withdrawAmount);
              
        }
        
    }
    }