using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Sorts2
{
    class Program
    {
        static void Main(string[] args)
        {
            IComparable[] chararr = new IComparable[10];
            IComparable[] intarr = new IComparable[10];
            chararr = randomizeArray(10, "char");
            intarr = randomizeArray(10, "int");

            //qSort(chararr);
            if (ifSorted(chararr))
                writeArray(chararr);

            intarr = mergeSort(intarr);
            if (ifSorted(intarr))
                writeArray(intarr);

            System.Console.ReadLine();
        }

        static IComparable[] randomizeArray(int length,string type) //char or int
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
                    outarr[i] = (char)('a'+ rnd.Next(0,26));
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
            for(int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i].CompareTo(arr[i + 1]) > 0)
                    sorted = false;
            }
            return sorted;
        }

        static void swap(IComparable[] arr, int a, int b)
        {
            IComparable c;
            c = arr[a];
            arr[a] = arr[b];
            arr[b] = c;
        } //Поменять местами два элемента с индексами а и b

        static void qSort(IComparable[] arr)
        {
            quickSort(arr, 0, arr.Length-1);
            System.Console.Out.WriteLine("");
        }

        static void quickSort(IComparable[] arr,int start, int end)
        {
            IComparable[] lastarr = new IComparable[arr.Length];
            arr.CopyTo(lastarr,0);

            int i = start, j = end;
            IComparable piv = arr[(i + j) / 2];
            while (i <= j)
            {
                while (arr[i].CompareTo(piv)<0)
                    i++;
                while (arr[j].CompareTo(piv)>0)
                    j--;
                if (i <= j)
                    swap(arr,i++,j--);
            }
            if (start < j)
                quickSort(arr, start, j);
            if (end > i)
                quickSort(arr, i, end);
        }

        static IComparable[] merge(IComparable[] arr1, IComparable[] arr2)
        {
            IComparable[] outarr = new IComparable[arr1.Length + arr2.Length];
            arr1.CopyTo(outarr, 0);
            arr2.CopyTo(outarr, arr1.Length);
            if(outarr.Length>1)
            qSort(outarr);             
            return outarr;
        }

        static IComparable[] mergeSort (IComparable[] arr)
        {            
            arr = divide(arr);
            return arr;
            System.Console.Out.WriteLine("");
        }
        
        static IComparable[] divide(IComparable[] arr)
        {
            int l, r;
            if (arr.Length > 1)
            {
                if ((arr.Length % 2) == 0)
                {
                    l = (arr.Length / 2);
                    r = (arr.Length / 2);
                }
                else
                {
                    l = (arr.Length / 2);
                    r = (arr.Length / 2) + 1;

                }
                IComparable[] left = new IComparable[l];
                IComparable[] right = new IComparable[r];

                for (int i = 0; i < l; i++)
                    left[i] = arr[i];

                for (int i = l; i < arr.Length; i++)
                    right[i - l] = arr[i];

                left = divide(left);
                right = divide(right);
                return merge(left, right);
            }
            return arr;
        }

    }
}
