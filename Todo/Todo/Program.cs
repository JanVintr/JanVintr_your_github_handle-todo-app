using System;
using System.Collections.Generic;
using System.IO;

namespace Todo
{
    class Program
    {
        static void Main(string[] args)
        {
            Todo todo = new Todo("task", "todo");
            TodoSet todoSet = new TodoSet();
            FileReader fileReader = new FileReader();
            string[] items = new string[] { "walk the dog", "buy milk", "do homework" };

            //fileReader.ReadFile();
            //fileReader.WriteFile();

            Todo todo1 = new Todo("task1", "walk the dog, ");//každý řádek Todo uložit do textového souboru 
            Todo todo2 = new Todo("task2", "buy milk, ");
            Todo todo3 = new Todo("task3", "do homework, ");

            Todo todo4 = new Todo("task3", "4 - next task");

            //todoSet.AddTodo(todo1);
            //todoSet.AddTodo(todo2);
            //todoSet.AddTodo(todo3);

            if (args[0] == "-l")
            {
                if (todoSet.Todos[0] == null)
                {
                    Console.WriteLine("No todos for today! :)");
                }
                else
                {
                    todoSet.WriteTasks(todo);
                }
            }
            else if (args[0] == "-a")
            {
                todoSet.AddTodo(todo);
            }
            else if (args[0] == "-r")
            {
                todoSet.RemoveTask(todoSet.Todos[0]);
                Console.WriteLine(todoSet.Todos[0]);
            }
            else if (args[0] == "-c")
            {
                todoSet.CompleteTask(todoSet.Todos[0]);
                Console.WriteLine(todoSet.Todos[0]);
            }
            else
            {
                Console.WriteLine("Unsupported argument");
            }
        }
    }
}

