string[] firstArray = new string[5] {"Russia", "345", "15", "lol", "computer"};
string[] secondArray = new string[firstArray.Length];
void GetSecondArr(string[] firstArray, string[] secondArray)
{
    int count = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
    if(firstArray[i].Length <= 3)
        {
        secondArray[count] = firstArray[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
GetSecondArr(firstArray, secondArray);
PrintArray(secondArray);