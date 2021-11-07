using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyDes
{
    
    class Program

    {
        static void Resize(ref int [] arrr, int newSize) //на входе массив и длина нового массива
        {
           int [] arrray = new int [newSize]; //создаем новый массив

            for (int i = 0; i <arrr.Length&&i<arrray.Length; i++) //в цикле создаем условие, что в случае превышения одной длины массива над другой выводится последнее истинное значение
            {
                arrray[i] = arrr[i]; //новый массив приравнивается старому массиву
            }
            arrr = arrray; //ссылка на упр кучу массива старого переходит к новому



        }
        static void Main(string[] args)
        {
            int[] array = new[] { 1, 4, 6 };

            Resize(ref array,5);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadLine();
          
        }
    }
}
//Написать метод изменяющий количество элементов массива - увеличение их или уменьшение.