string[] MyArray = new string[] {"hello", "2", "world",":-)"};
string[] Myarray2 = new string[MyArray.Length];
void ChekingCharacters(string[] MyArray, string[] MyArray2)
{
    int count = 0;
    for (int i = 0; i < MyArray.Length; i++)
    {
    if(MyArray[i].Length <= 3)
        {
        MyArray2[count] = MyArray[i];
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
ChekingCharacters(MyArray, Myarray2);
PrintArray(Myarray2);