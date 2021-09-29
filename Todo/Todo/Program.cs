using System;
using System.Collections.Generic;
namespace Todo
{
    class Program
    {
        static void Main(string[] args)
        {
            Todo todo = new Todo("task", "todo");
            TodoSet todoSet = new TodoSet();
            Doing doing = new Doing("doing");
            Review review = new Review("review");
            Done done = new Done("done");

            Todo todo1 = new Todo("task1", "todo1");
            Todo todo2 = new Todo("task2", "todo2");
            Todo todo3 = new Todo("task3", "todo3");

            todoSet.AddTodo(todo1);
            todoSet.AddTodo(todo2);
            todoSet.AddTodo(todo3);

            todo.PrintTodo();
            doing.PrintDoing();
            done.RemoveDones();

            todoSet.AddDoing(doing);
            todoSet.AddReview(review);
            todoSet.RemoveDone(done);

            todoSet.WriteTasks(todo);

        }
    }
}
