// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }
// int CountDigits(int size)
// {
//     int count = 0;
//     int[] array = new int[size];
//     Console.Write("Введите числа через Enter: ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Convert.ToInt32(Console.ReadLine()!);
//         if (array[i] > 0) count++;
//     }
//     return count;
// }
// int m = InputNum ("Сколько чисел вы собираетесь внести? ");
// int x = CountDigits(m);
// if (x>4) Console.WriteLine($"Введено {x} чисел больше 0.");
// else if (x<=4 && x>1) Console.WriteLine($"Введено {x} числа больше 0.");
// else if (x == 1) Console.WriteLine($"Введено {x} число больше 0.");
// else Console.WriteLine($"Чисел больше 0 нет.");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double InputBK(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}
double c = InputBK("Введите B для первой прямой: ");
double a = InputBK("Введите К для первой прямой: ");
double d = InputBK("Введите B для второй прямой: ");
double b = InputBK("Введите К для второй прямой: ");
if (a == b && c != d) Console.WriteLine("Прямые параллельны.");
else if (a == b && c == d) Console.WriteLine("Прямые совпадают.");
else
{
    double x = Math.Round((d - c) / (a - b),2);
    double y = Math.Round(a * x + c, 2);
    Console.Write($"Координаты точки пересечения прямых {x};{y}.");
}


//  Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }
// int n = InputNum("Введите число: ");
// void Fibonachi(int num)
// {
//     int firstNum = 0;
//     int secondNum = 1;
//     if (num == 1) Console.WriteLine(0);
//     else Console.Write("0 1");
//     for (int i = 3; i <= num; i++)
//     {
//         int res = secondNum;
//         secondNum = secondNum + firstNum;
//         firstNum = res;
//         Console.Write($" {secondNum}");

//     }
// }
// Fibonachi(n);

//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }
// int a1 = InputNum("Введите первую сторону: ");
// int b1 = InputNum("Введите вторую сторону: ");
// int c1 = InputNum ("Введите третью сторону: ");

// bool Cheak (int a, int b, int c)
// {
//     if (a + b > c && a + c > b && b + c > a) return true;
//     return false;
// }

// bool result = Cheak(a1, b1, c1);
// Console.WriteLine(result);

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10
// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }
// int FindSize(int n)
// {
//     int size = 0;
//     while (n != 0)
//     {
//         n /= 2;
//         size++;
//     }
//     return size;
// }
// int[] FillArray(int size, int number)
// {
//     int[] array = new int[size];
//     int res = number;
//     for (int i = 0; i < array.Length; i++)
//     {

//         res = number % 2;
//         number /= 2;
//         array[i] = res;

//     }
//     return array;
// }
// void RevArray(int[] revArray)
// {
//     for (int i = 0; i < revArray.Length / 2; i++)
//     {
//         int temp = revArray[i];
//         revArray[i] = revArray[revArray.Length - 1 - i];
//         revArray[revArray.Length - 1 - i] = temp;
//     }
// }

// void PrintRevArray(int[] array2)
// {
//     for (int i = 0; i < array2.Length; i++)
//     {
//         Console.Write(array2[i]);
//     }
//     Console.WriteLine();
// }
// int n1 = InputNum("ВВедите число: ");
// int length = FindSize(n1);
// int[] myArray = FillArray(length, n1);
// PrintRevArray(myArray);
// RevArray(myArray);
// PrintRevArray(myArray);
// int[] Division (int num)
// {
//     int temp = num;
//     int index = 0;
//     int res = num;
//     while(temp != 0)
//     {
//         temp = temp / 2;  
//         index++;
//     }
//     int[] array = new int[index];
//     for (int i = 0; i < array.Length; i++)
//     {
//         res = num % 2;
//         num = num / 2;
//         array[i] = res;
//     }
//     return array;
// }

// void RevArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]);
//     }
//     Console.WriteLine();
// }

// int number = InputNum("Введите число");
// int[] myArray = Division(number);
// PrintArray(myArray);
// RevArray(myArray);
// PrintArray(myArray);


//  Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

// double[] CraeteArray(int size)
// {
//     return new double[size];
// }
// void FillArray(double[] array)
// {
//     int min = -2;
//     int max = 4;
//     Random rnd = new Random();
//      for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 2); 
//     }
// }

// void PrintArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
// void ReverseArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
// }