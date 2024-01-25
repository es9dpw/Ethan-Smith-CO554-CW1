using System;
using System.Collections;

namespace OTS.Consumers
{
    /// <summary>
    /// This class is responsible for user to logging into the system as well as signing up to the system if they don't already have an account.
    /// </summary>
    public class Consumer
    {
        public bool loggedIn = false;
        string account;
        public string email = ".";
        string password;
        public string name;
        ArrayList emails = new ArrayList();
        ArrayList passwords = new ArrayList();
        ArrayList names = new ArrayList();

        /// <summary>
        /// This method is the main method for this class and it asks to user to select whether they need to sign up or just log in and then calls the appropriate method for the option they selected.
        /// </summary>
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

        /// <summary>
        /// This method is called when the user has selected to log in and prompts them to enter their email and password then checks against currently saved emails and passwords to make sure they match with a login in the system.
        /// It also then pulls their name from the database and into a variable so their name can be used in other classes.
        /// </summary>
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

        /// <summary>
        /// This method is called when the user has selected to sign up and prompts them to enter their email, name and password then adds them all to the system.
        /// </summary>
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