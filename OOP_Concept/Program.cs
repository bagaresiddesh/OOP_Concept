using System;

namespace OOP_Concept
{
    public class User
    {
        private int userId { get; set; }
        private string password { get; set; }
        public void VerifyLogin()
        {

        }
    }

    public class Customer : User
    {
        public Customer(string name, string mail)
        {
            this.customerName = name;
            this.cMail = mail;
        }
        public string customerName { get; set; }
        public string cMail { get; set; }
        private string cardNo { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine("Customer Details");
            Console.WriteLine("Customer Name : ", this.customerName);
            Console.WriteLine("Customer Mail : ", this.cMail);
        }
    }

    public class Admin : User
    {
        public Admin(string name, string mail)
        {
            this.adminName = name;
            this.aMail = mail;
        }
        public string adminName { get; set; }
        public string aMail { get; set; }

        public void UpdateCatlog()
        {

        }
    }
    public class Program
    {
        public static void Main()
        {
            Admin A = new Admin("Rahul", "abc@gmail.com");
            
            Customer C = new Customer("Ramesh", "xyz@gmail.com");

            //downcasting
            User C2 = new Customer("Suresh", "mno@gmail.com");
            User A2 = new Admin("Jay", "ijk@gmail.com");

            //upcasting not allowed
            //Customer c3 = new User();
            //Admin A3 = new User();

            Console.ReadLine();

        }
    }
}

