class Base<T>
{
    int Index { get; set; }
    T[] Massiv { get; set; }
    public Base()
    {
        Index = 0;
        Massiv = new T[Index];
    }
    public Base(int index)
    {
        Index = index;
        Massiv = new T[Index];
    }
    public void Add(T element)
    {
        var temp = Massiv;
        Massiv = new T[++Index];
        Massiv[^1] = element;
        for (int i = 0; i < temp.Length; i++)
            Massiv[i] = temp[i];
        Console.WriteLine($"Элемент {element} добавлен");
    }
    public void Remove(T element)
    {
        int rindex = -1;
        var temp = Massiv;
        for (int i = 0; i < temp.Length; i++)
            if (temp[i].Equals(element))
            {
                rindex = i;
                break;
            }
        if (rindex > -1)
        {
            Massiv = new T[--Index];
            for (int i = 0, j = 0; i < temp.Length; i++)
            {
                if (i == rindex)
                    continue;
                Massiv[j] = temp[i];
                j++;
            }
            Console.WriteLine($"Элемент {element} удален");
        }
        else
            Console.WriteLine($"Элемент {element} отсутсвует");
    }
    public void Display()
    {
        Console.WriteLine("Массив");
        foreach (var element in Massiv)
            Console.Write($"{element} ");
        Console.WriteLine();
    }
}