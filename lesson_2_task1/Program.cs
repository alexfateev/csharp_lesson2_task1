int[] arr = new int[5];
Console.WriteLine("Введите 5 целочисленных чисел. \nПо завершении программа выведет среднее арифметическое значение");

try
{
    Console.Write("1 число: ");
    arr[0] = int.Parse(Console.ReadLine());
    Console.Write("2 число: ");
    arr[1] = int.Parse(Console.ReadLine());
    Console.Write("3 число: ");
    arr[2] = int.Parse(Console.ReadLine());
    Console.Write("4 число: ");
    arr[3] = int.Parse(Console.ReadLine());
    Console.Write("5 число: ");
    arr[4] = int.Parse(Console.ReadLine());
} catch (Exception ex)
{
    Console.WriteLine($"Вы ввели некорректные данные. {ex.Message}");
}
int i = (arr[0] + arr[1] + arr[2] + arr[3] + arr[4])/5;
Console.WriteLine($"Среднее арифеметическое значение введеных чисел = {i}");