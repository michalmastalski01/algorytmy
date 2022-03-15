using System;

namespace lab3
{
    public class CashRegister
    {
        static readonly int one = 0;
        static readonly int two = 1;
        static readonly int five = 2;

        private readonly int[] coins = new int[3];

        public CashRegister(int[] coins)
        {
            this.coins = coins;
        }

        int[] Payment(int[] income, int amount)
        {
            if(amount > getAmount(income))
            {
                return new int[] { };
            }
            int rest = getRemainder(income, amount);
            registerCash(income);
            return calculateRest(rest);
        }

        private int[] calculateRest(int rest)
        {

        }

        private int getAmount(int[] coins)
        {
            return coins[one] + (coins[two] * 2) + (coins[five] * 5);
        }

        private int getRemainder(int[] income, int amount)
        {
            return getAmount(income) - amount;
        }

        private void registerCash(int[] income)
        {
            coins[one] += income[one];
            coins[two] += income[two];
            coins[five] += income[five]; 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(fibonacci(42));
            Console.WriteLine(sinus(90));
        }
        static public long fibonacci(int n)
        {
            long[] tab = new long[n];
            Array.Fill<long>(tab, -1);
            return fib(n, tab);
        }
        static private long fib(int n, long[] mem)
        {
            if(n < 0)
            {
                throw new ArgumentException();
            }
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }

            if(mem[n-1] == -1)
            {
                mem[n - 1] = fib(n - 1, mem);
            }
            if(mem[n-2] == -1)
            {
                mem[n - 2] = fib(n - 2, mem);
            }

            //Console.WriteLine($"f({n}) = f({n - 1}) + f({n - 2})");
            return mem[n-1] + mem[n-2];
        }

        static public double sinus(int i)
        {
            return (Math.PI * i)/(180*Math.PI);
        }
    }
    /*class SinTable
    {
        private double[] sinTable;
        static SinTable()
        {

        }
        
        public static double Sin(int degree)
        {

        }
    }*/
}
