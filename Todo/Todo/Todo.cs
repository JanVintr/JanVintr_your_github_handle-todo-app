using System;
using System.Collections.Generic;
using System.IO;

namespace Todo 
{
    public class Todo 
{
    public List<Todo> Todos;
    private string task { get; set; } 
    public string todo { get; set; }

    public Todo(string Task, string Todo)
    {
        Todos = new List<Todo>();
        task = Task;
        todo = Todo;
    }
    public void PrintTodo()
    {
        Console.WriteLine(todo);
    }

       
    }
}
