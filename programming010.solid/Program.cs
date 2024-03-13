using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace programming010.solid
{
    //class OrderService
    //{
    //    public void Checkout()
    //    {
    //        //unitofWork.OrderRepository.Add()

    //        //PayWithCard
    //    }

    //    //public void Place()
    //    //{
    //    //    //unitofWork.OrderRepository.Add()
    //    //}

    //    //public void Pay()
    //    //{
    //    //    //PayWithCard
    //    //}
    //}


    //class OrderServiceV2
    //{
    //    public void Place()
    //    {

    //    }
    //}

    //class PaymentService
    //{
    //    public void Pay()
    //    {

    //    }
    //}

    //Open/Closed principle
    //class SqlBookRepository
    //{
    //    public void Add(BookEntity book)
    //    {
    //        //sql server to add to db -> postgre to add to db
    //        //above change creates bugs at a lot of cases
    //    }
    //}

    //class PostgreBookRepository
    //{
    //    public void Add(BookEntity book)
    //    {
    //        //new postgre to add
    //    }
    //}
    
    //class BookEntity : IEntity
    //{
    //    public int Id { get; set; } 
    //    public string Name { get; set; }
    //}

    //interface IEntity
    //{
    //    int Id { get; set; }
    //}


    abstract class Animal
    {
        public virtual void Walk()
        {
            Console.WriteLine("common walking code");
        }
        public virtual void Eat()
        {
            Console.WriteLine("common eating code");
        }
        //As all animals cannot fly this method vialotes Liskov's substitution principle
        //public abstract void Fly();
    }

    interface IFlyable
    {
        void Fly();
    }

    class Bird : Animal, IFlyable
    {
        public virtual void Fly()
        {
            Console.WriteLine("Common fly method");
        }
    }

    class Eagle : Bird
    {

        //code reused from Bird class
        //public void Fly()
        //{
        //    throw new NotImplementedException();
        //}
    }

    class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("I'm eating");
        }

        //public void Fly()
        //{
        //    throw new NotSupportedException("Cats cannot fly");
        //}

        public override void Walk()
        {
            Console.WriteLine("I'm walking");
        }
    }

    //interface ITextLogger
    //{

    //}

    //interface ILogRotator
    //{

    //}

    //interface ILogDeleter
    //{

    //}

    //class Logger
    //{
    //    void Log()
    //    {
    //        //flush()
    //    }

    //    void Rotate()
    //    {
    //        //zipping
    //    }

    //    void Retention()
    //    {
    //        //delete old log files
    //    }
    //}

    //God interface, God service
    //interface seggragation
    interface IPrinter
    {
        void Print();
    }

    interface IColorablePrint
    {
        void ColoredPrint();
    }

    class PrinterA : IPrinter, IColorablePrint
    {
        public void ColoredPrint()
        {
            Console.WriteLine("colored print");
        }

        public void Print()
        {
            Console.WriteLine("print");
        }
    }

    class PrinterB : IPrinter
    {

        public void Print()
        {
            Console.WriteLine("print");
        }
    }

    class OrderService
    {
        private readonly IPaymentService _paymentService;

        //Dependency Injection
        public OrderService(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void Checkout()
        {
            //Save to database
            //Pay
            _paymentService.Pay(100, "1234567");

            //coupling
        }
    }

    interface IPaymentService
    {
        void Pay(decimal amount, string cardNumber);
    }

    class GooglePaymentService : IPaymentService
    {
        public void Pay(decimal amount, string cardNumber)
        {
            Console.WriteLine($"{amount} amount deducted from customer balance");
        }
    }

    class YandexPaymentService : IPaymentService
    {
        public void Pay(decimal amount, string cardNumber)
        {
            Console.WriteLine($"{amount} amount deducted from customer balance");
        }
    }

    class GoogleRandom : IRandomizer
    {
        public int Next(int a, int b)
        {
            return 0;
        }
    }


    class YandexRandom : IRandomizer
    {
        public int Next(int a, int b)
        {
            return 0;
        }
    }

    interface IRandomizer
    {
        int Next(int a, int b);
    }

    class DataRandomizer
    {
        private readonly IRandomizer _rand;
        private readonly int[] _data;

        public DataRandomizer(int[] data, IRandomizer rand)
        {
            _rand = rand;
            _data = data;
        }

        public int GetNext()
        {
            int index = _rand.Next(0, _data.Length);

            return _data[index];
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //SOLID
            //S - single responsibility

            /*
             * O - Open/Closed - principle
             * close to change, open to enlarge
             * code refactoring -> optimize old code
             */

            //sql server
            //postgresql - open source

            //BookRepository repo = new BookRepository();
            //repo.Add(new BookEntity { Id = 1, Name = "Nargin" });

            /*
             * L -> Liskov's substitution principle
             */

            /*
             * I - interface segragation 
             * Abstraction God
             * 
             */

            /*
             * D - Dependency Inversion
             */

            //IPaymentService paymentService = new YandexPaymentService();
            //OrderService orderService = new OrderService(paymentService);

            //orderService.Checkout();

            //Dependency injection
            int[] arr = { 20, 10, 30, 1500, 1600, 2000, 0, -200 };

            IRandomizer rand = new GoogleRandom();
            DataRandomizer randomizer = new DataRandomizer(arr, rand);

            Console.WriteLine(randomizer.GetNext());
            Console.WriteLine(randomizer.GetNext());

            /*
             *  Concrete Depedency
             *  OrderService -> PaymentService
             * 
             *  Inversion of dependency
             *  OrderService -> IPaymentService <- PaymentService
             */

            //Code design
        }
    }
}
