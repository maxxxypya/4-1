using System;

class OneDimentioal<T>
{

    private T[] Masiv;
    private int capacity;
    private int size;

    public Masiv1(int capacity)
    {
        capacity = capacity;
        Masiv = new T[capacity];
        size = 0;
    }

    public Masiv1() : this(7)
    {
    }

    public void Add(T item)
    {
        if (size >= capacity)
        {
            capacity = capacity * 2 + 1;
            Masiv.Resize(ref Masiv, capacity);
        }
        Masiv[size] = item;
        size++;
    }

    public void Reverse()
    {
        T[] newMass = new T[size];
        for (int i = size - 1; i >= 0; i--)
        {
            newMass[i] = Masiv[size - i - 1];
        }
        Masiv.Copy(newMass, 0, Masiv, 0, size);
    }


    public int Kolvo()
    {
        return size;
    }

    public int CountKolvo(Func<T, bool> cond)
    {
        T[] newMass = Method(cond);
        return newMass.Length;
    }

    public void Del(T item, Func<T, T, bool> deleg)
    {
        T[] newMass = new T[size];
        int mark = 0;
        for (int i = 0; i < size; i++)
        {
            if (!deleg(item, Masiv[i]))
            {
                newMass[i] = Masiv[i];
            }
            else
            {
                mark = i;
            }
        }
        Masiv.Copy(newMass, 0, Masiv, 0, size - 1);
        for (int i = mark; i < size; i++)
        {
            Masiv[i] = Masiv[i + 1];
        }
        size--;

    }

    public T[] Method(Func<T, bool> condition)
    {
        T[] newMass = new T[size];
        int count = 0;
        for (int i = 0; i < size; i++)
        {
            if (condition(Masiv[i]))
            {
                newMass[count] = Masiv[i];
                count++;
            }
        }
        Masiv.Resize(ref newMass, count);
        return newMass;
    }

    public void ForAll(Func<T, T> condition)
    {
        T[] newMass = new T[size];
        for (int i = 0; i < size; i++)
        {
            Masiv[i] = condition(Masiv[i]);
        }

        for (int i = 0; i < size; i++)
        {
            Console.Write(Masiv[i] + " ");
        }
        Console.WriteLine("");
    }

    public bool If1(Func<T, bool> cond)
    {
        T[] newMass = Method(cond);
        if (newMass.Length > 0)
        {
            return true;
        }
        return false;
    }

    public bool IfAll(Func<T, bool> cond)
    {
        T[] newArray = Method(cond);
        if (newArray.Length == size)
        {
            return true;
        }
        return false;
    }

    public void WriteArray()
    {
        for (int i = 0; i < Masiv.Length; i++)
        {
            Console.Write(Masiv[i] + " ");
        }
        Console.WriteLine();
    }
}