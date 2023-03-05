// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] InputCoeffs()
{
    int count = 0;
    double[] coeffsArray = new double[4];
    for (count = 0; count < 2; count++)
    {
        Console.WriteLine($"Введите {count + 1} коэффициент первой функции> ");
        coeffsArray[count] = Convert.ToDouble(Console.ReadLine());
    }
    for (count = 2; count < 4; count++)
    {
        Console.WriteLine($"Введите {count - 1} коэффициент второй функции> ");
        coeffsArray[count] = Convert.ToDouble(Console.ReadLine());
    }
    return coeffsArray;
}

void FindCross(double[] coeffs)
{
    double[] crossPoint = new double[2]; 
    if (coeffs[0] - coeffs[2] !=  0 )
    {
        crossPoint[0]=(coeffs[2]-coeffs[0])/(coeffs[1]-coeffs[3]);
        crossPoint[1]=coeffs[1]*crossPoint[0]+coeffs[0];
        Console.WriteLine($"Функции y = {coeffs[1]}*x + {coeffs[0]} и  y = {coeffs[3]}*x + {coeffs[2]} пересекаются в точке [{String.Join(";", crossPoint)}]");
    }
    else
    {
         Console.WriteLine($"Функция y = {coeffs[1]}*x + {coeffs[0]} и  y = {coeffs[3]}*x + {coeffs[2]} не пересекаются");
    }
    
}

double[] coeffs = InputCoeffs();

FindCross(coeffs);


