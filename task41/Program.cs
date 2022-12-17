// Задача 41: Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Count(int [] massiv)
{
    int count = 0;
    for (int i = 0; i < massiv.Length; i++)
    {
        if (massiv[i]>0)
        {
            count++;
        }
    }
    return count;
}
int [] InputNumber()
{
    int [] massiv = new int [8];
    int index = 0;
    int length = massiv.Length;
        while (index < length)
        {
            Console.WriteLine($"Введите {index+1} число: ");
            massiv[index] = int.Parse(Console.ReadLine()); 
            index++;
        }
return massiv;
}
int [] massiv = InputNumber();
int count = Count(massiv);
Console.WriteLine($"Пользователь ввел " + count + " чисел больше 0");
