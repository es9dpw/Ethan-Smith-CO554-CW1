using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections;
using System.Linq;

namespace OTS.Consumers
{
    /// <summary>
    /// 
    /// </summary>
    public class Consumer
    {
        bool loggedIn = false;
        string account;
        public string email = ".";
        public string password;
        public string name;
        public ArrayList emails = new ArrayList();
        public ArrayList passwords = new ArrayList();
        public ArrayList names = new ArrayList();

        public void Run()
        {
            while (loggedIn == false){
                Console.Write("Please select Log In or Sign Up.\n1. Log In\n2. Sign Up");
                account = Console.ReadLine();

                if (string.Equals(account, "1") || string.Equals(account, "Log In")){
                    LogIn();
                }
                else if (string.Equals(account, "2") || string.Equals(account, "Sign Up")){
                    SignUp();
                }
                else{
                    Console.WriteLine("Invalid option, please try again.");
                }
            }
        }

        public void LogIn()
        {
            Console.Write("Please enter your email: ");
            email = Console.ReadLine();
            Console.Write("Please enter your password: ");
            password = Console.ReadLine();
            for(int i = 0 ; i < emails.Count; i++){
                if (string.Equals(emails[i], email) & string.Equals(passwords[i], password)){
                    name = names[i].ToString();;
                    Console.WriteLine("You have logged in.\n");
                    loggedIn = true;
                    break;
                }
            }
            if (loggedIn == false){
                Console.WriteLine("Email or password is invalid, Please try again.\n");
            }
        }

        public void SignUp()
        {
            while (email.Contains("@") == false){
                Console.Write("Please enter your email: ");
                email = Console.ReadLine();
                if (email.Contains("@") == false){
                    Console.WriteLine("Email is not valid, please try again");
                }
            }
            emails.Add(email);
            Console.Write("Please enter your password: ");
            password = Console.ReadLine();
            passwords.Add(password);
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            names.Add(name);
            Console.WriteLine("Your account was created and you have been logged in.\n");
            loggedIn = true;
        }
    }
}