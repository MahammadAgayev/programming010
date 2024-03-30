using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Xml;

namespace programming011.reflection
{
    class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }


    public class Order
    {
        public int Id { get; set; }

        public DateTime Created { get; set; }
        public DateTime BookDate { get; set; }
        public string ProductName { get; set; }
        public decimal Amount { get; set; }
    }
    class AccountService
    {
        public EventHandler<Account> OnAccountChanged;

        public void UpdateAccountInfo(Account account)
        {


            //replicateAccount()
            OnAccountChanged.Invoke(this, account);
        }

        public void DeleteAccount(Account account)
        {

            //replicateAccount()
            OnAccountChanged.Invoke(this, account);
        }

        public void ChangePassword(Account account)
        {
            //some code to change password


            //replicateAccount()
            OnAccountChanged.Invoke(this, account);
        }
    }


    class MoneyTransfer
    {
        public EventHandler<EventArgs> TransferCompleted { get; set; }


        public void Transfer(string accountA, string accountB)
        {
            Console.WriteLine($"Money is transferring from {accountA} to {accountB}");

            //HandleSubscriptions(accountB);
            TransferCompleted?.Invoke(this, new EventArgs());
        }

        public void HandleSubscriptions(string accountB)
        {
            //check if subscriber has subscription
            Console.WriteLine("Customer's balance deducted due to subscription");
        }
    }


    class CsvWriter
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //chareogrpahy

            //MoneyTransfer m = new MoneyTransfer();
            //m.TransferCompleted += (o, e) =>
            //{
            //    Console.WriteLine("I have been informed that transfer is completed");
            //};

            //m.Transfer("123456", "1124111");

            ////reflection
            ////Csv - Comma separated values
            ////
            Account a = new Account
            {
                Id = 1,
                Username = "mahammad",
                Password = "12345"
            };
            //1,mahammad,12345

            Account[] accounts = new Account[] { a,

                new Account
                {
                    Id = 2,
                    Username = "Javid J. Aliyev"
                },
                new Account
                {
                    Id = 3,
                    Username = "ilkin"
                },
            };


            //ExportCsv(accounts);

            Order[] orders = new Order[]
            {
                new Order
                {
                    Id = 1,
                    Amount = 50,
                    ProductName = "Test",
                    BookDate = DateTime.Now.AddDays(2),
                    Created = DateTime.Now
                },
                new Order
                {
                    Id = 2,
                    Amount = 139,
                    ProductName = "Keyboards",
                    BookDate = DateTime.Now.AddDays(30),
                    Created = DateTime.Now
                }
            };

            //ExportCsv(orders);

            //reflection

            //Don't shoot your leg

            //ListProperties(new Account());
            //ListProperties(new Order());

            ExportCsv(orders, @"C:\Users\magayev\Downloads\orders.csv");

        }

        static void ListProperties(object o)
        {
            Type t = o.GetType();

            //Console.WriteLine(t.FullName);

            PropertyInfo[] properties = t.GetProperties();

            foreach (var item in properties)
            {
                Console.WriteLine(item.Name);
            }
        }


        static void ExportCsv(object[] objects, string filename)
        {
            if (objects.Length == 0)
            {
                throw new Exception("There should at least one data");
            }

            object o = objects[0];

            Type t = o.GetType();

            StringBuilder b = new StringBuilder();

            bool isFirst = true;

            PropertyInfo[] props = t.GetProperties();

            foreach (var prop in props)
            {
                if (isFirst)
                {
                    isFirst = false;
                }
                else
                {
                    b.Append(",");
                }

                b.Append(prop.Name);
            }

            b.AppendLine();

            foreach (var obj in objects)
            {
                bool lIsFirst = true;
                foreach (var prop in props)
                {
                    if (lIsFirst)
                    {
                        lIsFirst = false;
                    }
                    else
                    {
                        b.Append(",");
                    }

                    if (prop.PropertyType.Name == "DateTime")
                    {
                        object value = prop.GetValue(obj);
                        DateTime dateValue = (DateTime)value;

                        b.Append($"{dateValue:yyyy-MM-dd}");
                    }
                    else
                    {
                        b.Append(prop.GetValue(obj));
                    }

                }

                b.AppendLine();
            }

            File.WriteAllText(filename, b.ToString());
        }


        //static void ExportCsv(Order[] orders)
        //{
        //    StringBuilder sb = new StringBuilder();

        //    sb.AppendLine("Id,Product,Amount,BookDate,CreationDate");

        //    foreach(var o in orders)
        //    {
        //        sb.AppendLine($"{o.Id},{o.ProductName},{o.Amount},{o.BookDate:yyyy-MM-dd},{o.Created:yyyy-MM-dd}");
        //    }

        //    File.WriteAllText(@"C:\Users\magayev\Downloads\orders.csv", sb.ToString());
        //}

        //static void ExportCsv(Account[] accounts)
        //{
        //    StringBuilder sb = new StringBuilder();

        //    sb.AppendLine("Id,Username");
        //    foreach (var item in accounts)
        //    {
        //        sb.AppendLine($"{item.Id},{item.Username}");
        //    }

        //    File.WriteAllText( @"C:\Users\magayev\Downloads\accounts.csv", sb.ToString());
        //}
    }
}