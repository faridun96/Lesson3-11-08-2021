using System;

namespace DiscountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление стоимости покупки с учетом скидки.");
            Console.Write("Введите сумму покупки: ");
            double summa = int.Parse(Console.ReadLine());
            if (summa>500 && summa<1000)
            {
                summa=summa*(1 - 0.03);
                Console.WriteLine("Вам предоставлена скидка в размере 3%");
                Console.WriteLine($"Сумма покупки с учетом скидки: {Math.Round(summa,2)}");
            }
            else if (summa>1000) 
            {
                summa=summa*(1 - 0.05);
                Console.WriteLine("Вам предоставлена скидка в размере 5%");
                Console.WriteLine($"Сумма покупки с учетом скидки: {Math.Round(summa,2)}");
            }
            else
            {
                Console.WriteLine("Скидка не предоставляется");
            }
        }
    }
}
