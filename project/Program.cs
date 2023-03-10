System.Console.WriteLine("Введите слова через запятую: ");
string[] array = Console.ReadLine().Split(',');

string[] getResult(string[] arr)
{
    string result = "";
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3 && arr[i].Length != 0)
        {
            result += $"{arr[i]},";
        }
    }

    return result.Split(',');
}

void PrintArray(string[] arr)
{
    System.Console.WriteLine("[" + string.Join(",", arr) + "]");
}

PrintArray(getResult(array));