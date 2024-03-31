using System;

internal class Program
{
    public static void Main()
    {
        Masiv1<int> IntMass = new Masiv1<int>();
        for (int i = 0; i < 8; i++)
        {
            IntMass.Add(i);
        }
        IntMass.WriteArray();
        int y = 3;
        IntMass.Reverse();
        IntMass.WriteArray();
        Console.WriteLine(IntMass.Kolvo());
        Console.WriteLine(IntMass.CountKolvo((x) => x == 2));
        IntMass.Del(y, (a, b) => a == b);
        IntMass.WriteArray();
        Console.WriteLine(IntMass.If1((x) => x % 3 == 0));
        Console.WriteLine(IntMass.IfAll((x) => x % 2 == 0));
        IntMass.ForAll((x) => x * x);
        IntMass.WriteArray();

        Masiv1<string> StringMass = new Masiv1<string>();
        for (int i = 0; i < 8; i++)
        {
            StringMass.Add($"{i + 1}");
        }
        StringMass.WriteArray();
        string g = "3";
        StringMass.Reverse();
        StringMass.WriteArray();
        Console.WriteLine(StringMass.Amount());
        Console.WriteLine(StringMass.CountAmount((x) => x == "print(hello_world"));
        StringMass.Remove(g, (a, b) => a == b);
        StringMass.WriteArray();
        Console.WriteLine(StringMass.If1((x) => x != "def_func_1:"));
        Console.WriteLine(StringMass.IfAll((x) => x != "for___in_range(loxx)"));
        StringMass.ForAll((x) => x + "ab");
        StringMass.WriteArray();
    }
}
