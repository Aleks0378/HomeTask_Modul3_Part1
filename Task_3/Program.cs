//Задание 3
//Напишите метод, фильтрующий массив на основании 
//переданных параметров. Метод принимает параметры: 
//оригинальный_массив, массив_с_данными_для_фильтрации.
//Метод возвращает оригинальный массив без элементов, которые есть в массиве для фильтрации.
//Например:
//1 2 6 - 1 88 7 6 — оригинальный массив;
//6 88 7 — массив для фильтрации;
//1 2 - 1 — результат работы метода.

namespace Task_3
{
    internal class Program
    {
        static int[] ArrayFiltration(int[] A, int[] B)
        {
            int n = 0;
            for (int i = 0; i < A.Length-n; i++)
            {
                for (int j=0;j < B.Length; j++)
                {
                    if (A[i] == B[j])
                    {
                        for (int k=i;k<A.Length-1-n;k++)
                        {
                            A[k] = A[k + 1];
                        }
                        i--;
                        n++;
                        break;
                    }

                }               
            }
            int[] newArray = new int[A.Length-n];
            Console.WriteLine("\nОтфильтрованный массив:\n");
            for (int i = 0;i < newArray.Length; i++)
            {
               newArray[i] = A[i];
                Console.Write($"\t{newArray[i]}");
            }               
            return newArray;
        }
        static void Main(string[] args)
        {
          int[] a = { 1, 2, 3,4,5,6,7,8,9,10 };
            Console.WriteLine("\nОригинальный массив до фильтрации:\n");
            foreach (int k in a)
                Console.Write($"\t{k}");
            int[] b = { 1, 2,6 };
            Console.WriteLine("\nФильтрующий массив:\n");
            foreach (int k in b)
                Console.Write($"\t{k}");
            ArrayFiltration(a, b);
            Console.WriteLine("\n\n");
        }
    }
}