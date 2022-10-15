using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha2
{
    class Program
    {
        static void Main()
        {
            int n;
            Random rnd = new Random();
            Console.WriteLine("Введите n>");
            n= Convert.ToInt32(Console.ReadLine()); 
            //создаем и выводим первый массив
            int[] ar = new int[n];
            Console.Write("Первый массив: ");
            for (int i=0;i<n;i++)
            {
                ar[i] = rnd.Next(1, 20);
                Console.Write(ar[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
            //создаем и выводим второй массив
            int[] ar1 = new int[n];
            Console.Write("Первый массив: ");
            for (int i=0;i<n;i++)
            {
                ar1[i] = rnd.Next(1, 20);
                Console.Write(ar1[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
            //ищем первый подходящий элемент
            int flag=0, k=0, m=100, km=100;
            while ((flag==0) & (k<n))
            {
                if (Array.Find(ar1, a=>a==ar[k]) == 0)
                {
                    flag=1;
                    m=ar[k];
                    km=k;
                }
                k++;      
            }
            //ищем минимум среди всех подходящих элементов
            if(m<100)
            { 
                for(int i=km+1;i<n;i++)
                {
                    if (Array.Find(ar1, a=>a==ar[i]) == 0)
                    {
                        if(ar[i]<m)
                        {
                            m=ar[i];
                        }
                    }
                }
                Console.Write(m);
            }
            else 
                Console.Write("Нет подходящих элментов");

            Console.ReadKey();
        }
    }
}