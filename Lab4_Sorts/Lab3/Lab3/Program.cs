using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            IComparable[] arr = new IComparable[10];

            Console.WriteLine("BubbleSort");
            arr = randomizeArray(arr.Length, "char");
            writeArray(arr);
            BubbleSort(arr);
            Console.WriteLine("");

            Console.WriteLine("InsertSort");
            arr = randomizeArray(arr.Length, "char");
            writeArray(arr);
            InsertSort(arr);
            Console.WriteLine("");

            Console.WriteLine("ShellSort");
            arr = randomizeArray(arr.Length, "char");
            writeArray(arr);
            ShellSort(arr);
            Console.WriteLine("");


            Console.ReadKey();

        }

        static IComparable[] randomizeArray(int length, string type) //char or int
        {
            Random rnd = new Random();
            IComparable[] outarr = new IComparable[length];
            for (int i = 0; i < length; i++)
            {
                if (type != "char")
                {
                    outarr[i] = rnd.Next(101);
                }
                else
                {
                    outarr[i] = (char)('a' + rnd.Next(0, 26));
                }
            }
            return outarr;
        } //Возвращает случайный массив

        static void writeArray(IComparable[] inarr)
        {
            for (int i = 0; i < inarr.Length; i++)
            {
                Console.Write(Convert.ToString(inarr[i]) + ' ');
            }
        } //Вывести массив в консоль

        static bool ifSorted(IComparable[] arr)
        {
            bool sorted = true;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i].CompareTo(arr[i + 1]) > 0)
                    sorted = false;
            }
            return sorted;
        }

        static bool compare(IComparable a, IComparable b)
        {
            if (a.CompareTo(b) > 0)
            { return true; }
            else
            { return false; }
        } //Сравнить a > b?

        static void swap(IComparable[] arr, int a, int b)
        {
            IComparable c;
            c = arr[a];
            arr[a] = arr[b];
            arr[b] = c;
        } //Поменять местами два элемента с индексами а и b

        static void BubbleSort(IComparable[] arr)
        {
            Console.WriteLine("");
            for (int i = 0; i < (arr.Length - 1); i++)
            {
                int k = 0;
                for (int j = 0; j < (arr.Length - 1); j++)
                {
                    if (compare(arr[j], arr[j + 1]))
                    {
                        { swap(arr, j, j + 1); k++; }
                    }
                }
                if (k == 0) break;
            }
            writeArray(arr);

        } //Сортировка Пузырьком

        static int lookBack(IComparable[] arr, int a)
        {
            int x = a - 1;
            while (compare(arr[x], arr[a]))
            {
                if (x > 0) { x = x - 1; } else { return 0; }
            }
            return x + 1;
        } //Искать место для вставки

        static void InsertSort(IComparable[] arr)
        {
            Console.WriteLine("");
            int x;
            IComparable mem;
            for (int i = 1; i < arr.Length; i++)
            {
                x = lookBack(arr, i);
                mem = arr[i];
                Array.Copy(arr, x, arr, x+1, i - x);
                arr[x] = mem;
            }
            writeArray(arr);
        } //Сортировка вставками

        static void ShellSort(IComparable[] arr) //Сортировка шелла
        {
           Console.WriteLine("");
            int j;
            int step = arr.Length / 2;
            while (step > 0)
            {
                for (int i = 0; i < (arr.Length - step); i++)
                {
                    j = i;
                    while ((j >= 0) && compare(arr[j],arr[j + step]))
                    {
                        IComparable tmp = arr[j];
                        arr[j] = arr[j + step];
                        arr[j + step] = tmp;
                        j = j - step;
                    }
                }
                step = step / 2;
            }
            writeArray(arr);
        }

    }
}
