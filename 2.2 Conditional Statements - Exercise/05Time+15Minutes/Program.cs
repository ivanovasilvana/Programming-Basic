﻿using System;

namespace _05Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете час и минути от 24 - часово денонощие, въведени от потребителя и изчислява колко ще е часът след 15 минути.Резултатът да се отпечата във формат часове: минути.Часовете винаги са между 0 и 23, а минутите винаги са между 0 и 59.Часовете се изписват с една или две цифри.Минутите се изписват винаги с по две цифри, с водеща нула, когато е необходимо. 
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += 15;
            if (minutes >= 60)
            {
                minutes -= 60;
                hour += 1;
            }
            if (hour >= 24)
            {
                hour = 0;
            }
            if (minutes < 10)
            {
                Console.WriteLine($"{hour}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hour}:{minutes}");
            }
        }
    }
}
