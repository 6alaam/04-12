Main();

void Main()
{
    bool isWork = true;
    while (isWork)
    {
        Console.WriteLine("enter command");
        string command = Console.ReadLine();
        switch (command)
        {
            case "Task 1":
                Task1();
                break;
            case "Task 2":
                Task2();
                break;
            
            case "exit":
                isWork = false;
                break;

        }
    }
}



// Задача 1: Пользователь вводит с клавиатуры M
// чисел. Посчитайте, сколько чисел больше 0 ввёл
// пользователь.

void Task1()
{
    Console.WriteLine("Сколько цифр будет введено ? ");
    int number = ReadInt("number");

    CounterPosNumbers(number);

}


// Задача 2: Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y =
// k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2
// задаются пользователем.

void Task2(){
    Console.WriteLine("Введит число b1");
    double b1 = ReadDouble("b1");
    Console.WriteLine("Введит число k1");
    double k1 = ReadDouble("k1");
    Console.WriteLine("Введит число b2");
    double b2 = ReadDouble("b2");
    Console.WriteLine("Введит число k2");
    double k2 = ReadDouble("k2");
    LineIntersection(b1,k1,b2,k2);

}


int ReadInt(string argument)
{
    Console.Write($"Input {argument} : ");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Не число введите число !");

    }
    return number;

}

void CounterPosNumbers(int length)
{

    int[] arr = new int[length];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());

    }
    for (int i = 0; i < arr.Length; i++)
    {
        if (i > 0)
        {
            count++;

        }


    }
    Console.WriteLine($"Количество положительных числе равно {count} ");



}


double ReadDouble(string argument)
{
    Console.Write($"Input {argument} : ");
    double number;
    while (!double.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Не число введите число !");

    }
    return number;

}

void LineIntersection(double b1,double k1,double b2,double k2){
    
    double x = 0;
    double y = 0;

    if (b1 == b2) Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> (0, {b1})");
    else if (k1 == k2) Console.WriteLine($"Не пересекаются");
    else 
{
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}, {y})");
}
}

