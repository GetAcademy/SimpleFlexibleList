﻿using SimpleFlexibleList;

/*
 * Nytt eksempel på OO og klasser
 * Forstå arrays litt bedre
 * Forstå List
 * Litt generics
 */

var numbers = new MyFlexibleList();
while (true)
{
    var numberStr = Console.ReadLine();
    var number = Convert.ToInt32(numberStr);
    numbers.Add(number);
    Console.WriteLine(numbers.AsString);
}

/*
var numbers = new int[4];
var count = 0;
while (true)
{
    var numberStr = Console.ReadLine();
    var number = Convert.ToInt32(numberStr);
    var index = count;
    if (index >= numbers.Length)
    {
        var newNumbers = new int[numbers.Length * 2];
        Array.Copy(numbers, newNumbers, numbers.Length);
        numbers = newNumbers;
    }
    numbers[index] = number;
    count++;

    Console.WriteLine($"Count={count} Numbers={string.Join(',', numbers)}");
}
*/