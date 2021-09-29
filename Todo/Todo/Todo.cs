using System;
using System.Collections.Generic;

namespace Todo 
{
    public class Todo : TodoSet
{
    public List<Todo> Todos;
    private string task;
    private string todo;

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
