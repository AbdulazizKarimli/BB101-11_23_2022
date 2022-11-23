namespace FirstApp.Utilities;

public static class Extension
{
    public static int FindCharCount(this string str, char symbol)
    {
        int count = 0;
        foreach (var item in str)
        {
            if (symbol == item)
                count++;
        }
        return count;
    }

    public static int Power(this int number) => number * number;
}
