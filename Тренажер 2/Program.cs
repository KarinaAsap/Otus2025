using System;

// Класс для тестирования решения
class UserInputToCompileForTest
{
    public static void PrintResult()
    {
        int intWidth = 5;
        int intHeight = 8;
        double doubleWidth = 3.5;
        double doubleHeight = 6.2;
        int squareSide = 7;

        int expectedIntArea = intWidth * intHeight;
        double expectedDoubleArea = doubleWidth * doubleHeight;
        int expectedSquareArea = squareSide * squareSide;

        if (Answer.CalculateRectangleArea(intWidth, intHeight) != expectedIntArea)
        {
            Console.WriteLine($"Задание 1: Ошибка (int, int). Ожидалось {expectedIntArea}, получено {Answer.CalculateRectangleArea(intWidth, intHeight)}");
        }
        else if (Math.Abs(Answer.CalculateRectangleArea(doubleWidth, doubleHeight) - expectedDoubleArea) > 0.001)
        {
            Console.WriteLine($"Задание 1: Ошибка (double, double). Ожидалось {expectedDoubleArea}, получено {Answer.CalculateRectangleArea(doubleWidth, doubleHeight)}");
        }
        else if (Answer.CalculateRectangleArea(squareSide) != expectedSquareArea)
        {
            Console.WriteLine($"Задание 1: Ошибка (int). Ожидалось {expectedSquareArea}, получено {Answer.CalculateRectangleArea(squareSide)}");
        }
        else
        {
            Console.WriteLine("Задание 1: Пройдено");
        }
    }
}

class Answer
{ // Не удаляйте и не меняйте класс Main!

    public static void Main(string[] args)
    {
        UserInputToCompileForTest.PrintResult();
    }

    // Методы вычисления площади (перегрузка)
    public static int CalculateRectangleArea(int width = 10, int height = 10)
    {
        return width * height;
    }
    // Добавьте перегрузки здесь
    public static double CalculateRectangleArea(double width = 12.3, double height = 15.5)
    {
        return width * height;
    }
    public static int CalculateRectangleArea(int side)
    {
        return side * side;
    }
}
