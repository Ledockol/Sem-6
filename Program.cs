//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите количество чисел");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
FillArrayRandomNumbers(array);
PrintArray(array);
void FillArrayRandomNumbers(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToDouble(new Random().Next(-10,11));
        }
}
void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
    Console.WriteLine();
}
int count = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
    count++;
}
Console.WriteLine($"Чисел больше нуля {count}");