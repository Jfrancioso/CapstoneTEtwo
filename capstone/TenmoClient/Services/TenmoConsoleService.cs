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
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Transfers");
            Console.WriteLine("ID\t|\tFrom\t|\tTo\t|\tAmount");
            Console.WriteLine("--------------------------------------------------------");
            foreach (Transfer transfer in transfers)
            {
                Console.WriteLine($"{transfer.TransferId}\t|\t{transfer.AccountFrom}\t|\t{transfer.AccountTo}\t|\t{transfer.Amount:C}");
            }
            Console.WriteLine("--------------------------------------------------------");
        }

        public void PrintTransferDetails(Transfer transferDetails, string otherUsername, Account account, string loginUser)
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Transfer Details");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Id\t|{transferDetails.TransferId}");
            if (account.AccountId == transferDetails.AccountFrom)
            {
                Console.WriteLine($"From\t|{loginUser}");
                Console.WriteLine($"To\t|{otherUsername}");
            }
            else
            {
                Console.WriteLine($"From\t|{otherUsername}");
                Console.WriteLine($"To\t|{loginUser}");
            }
            Console.WriteLine($"Type\t|{transferDetails.TransferTypeId}");
            Console.WriteLine($"Status\t|{transferDetails.TransferStatusId}");
            Console.WriteLine($"Amount\t|{transferDetails.Amount:C2}");
            Console.WriteLine("-------------------------------------------");

        }
        public void PrintSendingBucks(IList<ApiUser> users)
        {
            Console.Clear();
            Console.WriteLine("|-------------------USERS-------------------|");
            Console.WriteLine("|    ID | Username                          |");
            Console.WriteLine("|-------------------------------------------|");
            foreach (ApiUser user in users)
            {
                Console.WriteLine($"|  {user.UserId} | {user.Username}");
            }
            Console.WriteLine("|-------------------------------------------|");
        }
        public void PrintRequestingBucks(IList<Transfer> transfers)
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("$Please choose an option:{}");
            Console.WriteLine("-------------------USERS-------------------");
            Console.WriteLine("ID\t|\tUsername\t");
            Console.WriteLine("-------------------------------------------");
            List<Account> accounts = new List<Account>();
            Account account = new Account();
        }
    }
}
