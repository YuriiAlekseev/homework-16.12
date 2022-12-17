// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

float [] IntersectionPoint(float [] massiv) // massiv[0] = b1; massiv[1] = k1; massiv[2] = b2; massiv[3] = k2
{
    float [] xy = new float [2];
    xy[0] = (massiv[2] - massiv[0]) / (massiv[1] - massiv[3]); // x=(b2-b1) / (k1-k2)
    xy[1] = massiv[1] * xy[0] + massiv[0]; // y=k1*x+b1
    return xy;
}
float [] InputNumber()
{
    float [] massiv = new float [4];
    int index = 0;
    int length = massiv.Length;
    Console.WriteLine("Введите значениеследующих точек b1, k1, b2 и k2");
        while (index < length)
        {
            Console.WriteLine($"Введите {index+1} число: ");
            massiv[index] = float.Parse(Console.ReadLine()); 
            index++;
        }
return massiv;
}
float [] massiv = InputNumber();
float [] intersectionpoint = IntersectionPoint(massiv);
Console.WriteLine(String.Join(";", intersectionpoint));
