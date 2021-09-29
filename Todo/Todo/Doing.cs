using System;
using System.Collections.Generic;
namespace Todo 
{
    public class Doing : TodoSet
    {
    public List<Doing> Doings;
    private string doing;

    public Doing(string Doing)
    {
        Doings = new List<Doing>();
        doing = Doing;
    }
    public void PrintDoing()
    {
        Console.WriteLine(doing);
    }
}
}
