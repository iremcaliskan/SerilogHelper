using LogHelper.Logging.Concrete;
using System;

namespace LogTestDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer()
            {
                Id = 1,
                FirstName = "İrem",
                LastName = "Çalışkan",
                CreationDate = DateTime.Now
            };
            //LoggerFactory.FileLogManager().Information("Information Log başlıyorrr!");
            //LoggerFactory.FileLogManager().Information("The {@Customer} is created on {CreationDate}", customer, DateTime.Now);

            try
            {
                if (customer.CreationDate != DateTime.Now)
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                //LoggerFactory.FileLogManager().Error("Error Log başlıyorrr!");
                //LoggerFactory.FileLogManager().Error("Addition of {@Customer} encountered an error: {@Exception}", customer, e);
                //throw;
            }
        }
    }
}
