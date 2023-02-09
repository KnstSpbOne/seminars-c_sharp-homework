void Task4()
{
    System.Console.WriteLine("Задача 2: на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
    System.Console.WriteLine("Введите 1-е число");
    int n1=Convert.toInt32(System.Console.ReadLine());
    System.Console.WriteLine("Введите 2-е число");
    int n2=Convert.toInt32(System.Console.ReadLine());
    if (n1>n2)
    {
        System.Console.Writeline("Первое число больше второго и равно :" {n1});
    }
    else if (n1<n2)
    {
        System.Console.Writeline("Второе число больше первого и равно :" {n2});
    }
    else
    {
        System.Console.Writeline("Числа равны:" {n1});
    }
}  
internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Какую задачу будем решать? Введите номер:");
        System.Console.WriteLine("Задача 2: на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
        // System.Console.WriteLine("Задача 4: принимает на вход три числа и выдаёт максимальное из этих чисел.");
        // System.Console.WriteLine("Задача 6: на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)");
        // System.Console.WriteLine("Задача 8: на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
        // System.Console.WriteLine("Задача 10:принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
        // System.Console.WriteLine("Задача 13:выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
        // System.Console.WriteLine("Задача 15:принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
        // System.Console.WriteLine("Задача 19:принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
        // System.Console.WriteLine("Задача 21:принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
        // System.Console.WriteLine("Задача 23:принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
        int TaskNumber=Convert.ToInt32(System.Console.ReadLine());
        switch (TaskNumber)
        {
            case 2:
                Task2();
            break;
            case 4
                Task4();
            case6
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
            System.Console.WriteLine("Не хочешь решать-до свидания!!");
            break;
        }   

    }
}
