using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var CustomerDetails = new Customer
            {                
                //CustomerDetails.CustomerId = 101;
                CustomerName = "Raymond",
                EmailAddress = "Raymond@test.com",
                PhoneNumber = 1234567890,
            };

            Console.WriteLine($"CustomerId: {CustomerDetails.CustomerId}, CustomerName: {CustomerDetails.CustomerName}, " +
                $"EmaiAddress: {CustomerDetails.EmailAddress}, PhoneNUmber: {CustomerDetails.PhoneNumber}");


            var CustomerDetails2 = new Customer
            {
                CustomerName = "Sofy",
                EmailAddress = "sofy@test.com",
                PhoneNumber = 2594756876
            };


            Console.WriteLine($"CustomerId: {CustomerDetails2.CustomerId}, CustomerName: {CustomerDetails2.CustomerName}, EmailAddress: {CustomerDetails2.EmailAddress}" +
                $"PhoneNumber: {CustomerDetails2.PhoneNumber}");

            Console.ReadLine();

        }
    }
}
