using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {

           double sum = 0;//сумма
            int n = 1;//количество проходов
            double temp;//предыдущий результат, для проверки точности
            
            do
            {
                temp = sum;
                sum += Math.Pow((-1), n + 1) / Math.Pow(2*n, 3);
                n++; 
            }
            while (Math.Abs (sum-temp) > 0.001);
            Console.WriteLine("Сумма ряда: " + sum );
            Console.ReadLine();
        }
       
    }
}