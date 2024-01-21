using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace OTS.Consumers
{
    /// <summary>
    /// 
    /// </summary>
    public class Consumer
    {
        bool exit = false;
        bool LoggedIn = false;
        string account;
        public string email;
        public string password;
        public string name;
        public ArrayList emails = new ArrayList();
        public ArrayList passwords = new ArrayList();
        public ArrayList names = new ArrayList();

        public void Run()
        {
            Console.Write("Please select Log In or Sign Up.\n1. Log In\n2. Sign Up");
            account = Console.ReadLine();
           
            while (exit == false){
                if (string.Equals(account, "1") || string.Equals(account, "Log In")){
                    LogIn();
                    exit = true;
                }
                else if (string.Equals(account, "2") || string.Equals(account, "Sign Up")){
                    SignUp();
                    exit = true;
                }
                else{
                    Console.WriteLine("Invalid option, please try again.");
                }
            }
        }

        public void LogIn()
        {
            while (LoggedIn == false){
                Console.Write("Please enter your email: ");
                email = Console.ReadLine();
                Console.Write("Please enter your password: ");
                password = Console.ReadLine();
                for(int i = 0 ; i < emails.Count; i++){
                    if (emails[i] == email & passwords[i] == password){
                        name = names[i].ToString();;
                        Console.WriteLine("You have logged in.\n");
                        LoggedIn = true;
                        break;
                    }
                }
                if (LoggedIn == false){
                    Console.WriteLine("Email or password is invalid, Please try again.");
                }
            }
        }

        public void SignUp()
        {
            Console.Write("Please enter your email: ");
            emails.Add(Console.ReadLine());
            Console.Write("Please enter your password: ");
            passwords.Add(Console.ReadLine());
            Console.Write("Please enter your name: ");
            names.Add(Console.ReadLine());
            Console.WriteLine("Your account was created and you bave been logged in.\n");
            LoggedIn = true;
        }
    }
}