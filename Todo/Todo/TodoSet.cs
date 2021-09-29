using System;
using System.Collections.Generic;
using System.IO;

namespace Todo
{
    public class TodoSet
    {
        public List<Todo> Todos;
        string[] monkey = { "Feed the monkey" };

        public TodoSet()
        {
            Todos = new List<Todo>();
        }
        public void AddTodo(Todo todo)
        {
            Todos.Add(todo);
            string path = @"./todoTasks.txt";
            try
            {// \n nám plní funkci enteru, ale abychom to mohli zavolat ve funkci, která bere parametr
             // typu pole stringu neboli string[] nebol array stringu, tak jsme z toho museli
             // udělat string []

                //na nový řádek přidáváme nový string monkey
                File.AppendAllLines(path, new string[] { "\n" });
                File.AppendAllLines(path, monkey);
                foreach (var todoes in Todos)
                {
                    Console.WriteLine($"{todoes.todo}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to read file");
            }
        }
        public void WriteTasks(Todo todo)
        {
            foreach (var todoes in Todos)
            {
                Console.Write($"{todoes.todo}");
            }
        }
        public void RemoveTask(Todo todo)
        {
            Todos.Remove(todo);
        }
        public bool CompleteTask(Todo todo)
        {
            return true;
        }
        public void TodoDoing()
        {

        }
        public void TodoReview()
        {

        }
        public void TodoDone()
        {

        }
    }
}
