namespace Algorithms;

using System;

public class Chaine
{
    private int value;
    private Chaine? lst;

    public Chaine(int value)
    {
        this.value = value;
        this.lst = null;
    }
    
    public Chaine(int value, Chaine lst)
    {
        this.value = value;
        this.lst = lst;
    }

    public int Head()
    {
        return value;
    }
public Chaine Rest()
{
    return lst!;
}
    //    Console.WriteLine(Chaine.Head()); // 1
    //    Console.WriteLine(firstLink.Rest().Head()); // 2
    //    Console.WriteLine(firstLink.Rest().Rest().Head()); // 3
}

