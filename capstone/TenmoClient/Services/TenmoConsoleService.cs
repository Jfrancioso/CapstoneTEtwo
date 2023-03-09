using System;
using System.Collections.Generic;
using TenmoClient.Models;
using TenmoServer.Models;

namespace TenmoClient.Services
{
    public class TenmoConsoleService : ConsoleService
    {
        /************************************************************
            Print methods
        ************************************************************/
        public void PrintLoginMenu()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Welcome to TEnmo!");
            Console.WriteLine("1: Login");
            Console.WriteLine("2: Register");
            Console.WriteLine("0: Exit");
            Console.WriteLine("---------");
        }

        public void PrintMainMenu(string username)
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine($"Hello, {username}!");
            Console.WriteLine("1: View your current balance");
            Console.WriteLine("2: View your past transfers");
            Console.WriteLine("3: View your pending requests");
            Console.WriteLine("4: Send TE bucks");
            Console.WriteLine("5: Request TE bucks");
            Console.WriteLine("6: Log out");
            Console.WriteLine("0: Exit");
            Console.WriteLine("---------");
        }
        public LoginUser PromptForLogin()
        {
            string username = PromptForString("User name");
            if (String.IsNullOrWhiteSpace(username))
            {
                return null;
            }
            string password = PromptForHiddenString("Password");

            LoginUser loginUser = new LoginUser
            {
                Username = username,
                Password = password
            };
            return loginUser;
        }

        // Add application-specific UI methods here...
        public void PrintBalance(decimal balance)
        {
            Console.WriteLine($"Your current balance is: ${balance}");
        }

        public void PrintTransfers(IList<Transfer> transfers)
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Transfers");
            Console.WriteLine("ID\tFrom/To\t\tAmount");
            foreach (Transfer transfer in transfers) 
            {
                Console.WriteLine($"{transfer.TransferId}\t{transfer.AccountFrom}\t{transfer.AccountTo}\t\t{transfer.Amount}");
            }
            Console.WriteLine("-------------------------------------------");

            List<Account> accounts = new List<Account>();
            Account account= new Account();
            
        }

        public void PrintTransferDetails(Transfer transferDetails)
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Transfer Details");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("$Id|{}");
            Console.WriteLine("$From|{}");
            Console.WriteLine("$To|{}");
            Console.WriteLine("$Type|{}");
            Console.WriteLine("$Status|{}");
            Console.WriteLine("$Amount|{}");
            Console.WriteLine("-------------------------------------------");

        }

        //public void PrintRequestingTeBucks(IList<RequestingTeBucks>requestingTeBucks)
        //{
        //    Console.Clear();
        //    Console.WriteLine("-------------------------------------------");
        //    Console.WriteLine("$Please choose an option:{}");
        //    Console.WriteLine("-------------------USERS-------------------");
        //}
    }
}
