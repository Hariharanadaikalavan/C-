using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Company_Address_Book
{
    public class User
    {
        private string _Name;
       public string Address { get; set; }
        public string PhoneNumber { get; set; }

        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value));
                }
                _name = value;
            }
        }

    }
    internal class MainMethod
    {
        private static List<User> addressBook = new List<User>();
        static void Main(string[] args)
        {
            bool ProgramIsRunning = true;
            

            Console.WriteLine("-----------------Welcome to AdressBook 1.0 ------------------");

            while (ProgramIsRunning)
            {
                // Print user options
                Console.WriteLine();
                PrintUserOptions();
                Console.WriteLine();
                int userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Now,You are logged in to user platform you can \"Create a User\" ");
                        CreateUser();
                        break;
                    case 2:
                        Console.WriteLine("updateuserinformation");
                        UpdateUserInformation();
                        break;
                    case 3:
                        Console.WriteLine("RemovePersonfromlist");
                        RemovePersonFromList();
                        break;
                    case 4:
                        Console.WriteLine("Showallpersonsinlist");
                        ShowAllPersonsInList();
                        break;
                    case 5:
                        Console.WriteLine("Thanks for visiting...");
                        ProgramIsRunning = false;
                        break;
                }
            }
        }
        //-----------------------------------print user option-----------------------------------------//
        private static void PrintUserOptions()
        {
            Console.WriteLine("Choose one of the following options: ");
            Console.WriteLine("#1 Create new user");
            Console.WriteLine("#2 Edit user information");
            Console.WriteLine("#3 Delete existing user");
            Console.WriteLine("#4 Show all users in adressBook");
            Console.WriteLine("#5 Exit from Program");
        }
        // -----------------------------------------------------------------------------------------------------

        // ------------------------------Creating user method ------------------------------------------//
        private static void CreateUser()
        {
           
            Console.Write("Enter user name:");
            string name = Console.ReadLine();

            Console.Write("Enter user address:");
            string address = Console.ReadLine();

            Console.Write("Enter user phone number:");
            string phoneNumber = Console.ReadLine();

            addressBook.Add(new User { Name = name, Address = address, PhoneNumber = phoneNumber });

            Console.Write("Adding Details into Database(SQL Server) in progression");
            for(int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.Write(".");
            }
            Console.WriteLine();    
            Console.WriteLine("User added successfully.");
            display();
        }

        //----------------------------------------------------------------------------------------------------

        //-----------------------------------------UpdateUserInformation--------------------------------------
        private static void UpdateUserInformation()
        {
            Console.WriteLine("Enter the name of the user you want to edit:");
            string name = Console.ReadLine();

            User user = addressBook.Find(u => u.Name.Equals(name));
            if (user != null)
            {
                Console.Write("Enter new address:");
                user.Address = Console.ReadLine();

                Console.Write("Enter new phone number:");
                user.PhoneNumber = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("User information updated successfully.");
                display();
            }
            else
            {
                Console.WriteLine("User not found.");
                display ();
            }
        }
        //---------------------------------------------------------------------------------------//

        //--------------------------------RemovePersonFromList------------------------------------//
        private static void RemovePersonFromList()
        {
            Console.WriteLine("Enter the name of the user you want to delete:");
            string name = Console.ReadLine();

            User user = addressBook.Find(u => u.Name.Equals(name));
            if (user != null)
            {
                addressBook.Remove(user);
                Console.WriteLine("User deleted successfully.");
                display() ;
            }
            else
            {
                Console.WriteLine("User not found.");
                display (); 
            }
        }
        //------------------------------------------------------------------------------------------
        //---------------------------------------ShowAllPersonsInList-------------------------------

        private static void ShowAllPersonsInList()
        {
            if (addressBook.Count > 0)
            {
                Console.WriteLine("List of users in address book:");
                foreach (var user in addressBook)
                {
                    Console.WriteLine($"Name: {user.Name}, Address: {user.Address}, Phone Number: {user.PhoneNumber}");
                }
                display();
            }
            else
            {
                Console.WriteLine("Address book is empty.");
                display();
            }
           

        }
        //------------------------------------------------------------------------------------------

        public static void display()
        {
            Console.WriteLine("-----------------------------Thanks For Using Our Services-----------------------------");
         }
    }
}
