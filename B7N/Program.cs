using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B7N
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 tda = new Class1();
            int[,,] arr1 = tda.ArrayGen(); 
            int[,,] arr2 = tda.ArrayGen(); 
            int[,,] resArr; 
            tda.ArrayOut(arr1);
            Console.WriteLine("______________________________");
            tda.ArrayOut(arr2);
            Console.WriteLine("______________________________");
            Console.WriteLine("Введите номер арифметического действия, которое хотите произвести: \n1) Сложить массивы\n2) Вычесть массивы\n3) Умножить массив на выбранное число\n4) Сравнить сумму двух массивов");
            int value = Convert.ToInt16(Console.ReadLine());
            switch(value)
            {
                case 1:
                    resArr = tda.ArraySum(arr1, arr2);
                    tda.ArrayOut(resArr);
                    break;
                case 2:
                    Console.WriteLine("Выберите массив, который хотите вычесть\n 1) 1 - 2\n 2) 2 - 1");
                    value = Convert.ToInt16(Console.ReadLine());
                    if (value == 1)
                    {
                        resArr = tda.ArrayDif(arr1, arr2);
                        tda.ArrayOut(resArr);
                    }                  
                    else if (value == 2)
                    {
                        resArr = tda.ArrayDif(arr2, arr1);
                        tda.ArrayOut(resArr);
                    }
                    else
                    {
                        Console.WriteLine("Введите цифру!!!");
                    }                       
                    break;
                case 3:
                    Console.WriteLine("Выберите номер массива, которые хотите умножить на выбранное число\n 1) 1 \n 2) 2 ");
                    value = Convert.ToInt16(Console.ReadLine());
                    if (value == 1)
                    {
                        Console.WriteLine("Введите число, на которое хотите умножить массив");
                        int num = Convert.ToInt16(Console.ReadLine());
                        resArr = tda.ArrayMul(arr1, num);
                        tda.ArrayOut(resArr);
                    }
                    else if (value == 2)
                    {
                        Console.WriteLine("Введите число, на которое хотите умножить массив");
                        int num = Convert.ToInt16(Console.ReadLine());
                        resArr = tda.ArrayMul(arr2, num);
                        tda.ArrayOut(resArr);
                    }
                    else
                    {
                        Console.WriteLine("Введите цифру!!!");
                    }
                    break;
                case 4:
                    int res1 = tda.ArrayFin(arr1);
                    int res2 = tda.ArrayFin(arr2);
                    if(res1 > res2) Console.WriteLine("Сумма 1 массива ( "+res1+" ) больше, чем сумма 2 массива ( "+res2+" )");
                    else if (res2 < res1) Console.WriteLine("Сумма 2 массива ( "+res2+" ) больше, чем сумма 1 массива ( "+res1+" )");
                    else if (res1 == res2) Console.WriteLine("Суммы массивов равны " +res1+" = "+res2);
                    else Console.WriteLine("Ошибка!");
                    break;
                default :
                    Console.WriteLine("Число не подходит по условию!");
                    break;
            }
            Console.ReadLine();
        }
    }
}