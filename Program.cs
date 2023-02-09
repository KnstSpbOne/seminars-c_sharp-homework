void Task2()
{
    Console.WriteLine("Задача 2: на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
    Console.WriteLine("Введите 1-е число");
    int n1=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите 2-е число");
    int n2=Convert.ToInt32(Console.ReadLine());
    if (n1>n2)
    {
        Console.WriteLine("Первое число больше второго и равно: {0}", n1);
    }
    else if (n1<n2)
    {
        Console.WriteLine("Второе число больше первого и равно {0}:", n2);
    }
    else
    {
        Console.WriteLine("Числа равны: {0}", n1);
    }
} 
void Task4()
{
    Console.WriteLine("Задача 4: на вход принимает три числа и выдаёт максимальное");
    int nmax=0;
    for (int counter=1; counter<=3; counter++)
    {
        Console.Write("Введите {0}-е число:  ", counter);
        int n=Convert.ToInt32(Console.ReadLine());
        if (n>nmax)
        {
            nmax=n;
        }
    }
    Console.WriteLine("Максимальное из чисел {0}", nmax);
}   
void Task6()
{
   Console.WriteLine("Задача 6: на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)");
   Console.Write("Введите число:   ");
   double n=Convert.ToDouble(Console.ReadLine());
   if (n%2==0)
        Console.WriteLine("Число {0} четное", n);
   else
        Console.WriteLine("Число {0} нечетное", n);
}

void Task8()
{
    Console.WriteLine("Задача 8: на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
    Console.Write("Введите число:   ");
    int N=Convert.ToInt32(Console.ReadLine());
    if (N<=2)
        Console.WriteLine("От 0 до {0} нет четных чисел", N);
    else 
        Console.Write("Четные числа:  ", N);
    for (int counter=2; counter<N; counter=counter+2)
    {
        Console.Write("  {0}  ", counter);
    }
}
// ------------MAIN--------------------
Console.WriteLine("Задача 2: на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
Console.WriteLine("Задача 4: принимает на вход три числа и выдаёт максимальное из этих чисел.");
Console.WriteLine("Задача 6: на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)");
Console.WriteLine("Задача 8: на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
        // System.Console.WriteLine("Задача 10:принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
        // System.Console.WriteLine("Задача 13:выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
        // System.Console.WriteLine("Задача 15:принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
        // System.Console.WriteLine("Задача 19:принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
        // System.Console.WriteLine("Задача 21:принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
        // System.Console.WriteLine("Задача 23:принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
Console.Write("Какую задачу будем решать? Введите номер:  ");
int TaskNumber=Convert.ToInt32(Console.ReadLine());
switch (TaskNumber)
{
    case 2:
        Task2();
    break;
    case 4:
        Task4();
    break;
    case 6:
        Task6();
    break;
    case 8:
        Task8();
    break;
            // case 10:
            //     Task10();
            // break;
            // case 13:
            //     Task13();
            // break;
            // case 15:
            //     Task15();
            // break;
            // case 19:
            //     Task19();
            // break;
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
