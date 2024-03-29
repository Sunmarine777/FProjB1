﻿//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
/*Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/

using System;

class Program
{
      static void Main()
      {
            string[] Text = ["Hello", "2", "world", ":-)"];
            string[] NewText = new string[Text.Length];
            int j = 0;
            Console.Write($"[\"{Text[0]}\", \"{Text[1]}\", \"{Text[2]}\", \"{Text[3]}\"] -> [");//Усложнение вывода данных вызвано требованием определённого формата

            for (int i = 0; i < Text.Length; i++)
            {
                  if (Text[i].Length < 4)
                  {
                        NewText[j] = Text[i];
                        j++;  
                  }
            }

            Array.Resize(ref NewText, j);

            for (int n = 0; n < NewText.Length-1; n++)//Можно обойтись одним циклом с корректировкой Length-1; -> Length;
            {
                  Console.Write($"\"{NewText[n]}\",");
            }
            for (int n = NewText.Length-1; n < NewText.Length; n++)//2й цикл требуется исключительно для формата вывода данных
            {
                  Console.Write($"\"{NewText[n]}\"");
            }
            Console.Write("]");//Данный вывод также требуется исключительно для формата вывода данных
      }
}
//Возможно, есть более простая реализация вывода данных, но у меня почему-то не сработал метод string.Join

/*using System;

class Program
{      
      static void Main()
      {
            string[] Text = ["1234", "1567", "-2", "computer science"];
            string[] NewText = new string[Text.Length];
            int j = 0;
            Console.WriteLine(string.Join(", ",Text));

            for (int i = 0; i < Text.Length; i++)
            {
                  if (Text[i].Length < 4)
                  {
                        NewText[j] = Text[i];
                        j++;  
                  }
            }
            if (j == 0)
                  Console.Write("[]");

            Array.Resize(ref NewText, j);

            foreach (string n in NewText)
            {
                  Console.Write(string.Join(", ",n));
            }
      }
}*/

/*using System;

class Program
{      
      static void Main()
      {
            string[] Text = ["Russia", "Denmark", "Kazan"];
            string[] NewText = new string[Text.Length];
            int j = 0;
            Console.Write(string.Join(", ",Text));
            Console.Write(" -> ");

            for (int i = 0; i < Text.Length; i++)
            {
                  if (Text[i].Length < 4)
                  {
                        NewText[j] = Text[i];
                        j++;
                  }
                        
            }
            if (j == 0)
            Console.Write("[]");

            Array.Resize(ref NewText, j);

            foreach (string n in NewText)
            {
                  Console.Write(string.Join(", ",n));
            }
      }
}*/