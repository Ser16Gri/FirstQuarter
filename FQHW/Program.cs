int length = 4;
string[] firstArray = GetArray(length);
string[] secondArray = GenerateSecondArray(firstArray);

string[] GenerateSecondArray(string[] array)
{
    string[] secondArray = new string[length];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3 && array[i].Length > 0) secondArray[i] = array[i];
    }
    PrintArray(secondArray);
    return secondArray;
}
string[] GetArray(int length)
{
    string[] array = new string[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ReadString($"element {i + 1}");
    }
    return array;
}
string ReadString(string argumentName)
{
    Console.Write($"Input {argumentName}: ");
    return Console.ReadLine()!;
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != null) System.Console.Write($"{array[i]} ");
    }        
}
