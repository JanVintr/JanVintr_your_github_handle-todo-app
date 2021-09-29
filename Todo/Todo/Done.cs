using System;
using System.Collections.Generic;
namespace Todo 
{
    public class Done : TodoSet
    {
    public List<Done> Dones;
    private string done;

    public Done(string Done)
    {
        Dones = new List<Done>();
        done = Done;
    }
    public void RemoveDones()
    {
        //dones.Remove();
    }
}
}