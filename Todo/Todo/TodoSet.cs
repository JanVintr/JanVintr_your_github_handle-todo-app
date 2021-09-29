using System;
using System.Collections.Generic;

namespace Todo
{
    public class TodoSet
    {
        public List<Todo> Todos;
        public List<Doing> Doings;
        public List<Review> Reviews;
        public List<Done> Dones;

        public TodoSet()
        {
            Todos = new List<Todo>();
            Doings = new List<Doing>();
            Reviews = new List<Review>();
            Dones = new List<Done>();
        }
        public void AddTodo(Todo todo)
        {
            Todos.Add(todo);
        }
        public void AddDoing(Doing doing)
        {
            Doings.Add(doing);
        }
        public void AddReview(Review review)
        {
            Reviews.Add(review);
        }
        public void RemoveDone(Done done)
        {
            Dones.Remove(done);
        }
        public void WriteTasks(Todo todo)
        {
            foreach (var todoes in Todos)
            {
                if (args == -l)
                {
                    Console.Write($"{Todos}");
                }
            }
        }
    }
}
