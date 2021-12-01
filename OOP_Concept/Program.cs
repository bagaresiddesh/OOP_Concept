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

    public class Customer:User
    {
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

    public class Admin:User
    {
        public Admin(string name,string mail)
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
        public static void main()
        {
            Admin Ad = new Admin("rahul","abc@gmail.com");

            
        }
    }
}
