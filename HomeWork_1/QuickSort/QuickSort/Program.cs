using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.Write("Введите длинну массива:");   // начинаем ввод массива
            string size = Console.ReadLine();
            int sizeArr = int.Parse(size);
            int[] myArray = new int[sizeArr];
            int num = sizeArr - 1;


            for (int i = 0; i < sizeArr; i++)
            {
                int y = i + 1;                          // для обычных людей, а не программистов
                Console.Write("Введи " + y + " элемент массива : ");
                string stArr = Console.ReadLine();
                myArray[i] = Int32.Parse(stArr);
            }                                                // конец ввода массива
            Console.WriteLine("Отсортированный массив:");    // вставка строки после ввода массива

            sorting(myArray, 0, num); //подать массив в метод





            for (int i = 0; i < sizeArr; i++)     // начинаем вывод массива
            {
                int y = i + 1;                    // для обычных людей, а не программистов
                Console.WriteLine(y + " элемент отсортированного массива : " + myArray[i]);
            }
            Console.WriteLine();            // конец вывода массива
        }




        public static void sorting(int[] arr, int first, int last) //метод 
        {
            int p = arr[(last - first) / 2 + first]; //p - средний элмент в текущем массиве
            int temp;
            int i = first, j = last; //i - индекс начала, j- индекс конца
            while (i <= j) //пока не все элменты отсортированы шагаем по циклу
            {
                while (arr[i] < p && i <= last) ++i; //пропускаем слева, те что меньше среднего
                while (arr[j] > p && j >= first) --j; //пропускаем слева, те что больше среднего
                if (i <= j)                //меняем их местами неотсортированные
                {
                    temp = arr[i];
                    arr[i] = arr[j];  //больший слева
                    arr[j] = temp;   //меньший справа
                    ++i;
                    --j;
                }
            }
            if (j > first) sorting(arr, first, j); //сортировка левого
            if (i < last) sorting(arr, i, last);//правого подмассива
        }
    }

}