// Дан файл, содержащий несколько целых чисел количеством i. Создайте массив height длиной i.
// Каждый элемент массива это вертикальная линия определенной длины. Найдите две линии,
// которые вместе с осью x образуют контейнер, содержащий наибольшее количество воды;

using System;
using System.IO; 

class work_3_3
{
    static void Main()
    {
        string line = File.ReadAllText("input.txt"); 
        string[] lineArray = line.Split(' '); 
        int[] arrayNumbers = Array.ConvertAll(lineArray, int.Parse); 

        int max = 0; 
        int left = 0; 
        int right = arrayNumbers.Length - 1;


        while (left < right)
        {
            int area = Math.Min(arrayNumbers[left], arrayNumbers[right]) * (right - left);

            if (area > max) 
            {
                max = area; 
            }

            if (arrayNumbers[left] < arrayNumbers[right])
            {
                left++; 
            }
            else
            {
                right--;
            }
        }
        Console.WriteLine($"Площадь контейнера: {max}"); 
    }
}