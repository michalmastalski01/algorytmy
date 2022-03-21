using System;

namespace lab3
{
    public class CashRegister
    {
        static readonly int one = 0;
        static readonly int two = 1;
        static readonly int five = 2;

        private readonly int[] coins = new int[3];

        private int[] restTable = new int[3];

        public CashRegister(int[] coins)
        {
            this.coins = coins;
        }

        public int[] Payment(int[] income, int amount)
        {
            if(amount > getAmount(income))
            {
                return new int[] { };
            }
            int rest = getRemainder(income, amount);
            registerCash(income);
            return calculateRest(rest, restTable);
        }

        private int[] calculateRest(int rest, int[] result)
        {
            if(rest >= 5)
            {
                if(rest % 5 == 0)
                {
                    result[five] = rest / 5;
                    return result;
                }
                else
                {
                    result[five] = rest / 5;
                    return calculateRest(rest - result[five]*5, result);
                }
            }
            if(rest < 5 && rest >= 2)
            {
                if (rest % 2 == 0)
                {
                    result[two] = rest / 2;
                    return result;
                }
                else
                {
                    result[two] = rest / 2;
                    return calculateRest(rest - result[two]*2, result);
                }
            }
            if(rest <= 1)
            {
                result[one] = 1;
                return result;
            }
            return result;
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
            int[] coins = { 5, 2, 3 };
            int[] income = { 3, 5, 3 };
            CashRegister payment = new CashRegister(coins);
            int[] result = payment.Payment(income, 12);

            Console.WriteLine($"złotówki: {result[0]}, dwu-złotówki: {result[1]}, piątki: {result[2]}");
        }
    }
}
