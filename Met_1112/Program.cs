using System;
using System.Reflection;

namespace Met_1112
{
    class Counter
    {
        public delegate void Container();

        public event Container count;

        public void Count()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 71)
                {
                    count();
                }
            }
        }
    }

    class Handler
    {
        public void Message()
        {
            Console.WriteLine("Точно, уже 71!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // пример рефликсии
            Assembly assembly = Assembly.Load("Les_0412");
            Console.WriteLine(assembly.GetTypes()[1]);
            Console.WriteLine(assembly.GetName());
            Console.WriteLine(assembly.GetHashCode());

            // пример событий
            Counter counter = new Counter();
            Handler handler = new Handler();
            counter.count += handler.Message;
            counter.Count();

            // использование атрибутов
            Rational rational = new Rational();
            Type typeInfo = typeof(Rational);
            object[] attrs = typeInfo.GetCustomAttributes(false);            
            Console.WriteLine((attrs[0] as DeveloperInfoAttribute).DateOfRelease);

            BankAccount bankAccount = new BankAccount();
            bankAccount.DumpToScreen();

            Console.ReadLine();
        }
    }
}
