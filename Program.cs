// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void Main()
{
    Console.Clear();
    string mass = Input("Введите ваш массив строк через пробел или запятую");
    string[] array = ArrayBuild(mass);
    PrintArray(array);
    int resultArrayLength = GetLength(array);
    string[] result = GetResult(array, resultArrayLength);
    PrintArray(result);
}
string Input(string text)
{
    Console.Write($"{text}: ");
    string temp = Console.ReadLine()!;
    return temp;
}
string[] ArrayBuild(string tempStr)
{
    char[] separators = new char[] {',',' '};
    string[] array = tempStr.Split(separators,StringSplitOptions.RemoveEmptyEntries);
    return array;
}