﻿// void Task2()
// {
//     Console.WriteLine("Задача 2: на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
//     Console.WriteLine("Введите 1-е число");
//     int n1=Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите 2-е число");
//     int n2=Convert.ToInt32(Console.ReadLine());
//     if (n1>n2)
//     {
//         Console.WriteLine("Первое число больше второго и равно: {0}", n1);
//     }
//     else if (n1<n2)
//     {
//         Console.WriteLine("Второе число больше первого и равно {0}:", n2);
//     }
//     else
//     {
//         Console.WriteLine("Числа равны: {0}", n1);
//     }
// } 
// void Task4()
// {
//     Console.WriteLine("Задача 4: на вход принимает три числа и выдаёт максимальное");
//     int nmax=0;
//     for (int counter=1; counter<=3; counter++)
//     {
//         Console.Write("Введите {0}-е число:  ", counter);
//         int n=Convert.ToInt32(Console.ReadLine());
//         if (n>nmax)
//         {
//             nmax=n;
//         }
//     }
//     Console.WriteLine("Максимальное из чисел {0}", nmax);
// }   
// void Task6()
// {
//    Console.WriteLine("Задача 6: на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)");
//    Console.Write("Введите число:   ");
//    double n=Convert.ToDouble(Console.ReadLine());
//    if (n%2==0)
//         Console.WriteLine("Число {0} четное", n);
//    else
//         Console.WriteLine("Число {0} нечетное", n);
// }

// void Task8()
// {
//     Console.WriteLine("Задача 8: на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
//     Console.Write("Введите число:   ");
//     int N=Convert.ToInt32(Console.ReadLine());
//     if (N<=2)
//         Console.WriteLine("От 0 до {0} нет четных чисел", N);
//     else 
//         Console.Write("Четные числа:  ", N);
//     for (int counter=2; counter<N; counter=counter+2)
//     {
//         Console.Write("  {0}  ", counter);
//     }
// }

// void Task10()
// {
//     Console.WriteLine("Задача 10:принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
//     Console.Write("Введите трехзначное число :   ");
//     int N=Convert.ToInt32(Console.ReadLine());
//     while ((N/100>10)|(N/100<1))
//     {
//         Console.WriteLine("Число не трехзначное. Еще раз:      ");
//         N=Convert.ToInt32(Console.ReadLine());
//     }
//     Console.WriteLine("Вторая цифра числа : {0}", (N%100-N%10)/10);
// }

// void Task13()
// {
//     Console.WriteLine("Задача 13:выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
//     Console.Write("Введите число :   ");
//     int N=Convert.ToInt32(Console.ReadLine());
//     if (N/100<1)
//         Console.WriteLine("число {0} не содержит третьей цифры", N);
//     else
//         Console.WriteLine("Третья справа цифра числа {0} это {1}", N, (N%1000-N%100)/100);
// }

// void Task15()
// {
//     Console.WriteLine("Задача 15:принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
//     Console.Write("Введите число :   ");
//     int DayNumber=Convert.ToInt32(Console.ReadLine());
//     while ((DayNumber>7)|(DayNumber<=0))
//     {
//         Console.Write("Нет такого номера дня недели. Еще раз :  ");
//         DayNumber=Convert.ToInt32(Console.ReadLine());
//     }
//     if ((DayNumber==6)|(DayNumber==7))
//         Console.WriteLine("Это Выходной!!");
//     else
//         Console.WriteLine("Это будний день");
// }
// третий семинар
void Task19()
{
    Console.WriteLine("Задача 19:принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
    Console.Write("Введите число (а можно и не число):   ");
    string? UserInput=Console.ReadLine();
    bool Marker=false;
    while ((UserInput.Length<2))
    {
        Console.Write("Слишком короткое.Еще раз:  ");
        UserInput=Console.ReadLine();
    }
    for (int cntr=0; cntr<UserInput.Length/2; cntr++)
    {
        if (UserInput[cntr]==UserInput[UserInput.Length-cntr-1])
        {
            Marker=true;
        }
        else
        {
            Console.Write(UserInput[cntr]);
            Console.WriteLine(UserInput[UserInput.Length-cntr-1]);
            Marker=false;
            cntr=UserInput.Length;
        }        
    }     
    if (Marker==false)
    {
        Console.WriteLine("Это не палиндром");
    }
    else
    {
        Console.WriteLine("Это палиндром");
    }
}
{// ------------MAIN--------------------
    // первый семинар
    // Console.WriteLine("Задача 2: на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
    // Console.WriteLine("Задача 4: принимает на вход три числа и выдаёт максимальное из этих чисел.");
    // Console.WriteLine("Задача 6: на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)");
    // Console.WriteLine("Задача 8: на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
    // второй семинар
    // Console.WriteLine("Задача 10:принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
    // Console.WriteLine("Задача 13:выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
    // Console.WriteLine("Задача 15:принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
    // третий семинар
    Console.WriteLine("Задача 19");
            // System.Console.WriteLine("Задача 21:принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
            // System.Console.WriteLine("Задача 23:принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
            //Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
            //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
            //Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
            //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
            //Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
            //Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
            //Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
            //Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
            //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
            //Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
            //Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
            //Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
            //Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
    Console.Write("Какую задачу будем решать? Введите номер:  ");
    int TaskNumber =Convert.ToInt32(Console.ReadLine());
    switch (TaskNumber)
    {
        // case 2:      // первый семинар
        //     Task2();
        // break;
        // case 4:
        //     Task4();
        // break;
        // case 6:
        //     Task6();
        // break;
        // case 8:
        //     Task8();
        // break;
        // case 10:     // второй семинар 
        //     Task10();
        // break;
        // case 13:
        //     Task13();
        // break;
        // case 15:
        //     Task15();
        // break;
        case 19:        // третий семинар
            Task19();
        break;
                // case 21:
                //     Task21();
                // break;
                // case 23:
                //     Task23();
                // break;
        default:
            Console.WriteLine("Не хочешь решать-до свидания!!");
        break;
    }
}
