using System;

namespace OOP_Concept
{
    public class User
    {
        private int Id { get; set; }
        private string Password { get; set; }
        public void VerifyLogin()
        {

        }
    }

    public class Customer : User
    {
        public Customer(string name, string mail)
        {
            this.Name = name;
            this.Mail = mail;
        }
        public string Name { get; set; }
        public string Mail { get; set; }
        private string CardNo { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine("Customer Details");
            Console.WriteLine("Customer Name : ", this.Name);
            Console.WriteLine("Customer Mail : ", this.Mail);
        }
    }

    public class Admin : User
    {
        public Admin(string name, string mail)
        {
            this.Name = name;
            this.Mail = mail;
        }
        public string Name { get; set; }
        public string Mail { get; set; }

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

